package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_ThucDonDTO;

import java.util.List;

public interface CT_ThucDonService {
    List<CT_ThucDonDTO> layDSCT_ThucDonTheoThucDon(Integer idtd);

    String themCT_ThucDon(CT_ThucDonDTO ct_thucDonDTO);

    String xoaCT_ThucDon(Integer idCTTD);

    List<CT_ThucDonDTO> layDSCT_ThucDonTheoCT_DatBanTruoc(Integer idctdbt);
}
