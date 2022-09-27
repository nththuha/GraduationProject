package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.ThayDoiGiaMonDTO;
import com.example.NTH_Restaurant_API.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/thaydoigiamon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class ThayDoiGiaMonController {
    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    @GetMapping("/{mama}")
    public List<ThayDoiGiaMonDTO> layDSGiaTheoMon(@PathVariable String mama) {
        return thayDoiGiaMonService.layDSGiaMon(mama);
    }

    @PutMapping("")
    public String suaGiaMon(@Valid @RequestBody ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        return thayDoiGiaMonService.suaGiaMon(thayDoiGiaMonDTO);
    }

    @PostMapping("")
    public String themGiaMon(@Valid @RequestBody ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        return thayDoiGiaMonService.themGiaMon(thayDoiGiaMonDTO);
    }

    @DeleteMapping("/{idGM}")
    public String xoaGiaMon(@PathVariable Integer idGM) {
        return thayDoiGiaMonService.xoaGiaMon(idGM);
    }
}
