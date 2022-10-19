package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.KhachHangDTO;
import com.example.NTH_Restaurant_API.service.KhachHangService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/khachhang")
@CrossOrigin(origins = "*", maxAge = 3600)
public class KhachHangController {
    @Autowired
    private KhachHangService khachHangService;

    @GetMapping("")
    public List<KhachHangDTO> layDSKhachHang(){
        return khachHangService.layDSKhachHang();
    }

    @PostMapping("")
    public String themKhachHang(@Valid @RequestBody KhachHangDTO khachHangDTO){
        return khachHangService.themKhachHang(khachHangDTO);
    }

    @PutMapping("")
    public String suaKhachHang(@Valid @RequestBody KhachHangDTO khachHangDTO){
        return khachHangService.suaKhachHang(khachHangDTO);
    }

    @DeleteMapping("/{idKH}")
    public String xoaKhachHang(@PathVariable Integer idKH){
        return khachHangService.xoaKhachHang(idKH);
    }
}
