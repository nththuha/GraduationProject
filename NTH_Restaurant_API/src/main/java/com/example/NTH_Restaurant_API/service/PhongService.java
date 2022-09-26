package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.PhongDTO;

import java.util.List;

public interface PhongService {
    List<PhongDTO> layDSPhong();

    String themPhong(PhongDTO phongDTO);

    String suaPhong(PhongDTO phongDTO);

    String xoaPhong(String maPhong);
}
