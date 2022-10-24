package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.ThucDonDTO;
import com.example.NTH_Restaurant_API.service.ThucDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/thucdon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class ThucDonController {
    @Autowired
    private ThucDonService thucDonService;

    @GetMapping("")
    public List<ThucDonDTO> layDSThucDon(){
        return thucDonService.layDSThucDon();
    }

    @PostMapping("")
    public String themThucDon(@Valid @RequestBody ThucDonDTO thucDonDTO){
        return thucDonService.themThucDon(thucDonDTO);
    }

    @PutMapping("")
    public String suaThucDon(@Valid @RequestBody ThucDonDTO thucDonDTO){
        return thucDonService.suaThucDon();
    }

    @DeleteMapping("/{idTD}")
    public String xoaThucDon(@PathVariable Integer idTD){
        return thucDonService.xoaThucDon();
    }
}
