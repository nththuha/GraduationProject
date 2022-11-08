package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.PhieuDatDTO;
import com.example.NTH_Restaurant_API.dto.PhieuDatTruocDTO;

import java.util.List;

public interface PhieuDatService {
    List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon();

    PhieuDatDTO themPhieuDat(PhieuDatDTO phieuDatDTO);

    String themPhieuDatDuaTrenPhieuDatTruoc(PhieuDatTruocDTO phieuDatTruocDTO);
}
