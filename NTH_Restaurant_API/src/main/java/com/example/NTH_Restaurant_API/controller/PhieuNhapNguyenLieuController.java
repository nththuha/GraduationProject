package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_PhieuMuaDTO;
import com.example.NTH_Restaurant_API.dto.CT_PhieuNhapDTO;
import com.example.NTH_Restaurant_API.dto.PhieuNhapNguyenLieuDTO;
import com.example.NTH_Restaurant_API.service.PhieuNhapNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.persistence.GeneratedValue;
import javax.validation.Valid;

@RestController
@RequestMapping("/api/phieunhapnguyenlieu")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhieuNhapNguyenLieuController {
    @Autowired
    private PhieuNhapNguyenLieuService phieuNhapNguyenLieuService;

    @PostMapping("")
    public PhieuNhapNguyenLieuDTO themPhieuNhapNguyenLieu(@Valid @RequestBody PhieuNhapNguyenLieuDTO phieuNhapNguyenLieuDTO){
        return phieuNhapNguyenLieuService.themPhieuNhapNguyenLieu(phieuNhapNguyenLieuDTO);
    }

    @PostMapping("/{idPM}")
    public String chuyenPhieuMuaThanhPhieuNhap(@PathVariable Integer idPM){
        return phieuNhapNguyenLieuService.chuyenPhieuMuaThanhPhieuNhap(idPM);
    }
}
