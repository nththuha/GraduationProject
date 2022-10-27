package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.PhieuDatTruocDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.service.PhieuDatTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.Date;
import java.util.List;

@RestController
@RequestMapping("/api/phieudattruoc")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhieuDatTruocController {
    @Autowired
    private PhieuDatTruocService phieuDatTruocService;

    @GetMapping("")
    public List<PhieuDatTruocDTO> layDSPhieuDatTruoc(){
        return phieuDatTruocService.layDSPhieuDatTruoc();
    }

    @PostMapping("/ngay/")
    public List<PhieuDatTruocDTO> layDSPhieuDatTruocTheoNgay(@Valid @RequestBody PhongNgay phongNgay){
        return phieuDatTruocService.layDSPhieuDatTruocTheoNgay(phongNgay);
    }

    @PostMapping("")
    public PhieuDatTruocDTO themPhieuDatTruoc(@Valid @RequestBody PhieuDatTruocDTO phieuDatTruocDTO){
        return phieuDatTruocService.themPhieuDatTruoc(phieuDatTruocDTO);
    }

    @PutMapping("")
    public String suaPhieuDatTruoc(@Valid @RequestBody PhieuDatTruocDTO phieuDatTruocDTO){
        return phieuDatTruocService.suaPhieuDatTruoc(phieuDatTruocDTO);
    }

    @DeleteMapping("/{idPDT}")
    public String xoaPhieuDatTruoc(@PathVariable Integer idPDT){
        return phieuDatTruocService.xoaPhieuDatTruoc(idPDT);
    }
}
