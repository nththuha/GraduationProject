package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.TienCocDTO;
import com.example.NTH_Restaurant_API.service.TienCocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/tiencoc")
@CrossOrigin(origins = "*", maxAge = 3600)
public class TienCocController {
    @Autowired
    private TienCocService tienCocService;

    @GetMapping("/{idpdt}")
    public List<TienCocDTO> layDSTienCocTheoPDT(@PathVariable Integer idpdt){
        return tienCocService.latDSTienCocTheoPDT(idpdt);
    }

    @PostMapping("")
    public String themTienCoc(@Valid @RequestBody TienCocDTO tienCocDTO){
        return tienCocService.themTienCoc(tienCocDTO);
    }

    @DeleteMapping("/{idTC}")
    public String xoaTienCoc(@PathVariable Integer idTC){
        return tienCocService.xoaTienCoc(idTC);
    }
}
