package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.NhanVienDTO;
import com.example.NTH_Restaurant_API.service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/nhanvien")
@CrossOrigin(origins = "*", maxAge = 3600)
public class NhanVienController {
    @Autowired
    private NhanVienService nhanVienService;

    @GetMapping("/{taikhoan}")
    public NhanVienDTO layThongTinNhanVienTheoMaTaiKhoan(@PathVariable String taikhoan){
        return nhanVienService.layThongTinNhanVienTheoMaTaiKhoan(taikhoan);
    }
}
