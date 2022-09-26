package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.LoaiMonAnDTO;
import com.example.NTH_Restaurant_API.service.LoaiMonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/loaimonan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class LoaiMonAnController {
    @Autowired
    private LoaiMonAnService loaiMonAnService;

    @GetMapping("")
    public List<LoaiMonAnDTO> layDSLoaiMonAn(){
        return loaiMonAnService.layDSLoaiMonAn();
    }

    @PostMapping("")
    public String themLoaiMonAn(@Valid @RequestBody LoaiMonAnDTO loaiMonAnDTO){
        return loaiMonAnService.themLoaiMonAn(loaiMonAnDTO);
    }

    @PutMapping("")
    public String suaLoaiMonAn(@Valid @RequestBody LoaiMonAnDTO loaiMonAnDTO){
        return loaiMonAnService.suaLoaiMonAn(loaiMonAnDTO);
    }

    @DeleteMapping("/{maLMA}")
    public String xoaLoaiMonAn(@PathVariable String maLMA){
        return loaiMonAnService.xoaLoaiMonAn(maLMA);
    }
}
