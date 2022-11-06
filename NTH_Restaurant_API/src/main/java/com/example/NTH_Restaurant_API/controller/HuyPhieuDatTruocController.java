package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.HuyPhieuDatTruocDTO;
import com.example.NTH_Restaurant_API.service.HuyPhieuDatTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;

@RestController
@RequestMapping("/api/huyphieudattruoc")
@CrossOrigin(origins = "*", maxAge = 3600)
public class HuyPhieuDatTruocController {
    @Autowired
    private HuyPhieuDatTruocService huyPhieuDatTruocService;

    @PostMapping("")
    public String themHuyPhieuDatTruoc(@Valid @RequestBody HuyPhieuDatTruocDTO huyPhieuDatTruocDTO){
        return huyPhieuDatTruocService.themHuyPhieuDatTruoc(huyPhieuDatTruocDTO);
    }
}
