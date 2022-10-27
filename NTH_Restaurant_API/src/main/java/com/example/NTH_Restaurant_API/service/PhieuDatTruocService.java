package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.PhieuDatTruocDTO;

import java.util.List;

public interface PhieuDatTruocService {
    List<PhieuDatTruocDTO> layDSPhieuDatTruoc();

    PhieuDatTruocDTO themPhieuDatTruoc(PhieuDatTruocDTO phieuDatTruocDTO);

    String suaPhieuDatTruoc(PhieuDatTruocDTO phieuDatTruocDTO);

    String xoaPhieuDatTruoc(Integer idPDT);
}
