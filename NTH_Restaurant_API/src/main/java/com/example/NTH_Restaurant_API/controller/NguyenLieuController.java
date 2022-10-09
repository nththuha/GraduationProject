package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;
import com.example.NTH_Restaurant_API.service.NguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/nguyenlieu")
@CrossOrigin(origins = "*", maxAge = 3600)
public class NguyenLieuController {
    @Autowired
    private NguyenLieuService nguyenLieuService;

    @GetMapping("")
    public List<NguyenLieuDTO> layDSNguyenLieu(){
        return nguyenLieuService.layDSNguyenLieu();
    }

    @PostMapping("")
    public String themNguyenLieu(@Valid @RequestBody NguyenLieuDTO nguyenLieuDTO){
        return nguyenLieuService.themNguyenLieu(nguyenLieuDTO);
    }

    @PutMapping("")
    public String suaNguyenLieu(@Valid @RequestBody NguyenLieuDTO nguyenLieuDTO){
        return nguyenLieuService.suaNguyenLieu(nguyenLieuDTO);
    }

    @DeleteMapping("/{maNL}")
    public String xoaNguyenLieu(@PathVariable String maNL){
        return nguyenLieuService.xoaNguyenLieu(maNL);
    }
}
