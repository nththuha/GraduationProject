package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhieuDatDTO;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatBanEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatEntity;
import com.example.NTH_Restaurant_API.repository.CT_BanRepository;
import com.example.NTH_Restaurant_API.repository.CT_DatBanRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
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

    @Autowired
    private NhanVienRepository nhanVienRepository;

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

    @Override
    public PhieuDatDTO themPhieuDat(PhieuDatDTO phieuDatDTO) {
        List<CT_BanEntity> temp = ct_banRepository.findByMaphong_MaPhong(phieuDatDTO.getMaPhong());
        CT_BanEntity ct_banEntity = null;
        for (CT_BanEntity ctBanEntity : temp) {
            if (ctBanEntity.getMaban().getMaBan().equals(phieuDatDTO.getMaBan())) {
                ct_banEntity = ctBanEntity;
                ct_banEntity.setTrangThai("Hết chỗ");
                ct_banRepository.save(ct_banEntity);
                break;
            }
        }

        NhanVienEntity nhanVien = nhanVienRepository.getById(phieuDatDTO.getIdnv());
        PhieuDatEntity phieuDat = phieuDatDTO.toEntity();
        phieuDat.setIdPD(null);
        phieuDat.setIdnv(nhanVien);

        try {
            PhieuDatEntity pd = phieuDatRepository.save(phieuDat);

            CT_DatBanEntity ct_datBan = new CT_DatBanEntity();
            ct_datBan.setIdctb(ct_banEntity);
            ct_datBan.setIdpd(pd);
            ct_datBanRepository.save(ct_datBan);

            return new PhieuDatDTO(pd);
        }
        catch (Exception e){
            return null;
        }
    }
}
