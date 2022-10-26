package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_DatBanTruocDTO;

import java.util.List;

public interface CT_DatBanTruocService {
    List<CT_DatBanTruocDTO> layDSCT_DatBanTruocTheoPDT(Integer idpdt);

    String themCT_DatBanTruoc(CT_DatBanTruocDTO ct_datBanTruocDTO);

    String xoaCT_DatBanTruoc(Integer idCTDBT);
}
