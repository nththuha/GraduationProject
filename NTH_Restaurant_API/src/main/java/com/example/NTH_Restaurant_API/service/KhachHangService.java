package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.KhachHangDTO;

import java.util.List;

public interface KhachHangService {
    List<KhachHangDTO> layDSKhachHang();

    String themKhachHang(KhachHangDTO khachHangDTO);

    String suaKhachHang(KhachHangDTO khachHangDTO);

    String xoaKhachHang(Integer idKH);
}
