package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhieuNhapNguyenLieuDTO;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.PhieuNhapNguyenLieuEntity;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.PhieuNhapNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.PhieuNhapNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class PhieuNhapNguyenLieuServiceImpl implements PhieuNhapNguyenLieuService {
    @Autowired
    private PhieuNhapNguyenLieuRepository phieuNhapNguyenLieuRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public PhieuNhapNguyenLieuDTO themPhieuNhapNguyenLieu(PhieuNhapNguyenLieuDTO phieuNhapNguyenLieuDTO) {
        if(phieuNhapNguyenLieuRepository.existsByIdPN(phieuNhapNguyenLieuDTO.getIdPN())) return null;
        NhanVienEntity nv = nhanVienRepository.getById(phieuNhapNguyenLieuDTO.getIdnv());
        PhieuNhapNguyenLieuEntity pn = phieuNhapNguyenLieuDTO.toEntity();
        pn.setIdnv(nv);
        try {
            pn = phieuNhapNguyenLieuRepository.save(pn);
            return new PhieuNhapNguyenLieuDTO(pn);
        }
        catch (Exception e){
            return null;
        }
    }
}
