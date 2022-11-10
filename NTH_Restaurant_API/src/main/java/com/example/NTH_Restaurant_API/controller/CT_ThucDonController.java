package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_ThucDonDTO;
import com.example.NTH_Restaurant_API.service.CT_ThucDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctthucdon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_ThucDonController {
    @Autowired
    private CT_ThucDonService ct_thucDonService;

    @GetMapping("/{idtd}")
    public List<CT_ThucDonDTO> layDSCT_ThucDonTheoThucDon(@PathVariable Integer idtd){
        return ct_thucDonService.layDSCT_ThucDonTheoThucDon(idtd);
    }

    @GetMapping("/ctdatbantruoc/{idctdbt}")
    public List<CT_ThucDonDTO> layDSCT_ThucDonTheoCT_DatBanTruoc(@PathVariable Integer idctdbt){
        return ct_thucDonService.layDSCT_ThucDonTheoCT_DatBanTruoc(idctdbt);
    }

    @PostMapping("")
    public String themCT_ThucDon(@Valid @RequestBody CT_ThucDonDTO ct_thucDonDTO){
        return ct_thucDonService.themCT_ThucDon(ct_thucDonDTO);
    }

    @DeleteMapping("/{idCTTD}")
    public String xoaCT_ThucDon(@PathVariable Integer idCTTD){
        return ct_thucDonService.xoaCT_ThucDon(idCTTD);
    }
}
