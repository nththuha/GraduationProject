package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.*;
import com.example.NTH_Restaurant_API.repository.HoaDonRepository;
import com.example.NTH_Restaurant_API.repository.PhieuNhapNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.ThongKeService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

@Service
public class ThongKeServiceImpl implements ThongKeService {
    @Autowired
    private HoaDonRepository hoaDonRepository;

    @Autowired
    private PhieuNhapNguyenLieuRepository phieuNhapNguyenLieuRepository;

    @Override
    public List<ThongKeDTO> thongKeDoanhThuTheoThang(ThongKeDTO ngayDTO) {
        SimpleDateFormat thang = new SimpleDateFormat("MM");
        SimpleDateFormat nam = new SimpleDateFormat("yyyy");
        List<ThongKeDTO> list = new ArrayList<>();

        Calendar cal = Calendar.getInstance();
        cal.setTime(ngayDTO.getNgayBD());

        while (cal.getTime().getTime() <= ngayDTO.getNgayKT().getTime()) {
            ThongKeDTO thongKeDTO = new ThongKeDTO();
            thongKeDTO.setThang(thang.format(cal.getTime()));
            thongKeDTO.setNam(nam.format(cal.getTime()));
            thongKeDTO.setDoanhThu(0);
            list.add(thongKeDTO);
            cal.add(Calendar.MONTH, 1);
        }

        List<TempDTO> listTemp = hoaDonRepository.layThongKeDoanhThu(ngayDTO.getNgayBD(), ngayDTO.getNgayKT());
        List<ThongKeDTO> listT = new ArrayList<>();
        for (TempDTO temp : listTemp) {
            ThongKeDTO thongKeDTO = new ThongKeDTO();
            thongKeDTO.setThang(temp.getThang());
            thongKeDTO.setNam(temp.getNam());
            thongKeDTO.setDoanhThu(temp.getDoanhthu());
            listT.add(thongKeDTO);
        }

        for (int i = 0; i < list.size(); i++) {
            for (ThongKeDTO j : listT) {
                if (j.getThang().equals(list.get(i).getThang()) && j.getNam().equals(list.get(i).getNam())) {
                    list.get(i).setDoanhThu(j.getDoanhThu());
                }
            }
        }
        return list;
    }

    @Override
    public List<ThongKeDTO> thongKeLoiNhuanTheoThang(ThongKeDTO thongKeDTO) {
        SimpleDateFormat thang = new SimpleDateFormat("MM");
        SimpleDateFormat nam = new SimpleDateFormat("yyyy");
        List<ThongKeDTO> list = new ArrayList<>();

        Calendar cal = Calendar.getInstance();
        cal.setTime(thongKeDTO.getNgayBD());

        while (cal.getTime().getTime() <= thongKeDTO.getNgayKT().getTime()) {
            ThongKeDTO thongKe = new ThongKeDTO();
            thongKe.setThang(thang.format(cal.getTime()));
            thongKe.setNam(nam.format(cal.getTime()));
            thongKe.setDoanhThu(0);
            list.add(thongKe);
            cal.add(Calendar.MONTH, 1);
        }
        List<TempDTO> listDoanhThu = hoaDonRepository.layTongTriGiaHoaDonTheoThang(thongKeDTO.getNgayBD(), thongKeDTO.getNgayKT());
        List<NguyenLieu> listTongTGPD = hoaDonRepository.laySoNguyenLieuSuDungPD(thongKeDTO.getNgayBD(), thongKeDTO.getNgayKT());
        List<NguyenLieu> listTongTGPDT = hoaDonRepository.laySoNguyenLieuSuDungPDT(thongKeDTO.getNgayBD(), thongKeDTO.getNgayKT());
        List<NguyenLieu> listTongTG = new ArrayList<>();
        listTongTG.addAll(listTongTGPD);
        listTongTG.addAll(listTongTGPDT);
        List<TienMuaNguyenLieu> listTMNL = new ArrayList<>();
        for(NguyenLieu i: listTongTG){
            List<NguyenLieuMua> listNLM = phieuNhapNguyenLieuRepository.layThongTinNguyenLieuDaMua(i.getNam(), i.getThang(), i.getManl());
            if(listNLM.size() > 0){
                TienMuaNguyenLieu temp = new TienMuaNguyenLieu();
                temp.setThang(i.getThang());
                temp.setNam(i.getNam());
                temp.setMaNL(i.getManl());
                temp.setTriGia(listNLM.get(0).getGia() / listNLM.get(0).getSoluong() * i.getSoluong());
                listTMNL.add(temp);
            }
        }
        for(ThongKeDTO i: list){
            for(TempDTO doanhThu: listDoanhThu){
                if(doanhThu.getThang().equals(i.getThang()) && doanhThu.getNam().equals(i.getNam())){
                    i.setDoanhThu(doanhThu.getDoanhthu());
                }
            }
            for(TienMuaNguyenLieu tienMuaNguyenLieu: listTMNL){
                if(tienMuaNguyenLieu.getThang().equals(i.getThang()) && tienMuaNguyenLieu.getNam().equals(i.getNam())){
                    i.setDoanhThu(i.getDoanhThu() - tienMuaNguyenLieu.getTriGia());
                }
            }
        }

        return list;
    }

    @Override
    public List<ThongKeDTO> thongKeTienDiChoTheoNgay(ThongKeDTO thongKeDTO) {
        SimpleDateFormat ngay = new SimpleDateFormat("dd");
        SimpleDateFormat thang = new SimpleDateFormat("MM");
        SimpleDateFormat nam = new SimpleDateFormat("yyyy");
        List<ThongKeDTO> list = new ArrayList<>();

        Calendar cal = Calendar.getInstance();
        cal.setTime(thongKeDTO.getNgayBD());

        while (cal.getTime().getTime() <= thongKeDTO.getNgayKT().getTime()) {
            ThongKeDTO thongKe = new ThongKeDTO();
            thongKe.setNgay(ngay.format(cal.getTime()));
            thongKe.setThang(thang.format(cal.getTime()));
            thongKe.setNam(nam.format(cal.getTime()));
            thongKe.setDoanhThu(0);
            list.add(thongKe);
            cal.add(Calendar.DATE, 1);
        }

        List<TempDTO> listTDC = phieuNhapNguyenLieuRepository.thongKeTienDiChoTheoNgay(thongKeDTO.getNgayBD(), thongKeDTO.getNgayKT());
        for (ThongKeDTO keDTO : list) {
            for (TempDTO j : listTDC) {
                if (j.getNgay().equals(keDTO.getNgay()) && j.getThang().equals(keDTO.getThang()) && j.getNam().equals(keDTO.getNam())) {
                    keDTO.setDoanhThu(j.getDoanhthu());
                    break;
                }
            }
        }
        return list;
    }
}
