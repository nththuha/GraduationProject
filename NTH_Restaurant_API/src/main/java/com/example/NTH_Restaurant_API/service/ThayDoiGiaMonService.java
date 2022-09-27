package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.ThayDoiGiaMonDTO;

import java.util.List;

public interface ThayDoiGiaMonService {
    List<ThayDoiGiaMonDTO> layDSGiaMon(String maMA);

    String themGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO);

    public int layGiaHienTai(String maMA);

    String suaGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO);

    String xoaGiaMon(Integer idGM);
}
