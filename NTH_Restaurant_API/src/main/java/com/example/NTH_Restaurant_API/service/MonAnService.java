package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.MonAnDTO;

import java.util.List;

public interface MonAnService {
    List<MonAnDTO> layDSMonAn();

    String themMonAn(MonAnDTO monAnDTO);

    String suaMonAn(MonAnDTO monAnDTO);

    String xoaMonAn(String maMA);
}
