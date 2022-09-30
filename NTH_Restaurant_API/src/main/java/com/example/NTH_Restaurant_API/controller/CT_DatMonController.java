package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_DatMonDTO;
import com.example.NTH_Restaurant_API.service.CT_DatMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctdatmon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_DatMonController {
    @Autowired
    private CT_DatMonService ct_datMonService;

    @GetMapping("/{idpd}")
    public List<CT_DatMonDTO> layDSCT_DatMonTheoPhieuDat(@PathVariable Integer idpd) {
        return ct_datMonService.layDSCT_DatMonTheoPhieuDat(idpd);
    }

    @GetMapping("/bep/monan")
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn() {
        return ct_datMonService.layDSCT_DatMon_MonAn();
    }

    @GetMapping("/phache/nuocuong")
    public List<CT_DatMonDTO> layDSCT_DatMon_NuocUong() {
        return ct_datMonService.layDSCT_DatMon_NuocUong();
    }

    @GetMapping("/phucvu/monan")
    public List<CT_DatMonDTO> layDSCT_DatMon_MonAn_PhucVu() {
        return ct_datMonService.layDSCT_DatMon_MonAn_PhucVu();
    }

    @PostMapping("")
    public String themCT_DatMon(@Valid @RequestBody CT_DatMonDTO ct_datMonDTO){
        return ct_datMonService.themCT_DatMon(ct_datMonDTO);
    }

    @PutMapping("/danglam/{idCTDM}")
    public String suaTrangThai_DangLam(@PathVariable Integer idCTDM){
        return ct_datMonService.suaTrangThai_DangLam(idCTDM);
    }

    @PutMapping("/chophucvu/{idCTDM}")
    public String suaTrangThai_ChoPhucVu(@PathVariable Integer idCTDM){
        return ct_datMonService.suaTrangThai_ChoPhucVu(idCTDM);
    }

    @PutMapping("/daphucvu/{idCTDM}")
    public String suaTrangThai_DaPhucVu(@PathVariable Integer idCTDM){
        return ct_datMonService.suaTrangThai_DaPhucVu(idCTDM);
    }

    @DeleteMapping("/{idCTDM}")
    public String xoaCT_DatMon(@PathVariable Integer idCTDM){
        return ct_datMonService.xoaCT_DatMon(idCTDM);
    }
}
