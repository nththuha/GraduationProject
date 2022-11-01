package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;

import java.util.List;

public interface PhieuMuaNguyenLieuService {
    List<NguyenLieuDTO> layDSNguyenLieuCanMua(PhongNgay ngay);
}
