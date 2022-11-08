package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_PhieuNhapDTO;

import java.util.List;

public interface CT_PhieuNhapService {
    List<CT_PhieuNhapDTO> layDSCT_PhieuNhapTheoPhieuNhap(Integer idpn);

    String themCt_PhieuNhap(CT_PhieuNhapDTO ct_phieuNhapDTO);

    String xoaCT_PhieuNhap(Integer idCTPN);
}
