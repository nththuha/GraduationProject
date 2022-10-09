package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;

import java.util.List;

public interface NguyenLieuService {
    List<NguyenLieuDTO> layDSNguyenLieu();

    String themNguyenLieu(NguyenLieuDTO nguyenLieuDTO);

    String suaNguyenLieu(NguyenLieuDTO nguyenLieuDTO);

    String xoaNguyenLieu(String maNL);
}
