package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhieuDatTruocDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.entity.KhachHangEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.repository.KhachHangRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.service.PhieuDatTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class PhieuDatTruocServiceImpl implements PhieuDatTruocService {
    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;

    @Autowired
    private KhachHangRepository khachHangRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public List<PhieuDatTruocDTO> layDSPhieuDatTruoc() {
        List<PhieuDatTruocEntity> listPDT = phieuDatTruocRepository.layDSPhieuDatTruoc();
        return listPDT.stream().map(PhieuDatTruocDTO::new).collect(Collectors.toList());
    }

    @Override
    public PhieuDatTruocDTO themPhieuDatTruoc(PhieuDatTruocDTO phieuDatTruocDTO) {
        PhieuDatTruocEntity pd = phieuDatTruocDTO.toEntity();
        KhachHangEntity kh = khachHangRepository.getById(phieuDatTruocDTO.getIdkh());
        NhanVienEntity nv = nhanVienRepository.getById(phieuDatTruocDTO.getIdnv());
        pd.setIdkh(kh);
        pd.setIdnv(nv);
        try {
            return new PhieuDatTruocDTO(phieuDatTruocRepository.save(pd));
        }
        catch (Exception e) {
            return null;
        }
    }

    @Override
    public String suaPhieuDatTruoc(PhieuDatTruocDTO phieuDatTruocDTO) {
        if(!phieuDatTruocRepository.existsByIdPDT(phieuDatTruocDTO.getIdPDT())) return "false";
        PhieuDatTruocEntity pd = phieuDatTruocRepository.getById(phieuDatTruocDTO.getIdPDT());
        pd.setNgayDat(phieuDatTruocDTO.getNgayDat());
        pd.setGioDat(phieuDatTruocDTO.getGioDat());
        try {
            phieuDatTruocRepository.save(pd);
            return "true";
        }
        catch (Exception e) {
            return "false";
        }
    }

    @Override
    public String xoaPhieuDatTruoc(Integer idPDT) {
        return null;
    }

    @Override
    public List<PhieuDatTruocDTO> layDSPhieuDatTruocTheoNgay(PhongNgay phongNgay) {
        List<PhieuDatTruocEntity> listPDT = phieuDatTruocRepository.layDSPhieuDatTruocNgayNgay(phongNgay.getNgay());
        return listPDT.stream().map(PhieuDatTruocDTO::new).collect(Collectors.toList());
    }
}
