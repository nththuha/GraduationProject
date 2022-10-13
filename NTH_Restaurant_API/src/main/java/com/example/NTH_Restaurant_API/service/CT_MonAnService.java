package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_MonAnDTO;

import java.util.List;

public interface CT_MonAnService {
    List<CT_MonAnDTO> layDSCT_MonAnTheoMonAn(String mama);

    String themCT_MonAn(CT_MonAnDTO ct_monAnDTO);

    String xoaCT_MonAn(Integer idCTMA);
}
