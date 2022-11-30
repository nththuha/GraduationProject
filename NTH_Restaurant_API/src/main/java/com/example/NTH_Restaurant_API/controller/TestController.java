package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.service.HoaDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/test")
@CrossOrigin(origins = "*", maxAge = 3600)
public class TestController {
    @Autowired
    private HoaDonService hoaDonService;

    @GetMapping("/{so}")
    public String docSo(@PathVariable String so){
        return hoaDonService.chuyenSangChu(so);
    }
}
