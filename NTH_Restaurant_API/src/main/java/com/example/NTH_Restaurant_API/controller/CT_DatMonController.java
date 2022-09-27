package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_DatMonDTO;
import com.example.NTH_Restaurant_API.service.CT_DatMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

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
}
