package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.NhanVienDTO;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class NhanVienServiceImpl implements NhanVienService {
    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public NhanVienDTO layThongTinNhanVienTheoMaTaiKhoan(String taikhoan) {
        NhanVienEntity nhanVien = nhanVienRepository.findByTaikhoan_MaTK(taikhoan);
        return new NhanVienDTO(nhanVien);
    }
}
