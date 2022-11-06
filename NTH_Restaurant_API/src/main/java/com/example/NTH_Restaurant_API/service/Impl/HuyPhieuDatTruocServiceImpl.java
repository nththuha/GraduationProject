package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.HuyPhieuDatTruocDTO;
import com.example.NTH_Restaurant_API.entity.HuyPhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.repository.HuyPhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.service.HuyPhieuDatTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class HuyPhieuDatTruocServiceImpl implements HuyPhieuDatTruocService {
    @Autowired
    private HuyPhieuDatTruocRepository huyPhieuDatTruocRepository;

    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public String themHuyPhieuDatTruoc(HuyPhieuDatTruocDTO huyPhieuDatTruocDTO) {
        if(huyPhieuDatTruocRepository.existsByIdHPDT(huyPhieuDatTruocDTO.getIdHPDT())) return "false";
        PhieuDatTruocEntity pdt = phieuDatTruocRepository.getById(huyPhieuDatTruocDTO.getIdpdt());
        pdt.setTrangThai("Đã hủy");
        NhanVienEntity nv = nhanVienRepository.getById(huyPhieuDatTruocDTO.getIdnv());
        HuyPhieuDatTruocEntity hpdt = huyPhieuDatTruocDTO.toEntity();
        hpdt.setIdpdt(pdt);
        hpdt.setIdnv(nv);
        try {
            huyPhieuDatTruocRepository.save(hpdt);
            phieuDatTruocRepository.save(pdt);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
