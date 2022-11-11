package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.*;
import com.example.NTH_Restaurant_API.entity.*;
import com.example.NTH_Restaurant_API.repository.*;
import com.example.NTH_Restaurant_API.service.HoaDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class HoaDonServiceImpl implements HoaDonService {
    @Autowired
    private HoaDonRepository hoaDonRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private CT_DatMonRepository ct_datMonRepository;

    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    public static HashMap<String, String> hm_tien = new HashMap<String, String>() {
        {
            put("0", "không");
            put("1", "một");
            put("2", "hai");
            put("3", "ba");
            put("4", "bốn");
            put("5", "năm");
            put("6", "sáu");
            put("7", "bảy");
            put("8", "tám");
            put("9", "chín");
        }
    };
    public static HashMap<String, String> hm_hanh = new HashMap<String, String>() {
        {
            put("1", "");
            put("2", "mươi");
            put("3", "trăm");
            put("4", "nghìn");
            put("5", "mươi");
            put("6", "trăm");
            put("7", "triệu");
            put("8", "mươi");
            put("9", "trăm");
            put("10", "tỷ");
            put("11", "mươi");
            put("12", "trăm");
            put("13", "nghìn");
            put("14", "mươi");
            put("15", "trăm");
        }
    };

    public String chuyenSangChu(String x) {
        StringBuilder kq = new StringBuilder();
        String m = x;
        int dem = m.length();
        String dau = "";
        int flag10 = 1;
        while (!m.equals("")) {
            if (m.length() <= 3 && m.length() > 1 && Long.parseLong(m) == 0) {
            } else {
                dau = m.substring(0, 1);
                if (dem % 3 == 1 && m.startsWith("1") && flag10 == 0) {
                    kq.append("mốt ");
                } else if (dem % 3 == 1 && m.startsWith("5") && flag10 == 0) {
                    kq.append("lăm ");
                } else if (dem % 3 == 2 && m.startsWith("1")) {
                    kq.append("mười ");
                    flag10 = 1;
                } else if (dem % 3 == 2 && m.startsWith("0") && m.charAt(1) != '0') {
                    kq.append("lẻ ");
                    flag10 = 1;
                } else {
                    if (!m.startsWith("0")) {
                        kq.append(hm_tien.get(dau)).append(" ");
                        flag10 = 0;
                    }
                }
                if (dem % 3 != 1 && m.startsWith("0")) {
                    //lẻ -> do nothing
                } else {
                    if (dem % 3 == 2 && (m.startsWith("1") || m.startsWith("0"))) {
                        //mười -> do nothing
                    } else {
                        kq.append(hm_hanh.get(dem + "")).append(" ");
                    }
                }
            }
            m = m.substring(1);
            dem = m.length();
        }
        kq = new StringBuilder(kq.substring(0, kq.length() - 1));
        String ketQua = kq.toString();
        ketQua = ketQua.substring(0, 1).toUpperCase() + ketQua.substring(1);
        return ketQua;
    }

    @Override
    public HoaDonPD themHoaDonTheoPhieuDat(HoaDonDTO hoaDonDTO) {
        NhanVienEntity nv = nhanVienRepository.getById(hoaDonDTO.getIdnv());
        HoaDonEntity hoaDon = hoaDonDTO.toEntity();
        hoaDon.setIdnv(nv);
        List<CT_DatMonEntity> listCTDM = new ArrayList<>();
        List<PhieuDatDTO> listPDDTO = hoaDonDTO.getPhieudatList();
        List<PhieuDatEntity> listPD = new ArrayList<>();
        for(PhieuDatDTO i:  listPDDTO){
            listPD.add(phieuDatRepository.getById(i.getIdPD()));
            List<CT_DatMonEntity> temp = ct_datMonRepository.findByIdpd_IdPD(i.getIdPD());
            listCTDM.addAll(temp);

            CT_DatBanEntity ct_datBan = ct_datBanRepository.findByIdpd_IdPD(i.getIdPD());
            CT_BanEntity ctBan = ct_datBan.getIdctb();
            ctBan.setTrangThai("Còn chỗ");
            ct_banRepository.save(ctBan);

        }
        int tong = 0;
        List<CT_DatMonEntity> listCT = new ArrayList<>();
        for(int i = 0; i < listCTDM.size(); i++){
            tong += listCTDM.get(i).getGia();
            if(i == 0){
                listCT.add(listCTDM.get(i));
            }
            else{
                boolean xet =  false; //true -> vào dc if
                for (CT_DatMonEntity ct_datMonEntity : listCT) {
                    if (ct_datMonEntity.getMama().getMaMA().equals(listCTDM.get(i).getMama().getMaMA())) {
                        xet = true;
                        ct_datMonEntity.setGia(ct_datMonEntity.getGia() + listCTDM.get(i).getGia());
                        ct_datMonEntity.setSoLuong(ct_datMonEntity.getSoLuong() + listCTDM.get(i).getSoLuong());
                    }
                }
                if(!xet){
                    listCT.add(listCTDM.get(i));
                }
            }
        }

        hoaDon.setTrigia(tong);
        hoaDon.setGiaSauThue((int) (tong * 1.1));


        try {
            hoaDon = hoaDonRepository.save(hoaDon);
            for(PhieuDatEntity i: listPD){
                i.setMahd(hoaDon);
                phieuDatRepository.save(i);
            }
            HoaDonPD hoaDonPD = new HoaDonPD(hoaDon);
            hoaDonPD.setCtDatMonList(listCT.stream().map(CT_DatMonDTO::new).collect(Collectors.toList()));
            hoaDonPD.setGiaChu(chuyenSangChu(hoaDon.getGiaSauThue().toString()));
            return hoaDonPD;
        }
        catch (Exception e){
            return null;
        }
    }

    @Override
    public HoaDonPDT themHoaDonTheoPhieuDatTruoc(HoaDonDTO hoaDonDTO) {
        return null;
    }
}
