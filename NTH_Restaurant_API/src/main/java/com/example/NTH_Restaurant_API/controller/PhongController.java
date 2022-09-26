package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.PhongDTO;
import com.example.NTH_Restaurant_API.service.PhongService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/phong")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhongController {
    @Autowired
    private PhongService phongService;

    @GetMapping("")
    public List<PhongDTO> layDSPhong(){
        return phongService.layDSPhong();
    }

    @PostMapping("")
    public String themPhong(@Valid @RequestBody PhongDTO phongDTO){
        return phongService.themPhong(phongDTO);
    }

    @PutMapping("")
    public String suaPhong(@Valid @RequestBody PhongDTO phongDTO){
        return phongService.suaPhong(phongDTO);
    }

    @DeleteMapping("/{maPhong}")
    public String xoaPhong(@PathVariable String maPhong){
        return phongService.xoaPhong(maPhong);
    }
}
