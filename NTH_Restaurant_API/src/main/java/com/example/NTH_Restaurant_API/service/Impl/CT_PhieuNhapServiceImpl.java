package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_PhieuNhapDTO;
import com.example.NTH_Restaurant_API.entity.CT_PhieuNhapEntity;
import com.example.NTH_Restaurant_API.entity.NguyenLieuEntity;
import com.example.NTH_Restaurant_API.entity.PhieuNhapNguyenLieuEntity;
import com.example.NTH_Restaurant_API.repository.CT_PhieuNhapRepository;
import com.example.NTH_Restaurant_API.repository.NguyenLieuRepository;
import com.example.NTH_Restaurant_API.repository.PhieuNhapNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.CT_PhieuNhapService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.parameters.P;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_PhieuNhapServiceImpl implements CT_PhieuNhapService {
    @Autowired
    private CT_PhieuNhapRepository ct_phieuNhapRepository;

    @Autowired
    private PhieuNhapNguyenLieuRepository phieuNhapNguyenLieuRepository;

    @Autowired
    private NguyenLieuRepository nguyenLieuRepository;

    @Override
    public List<CT_PhieuNhapDTO> layDSCT_PhieuNhapTheoPhieuNhap(Integer idpn) {
        List<CT_PhieuNhapEntity> listCTPN = ct_phieuNhapRepository.findByIdpn_IdPN(idpn);
        return listCTPN.stream().map(CT_PhieuNhapDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themCt_PhieuNhap(CT_PhieuNhapDTO ct_phieuNhapDTO) {
        if(ct_phieuNhapRepository.existsByIdCTPN(ct_phieuNhapDTO.getIdCTPN())) return "false";
        PhieuNhapNguyenLieuEntity pn = phieuNhapNguyenLieuRepository.getById(ct_phieuNhapDTO.getIdpn());
        NguyenLieuEntity nl = nguyenLieuRepository.getById(ct_phieuNhapDTO.getManl());
        nl.setSlTon(nl.getSlTon() + ct_phieuNhapDTO.getSoLuong());
        CT_PhieuNhapEntity ct_phieuNhap = ct_phieuNhapDTO.toEntity();
        ct_phieuNhap.setIdpn(pn);
        ct_phieuNhap.setManl(nl);
        try {
            ct_phieuNhapRepository.save(ct_phieuNhap);
            nguyenLieuRepository.save(nl);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaCT_PhieuNhap(Integer idCTPN) {
        if(!ct_phieuNhapRepository.existsByIdCTPN(idCTPN)) return "false";
        CT_PhieuNhapEntity ct_phieuNhap = ct_phieuNhapRepository.getById(idCTPN);
        NguyenLieuEntity nl = ct_phieuNhap.getManl();
        nl.setSlTon(nl.getSlTon() - ct_phieuNhap.getSoLuong());
        try {
            ct_phieuNhapRepository.deleteById(idCTPN);
            nguyenLieuRepository.save(nl);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaCT_PhieuNhap(CT_PhieuNhapDTO ct_phieuNhapDTO) {
        if(!ct_phieuNhapRepository.existsByIdCTPN(ct_phieuNhapDTO.getIdCTPN())) return "false";
        CT_PhieuNhapEntity temp = ct_phieuNhapRepository.getById(ct_phieuNhapDTO.getIdCTPN());
        CT_PhieuNhapEntity ct_phieuNhap = ct_phieuNhapDTO.toEntity();
        PhieuNhapNguyenLieuEntity phieuNhap = phieuNhapNguyenLieuRepository.getById(ct_phieuNhapDTO.getIdpn());
        NguyenLieuEntity nguyenLieu = nguyenLieuRepository.getById(ct_phieuNhapDTO.getManl());
        ct_phieuNhap.setIdpn(phieuNhap);
        ct_phieuNhap.setManl(nguyenLieu);
        nguyenLieu.setSlTon(nguyenLieu.getSlTon() - temp.getSoLuong() + ct_phieuNhapDTO.getSoLuong());
        try {
            ct_phieuNhapRepository.save(ct_phieuNhap);
            nguyenLieuRepository.save(nguyenLieu);
            return "true";
        }
        catch (Exception e) {
            return "false";
        }
    }
}
