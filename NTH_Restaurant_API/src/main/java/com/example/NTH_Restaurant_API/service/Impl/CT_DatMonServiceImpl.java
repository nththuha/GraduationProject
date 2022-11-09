package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_DatMonDTO;
import com.example.NTH_Restaurant_API.entity.*;
import com.example.NTH_Restaurant_API.repository.*;
import com.example.NTH_Restaurant_API.service.CT_DatMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_DatMonServiceImpl implements CT_DatMonService {
    @Autowired
    private CT_DatMonRepository ct_datMonRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMonTheoPhieuDat(Integer idpd) {
        List<CT_DatMonEntity> ds = ct_datMonRepository.findByIdpd_IdPD(idpd);
        for (int i = 0; i < ds.size(); i++) {
            for (int j = i; j < ds.size(); j++) {
                if (ds.get(i).getIdCTDM() > ds.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = ds.get(i);
                    ds.set(i, ds.get(j));
                    ds.set(j, temp);
                }
            }
        }

        List<CT_DatMonDTO> dsCTDM = ds.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        for (int i = 0; i < ds.size(); i++) {
            dsCTDM.get(i).setGiaTungMon(dsCTDM.get(i).getGia() / dsCTDM.get(i).getSoLuong());
        }
        return dsCTDM;
    }

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn() {
        List<CT_DatMonEntity> ds = ct_datMonRepository.findAll();
        List<CT_DatMonEntity> list = new ArrayList<>();
        for (CT_DatMonEntity d : ds) {
            if (d.getTrangThai().equals("Vừa đặt món") || d.getTrangThai().equals("Đang làm")) {
                if (!d.getMama().getMalma().getTenLMA().equals("Đồ uống pha chế") && !d.getMama().getMalma().getTenLMA().equals("Đồ uống đóng chai")) {
                    list.add(d);
                }
            }
        }

        for (int i = 0; i < list.size(); i++) {
            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(i).getIdCTDM() > list.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = list.get(i);
                    list.set(i, list.get(j));
                    list.set(j, temp);
                }
            }
        }

        List<CT_DatMonDTO> m = list.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        for (int i = 0; i < m.size(); i++) {
            List<CT_DatBanEntity> listCTDB = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
            CT_DatBanEntity ct_datBanEntity = listCTDB.get(0);
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                m.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                m.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return m;
    }

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMon_NuocUong() {
        List<CT_DatMonEntity> ds = ct_datMonRepository.findAll();
        List<CT_DatMonEntity> list = new ArrayList<>();
        for (CT_DatMonEntity d : ds) {
            if (d.getTrangThai().equals("Vừa đặt món") || d.getTrangThai().equals("Đang làm")) {
                if (d.getMama().getMalma().getTenLMA().equals("Đồ uống pha chế") || d.getMama().getMalma().getTenLMA().equals("Đồ uống đóng chai")) {
                    list.add(d);
                }
            }
        }

        for (int i = 0; i < list.size(); i++) {
            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(i).getIdCTDM() > list.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = list.get(i);
                    list.set(i, list.get(j));
                    list.set(j, temp);
                }
            }
        }

        List<CT_DatMonDTO> m = list.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        for (int i = 0; i < m.size(); i++) {
            List<CT_DatBanEntity> listCTDB = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
            CT_DatBanEntity ct_datBanEntity = listCTDB.get(0);
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                m.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                m.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return m;
    }

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn_PhucVu() {
        List<CT_DatMonEntity> ds = ct_datMonRepository.findAll();
        List<CT_DatMonEntity> list = new ArrayList<>();
        for (CT_DatMonEntity d : ds) {
            if (d.getTrangThai().equals("Chờ phục vụ")) {
                list.add(d);
            }
        }

        for (int i = 0; i < list.size(); i++) {
            for (int j = i + 1; j < list.size(); j++) {
                if (list.get(i).getIdCTDM() > list.get(j).getIdCTDM()) {
                    CT_DatMonEntity temp = list.get(i);
                    list.set(i, list.get(j));
                    list.set(j, temp);
                }
            }
        }

        List<CT_DatMonDTO> m = list.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
        for (int i = 0; i < m.size(); i++) {
            List<CT_DatBanEntity> listCTDB = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
            CT_DatBanEntity ct_datBanEntity = listCTDB.get(0);
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                m.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                m.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return m;
    }

    @Override
    public String themCT_DatMon(CT_DatMonDTO ct_datMonDTO) {
        PhieuDatEntity phieuDat = phieuDatRepository.getById(ct_datMonDTO.getIdpd());
        MonAnEntity monAn = monAnRepository.getById(ct_datMonDTO.getMama());
        CT_DatMonEntity ct_datMon = ct_datMonDTO.toEntity();
        ct_datMon.setIdCTDM(null);
        ct_datMon.setIdpd(phieuDat);
        ct_datMon.setMama(monAn);
        try {
            ct_datMonRepository.save(ct_datMon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaTrangThai_DangLam(Integer idCTDM) {
        CT_DatMonEntity ct_datMon = ct_datMonRepository.getById(idCTDM);
        ct_datMon.setTrangThai("Đang làm");
        try {
            ct_datMonRepository.save(ct_datMon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaTrangThai_ChoPhucVu(Integer idCTDM) {
        CT_DatMonEntity ct_datMon = ct_datMonRepository.getById(idCTDM);
        ct_datMon.setTrangThai("Chờ phục vụ");
        try {
            ct_datMonRepository.save(ct_datMon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaTrangThai_DaPhucVu(Integer idCTDM) {
        CT_DatMonEntity ct_datMon = ct_datMonRepository.getById(idCTDM);
        ct_datMon.setTrangThai("Đã phục vụ");
        try {
            ct_datMonRepository.save(ct_datMon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaCT_DatMon(Integer idCTDM) {
        try {
            ct_datMonRepository.deleteById(idCTDM);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaCT_DatMon(CT_DatMonDTO ct_datMonDTO) {
        MonAnEntity monAn = monAnRepository.getById(ct_datMonDTO.getMama());
        PhieuDatEntity phieuDat = phieuDatRepository.getById(ct_datMonDTO.getIdpd());
        CT_DatMonEntity ct_datMon = ct_datMonDTO.toEntity();
        ct_datMon.setMama(monAn);
        ct_datMon.setIdpd(phieuDat);
        try {
            ct_datMonRepository.save(ct_datMon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
