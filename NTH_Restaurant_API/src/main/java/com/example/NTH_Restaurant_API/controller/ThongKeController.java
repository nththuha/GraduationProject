package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.PhieuDatDTO;
import com.example.NTH_Restaurant_API.service.PhieuDatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/api/thongke")
@CrossOrigin(origins = "*", maxAge = 3600)
public class ThongKeController {
    @Autowired
    private PhieuDatService phieuDatService;

    @GetMapping("")
    public List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon() {
        return phieuDatService.layDSPhieuDatChuaCoHoaDon();
    }
}
