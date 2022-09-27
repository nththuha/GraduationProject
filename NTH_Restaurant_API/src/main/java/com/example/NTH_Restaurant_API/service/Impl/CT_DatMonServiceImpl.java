package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_DatMonDTO;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatBanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatMonEntity;
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
        return ds.stream().map(CT_DatMonDTO::new).collect(Collectors.toList());
    }

    @Override
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn() {
        List<CT_DatMonEntity> ds = ct_datMonRepository.findAll();
        List<CT_DatMonEntity> list = new ArrayList<>();
        for (CT_DatMonEntity d : ds) {
            if (d.getTrangThai().equals("Vừa đặt món") || d.getTrangThai().equals("Đang làm")) {
                if (!d.getMama().getTenMA().equals("Đồ uống pha chế") && !d.getMama().getTenMA().equals("Đồ uống đóng chai")) {
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
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
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
                if (d.getMama().getTenMA().equals("Đồ uống pha chế") || d.getMama().getTenMA().equals("Đồ uống đóng chai")) {
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
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
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
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(m.get(i).getIdpd());
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                m.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                m.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return m;
    }
}
