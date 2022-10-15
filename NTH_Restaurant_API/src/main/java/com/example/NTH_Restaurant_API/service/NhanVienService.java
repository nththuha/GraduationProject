package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.NhanVienDTO;
import com.example.NTH_Restaurant_API.payload.request.SignupRequest;

import java.util.List;

public interface NhanVienService {
    NhanVienDTO layThongTinNhanVienTheoMaTaiKhoan(String taikhoan);

    List<SignupRequest> layDSNhanVienVaTaiKhoan();
}
