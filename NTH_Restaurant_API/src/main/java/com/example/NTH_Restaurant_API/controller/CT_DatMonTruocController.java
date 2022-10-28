package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_DatMonTruocDTO;
import com.example.NTH_Restaurant_API.service.CT_DatMonTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/ctdatmontruoc")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_DatMonTruocController {
    @Autowired
    private CT_DatMonTruocService ct_datMonTruocService;

    @PostMapping("/{idpdt}")
    public List<CT_DatMonTruocDTO> layDSDatMonTheoPhieuDatTruoc(@PathVariable Integer idpdt){
        return ct_datMonTruocService.layDSDatMonTheoPhieuDatTruoc(idpdt);
    }
}
