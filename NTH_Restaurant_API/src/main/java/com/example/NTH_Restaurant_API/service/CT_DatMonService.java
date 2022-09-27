package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_DatMonDTO;

import java.util.List;

public interface CT_DatMonService {
    List<CT_DatMonDTO> layDSCT_DatMonTheoPhieuDat(Integer idpd);

    List<CT_DatMonDTO> layDSCT_DatMon_MonAn();

    List<CT_DatMonDTO> layDSCT_DatMon_NuocUong();

    List<CT_DatMonDTO> layDSCT_DatMon_MonAn_PhucVu();
}
