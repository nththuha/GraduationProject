package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.PhieuDatDTO;
import com.example.NTH_Restaurant_API.dto.PhieuDatTruocDTO;
import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.service.PhieuDatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/phieudat")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhieuDatController {
    @Autowired
    private PhieuDatService phieuDatService;

    @GetMapping("")
    public List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon() {
        return phieuDatService.layDSPhieuDatChuaCoHoaDon();
    }

    @GetMapping("/phieudattruoc")
    public List<PhieuDatDTO> layDSPhieuDatPhieuDatTruoc() {
        return phieuDatService.layDSPhieuDatPhieuDatTruoc();
    }

    @PostMapping("")
    public PhieuDatDTO themPhieuDat(@Valid @RequestBody PhieuDatDTO phieuDatDTO){
        return phieuDatService.themPhieuDat(phieuDatDTO);
    }

    @PutMapping("/phieudattruoc")
    public String themPhieuDatDuaTrenPhieuDatTruoc(@Valid @RequestBody PhieuDatTruocDTO phieuDatTruocDTO){
        return phieuDatService.themPhieuDatDuaTrenPhieuDatTruoc(phieuDatTruocDTO);
    }
}
