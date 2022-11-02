package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_PhieuMuaDTO;
import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;
import com.example.NTH_Restaurant_API.dto.PhieuMuaNguyenLieuDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.service.PhieuMuaNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/phieumuanguyenlieu")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhieuMuaNguyenLieuController {
    @Autowired
    private PhieuMuaNguyenLieuService phieuMuaNguyenLieuService;

    @GetMapping("")
    public List<PhieuMuaNguyenLieuDTO> layDSPhieuMuaNguyenLieu(){
        return phieuMuaNguyenLieuService.layDSPhieuMuaNguyenLieu();
    }

    @PostMapping("")
    public List<CT_PhieuMuaDTO> layDSNguyenLieuCanMua(@Valid @RequestBody PhieuMuaNguyenLieuDTO phieuMuaNguyenLieuDTO){
        return phieuMuaNguyenLieuService.layDSNguyenLieuCanMua(phieuMuaNguyenLieuDTO);
    }
}
