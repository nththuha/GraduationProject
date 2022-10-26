package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_DatBanTruocDTO;
import com.example.NTH_Restaurant_API.service.CT_DatBanTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctdatbantruoc")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_DatBanTruocController {
    @Autowired
    private CT_DatBanTruocService ct_datBanTruocService;

    @GetMapping("/{idpdt}")
    private List<CT_DatBanTruocDTO> layDSCT_DatBanTruocTheoPDT(@PathVariable Integer idpdt){
        return ct_datBanTruocService.layDSCT_DatBanTruocTheoPDT(idpdt);
    }

    @PostMapping("")
    private String themCT_DatBanTruoc(@Valid @RequestBody CT_DatBanTruocDTO ct_datBanTruocDTO){
        return ct_datBanTruocService.themCT_DatBanTruoc(ct_datBanTruocDTO);
    }

    @DeleteMapping("/{idCTDBT}")
    private String xoaCT_DatBanTruoc(@PathVariable Integer idCTDBT){
        return ct_datBanTruocService.xoaCT_DatBanTruoc(idCTDBT);
    }
}
