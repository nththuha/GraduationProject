package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_PhieuMuaDTO;
import com.example.NTH_Restaurant_API.service.CT_PhieuMuaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/ctphieumua")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_PhieuMuaController {
    @Autowired
    private CT_PhieuMuaService ct_phieuMuaService;

    @GetMapping("/{idPM}")
    public List<CT_PhieuMuaDTO> layDSCT_PhieuMuaTheoPhieuMua(@PathVariable Integer idPM){
        return ct_phieuMuaService.layDSCT_PhieuMuaTheoPhieuMua(idPM);
    }
}
