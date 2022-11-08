package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.BanDTO;
import com.example.NTH_Restaurant_API.dto.BanDaDat;
import com.example.NTH_Restaurant_API.dto.CT_BanDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.entity.BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.PhongEntity;
import com.example.NTH_Restaurant_API.repository.BanRepository;
import com.example.NTH_Restaurant_API.repository.CT_BanRepository;
import com.example.NTH_Restaurant_API.repository.PhongRepository;
import com.example.NTH_Restaurant_API.service.CT_BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_BanServiceImpl implements CT_BanService {
    @Autowired
    private CT_BanRepository ct_banRepository;

    @Autowired
    private BanRepository banRepository;

    @Autowired
    private PhongRepository phongRepository;

    @Override
    public List<BanDTO> layDSBanTheoPhong(String maphong) {
        Date d = new Date();
        SimpleDateFormat sdf = new SimpleDateFormat("HH");
        SimpleDateFormat sdfNgay = new SimpleDateFormat("yyyy-MM-dd");

        System.out.println("Ngày: " + new Date());
        System.out.println("Giờ: " + Integer.valueOf(sdf.format(d)));
        List<BanDaDat> listT = ct_banRepository.layCTBanDaDatTrongNgay(new Date(sdfNgay.format(d)), Integer.valueOf(sdf.format(d)), maphong);
        System.out.println("Độ dài: " +  listT.size());
        List<CT_BanEntity> dsCT_Ban = ct_banRepository.findByMaphong_MaPhong(maphong);
        List<BanDTO> dsBan = new ArrayList<>();
        for (int i = 0; i < dsCT_Ban.size(); i++) {
            for (int j = i; j < dsCT_Ban.size(); j++) {
                if (dsCT_Ban.get(i).getIdCTB() > dsCT_Ban.get(j).getIdCTB()) {
                    CT_BanEntity temp = dsCT_Ban.get(i);
                    dsCT_Ban.set(i, dsCT_Ban.get(j));
                    dsCT_Ban.set(j, temp);
                }
            }
        }
        for (CT_BanEntity item : dsCT_Ban) {
            BanDTO temp = new BanDTO(item.getMaban());
            temp.setTrangThai(item.getTrangThai());
            dsBan.add(temp);
        }

        for(BanDTO ban: dsBan){
            for(BanDaDat b: listT){
                if(ban.getMaBan().equals(b.getMaban())){
                    ban.setTrangThai("Đã đặt");
                }
            }
        }
        return dsBan;
    }

    @Override
    public List<CT_BanDTO> layDSCTBanTheoPhong(String maphong) {
        List<CT_BanEntity> list = ct_banRepository.findByMaphong_MaPhong(maphong);
        return list.stream().map(CT_BanDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themCT_Ban(CT_BanDTO ct_banDTO) {
        List<CT_BanEntity> list = ct_banRepository.findByMaphong_MaPhong(ct_banDTO.getMaphong());
        for (CT_BanEntity item : list) {
            if (item.getMaban().getMaBan().equals(ct_banDTO.getMaban())) {
                return "false";
            }
        }
        PhongEntity phong = phongRepository.getById(ct_banDTO.getMaphong());
        BanEntity ban = banRepository.getById(ct_banDTO.getMaban());
        CT_BanEntity ct_ban = ct_banDTO.toEntity();
        ct_ban.setIdCTB(null);
        ct_ban.setMaphong(phong);
        ct_ban.setMaban(ban);
        ct_ban.setTrangThai("Còn chỗ");
        try {
            ct_banRepository.save(ct_ban);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaCT_Ban(Integer idCTB) {
        if(!ct_banRepository.existsById(idCTB)){
            return "false";
        }
        try {
            ct_banRepository.deleteById(idCTB);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public List<BanDTO> layDSBanTheoPhongTheoNgay(PhongNgay phongNgay) {
        List<BanDaDat> listT = ct_banRepository.layCTBanDaDat(phongNgay.getNgay(), phongNgay.getGio(), phongNgay.getMaPhong());
        List<BanDTO> listB = layDSBanTheoPhong(phongNgay.getMaPhong());
        for(BanDTO ban: listB){
            ban.setTrangThai("Còn chỗ");
            for(BanDaDat i: listT){
                if(ban.getMaBan().equals(i.getMaban())){
                    ban.setTrangThai("Đã đặt");
                }
            }
        }
        return listB;
    }
}
