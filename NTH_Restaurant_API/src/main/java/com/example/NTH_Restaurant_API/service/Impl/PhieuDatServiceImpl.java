package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhieuDatDTO;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatBanEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatEntity;
import com.example.NTH_Restaurant_API.repository.CT_BanRepository;
import com.example.NTH_Restaurant_API.repository.CT_DatBanRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatRepository;
import com.example.NTH_Restaurant_API.service.PhieuDatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class PhieuDatServiceImpl implements PhieuDatService {
    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon() {
        List<PhieuDatEntity> ds = phieuDatRepository.findAll();

        for (int i = 0; i < ds.size(); i++) {
            if (ds.get(i).getMahd() != null) {
                ds.remove(ds.get(i));
                i--;
            }
        }

        List<PhieuDatDTO> list = new ArrayList<>();

        for (int i = 0; i < ds.size(); i++) {
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(ds.get(i).getIdPD());
            if (ct_datBanEntity.getIdctb() != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                list.add(new PhieuDatDTO(ds.get(i)));
                list.get(i).setMaPhong(ct_banEntity.getMaphong().getMaPhong());
                list.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                list.get(i).setMaBan(ct_banEntity.getMaban().getMaBan());
                list.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }
        }
        return list;
    }
}
