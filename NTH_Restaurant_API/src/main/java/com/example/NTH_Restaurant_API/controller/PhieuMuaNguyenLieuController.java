package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.service.PhieuMuaNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.Date;
import java.util.List;

@RestController
@RequestMapping("/api/phieumuanguyenlieu")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhieuMuaNguyenLieuController {
    @Autowired
    private PhieuMuaNguyenLieuService phieuMuaNguyenLieuService;

    @PostMapping("")
    public List<NguyenLieuDTO> layDSNguyenLieuCanMua(@Valid @RequestBody PhongNgay ngay){
        return phieuMuaNguyenLieuService.layDSNguyenLieuCanMua(ngay);
    }
}
