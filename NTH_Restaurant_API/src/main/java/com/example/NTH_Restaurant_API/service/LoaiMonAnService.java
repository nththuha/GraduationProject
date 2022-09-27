package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.LoaiMonAnDTO;
import com.example.NTH_Restaurant_API.dto.MonAnDTO;

import java.util.List;

public interface LoaiMonAnService {
    List<LoaiMonAnDTO> layDSLoaiMonAn();

    String themLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO);

    String suaLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO);

    String xoaLoaiMonAn(String maLMA);

    List<MonAnDTO> layDSMonAnTheoLoaiMonAn(String maLMA);
}
