package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_PhieuNhapDTO;
import com.example.NTH_Restaurant_API.service.CT_PhieuNhapService;
import org.hibernate.validator.constraints.pl.REGON;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctphieunhap")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_PhieuNhapController {
    @Autowired
    private CT_PhieuNhapService ct_phieuNhapService;

    @GetMapping("/{idpn}")
    public List<CT_PhieuNhapDTO> layDSCT_PhieuNhapTheoPhieuNhap(@PathVariable Integer idpn){
        return ct_phieuNhapService.layDSCT_PhieuNhapTheoPhieuNhap(idpn);
    }

    @PostMapping("")
    public String themCT_PhieuNhap(@Valid @RequestBody CT_PhieuNhapDTO ct_phieuNhapDTO){
        return ct_phieuNhapService.themCt_PhieuNhap(ct_phieuNhapDTO);
    }

    @DeleteMapping("/{idCTPN}")
    public String xoaCT_PhieuNhap(@PathVariable Integer idCTPN){
        return ct_phieuNhapService.xoaCT_PhieuNhap(idCTPN);
    }
}
