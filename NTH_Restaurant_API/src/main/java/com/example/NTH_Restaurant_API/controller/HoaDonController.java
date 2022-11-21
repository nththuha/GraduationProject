package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.*;
import com.example.NTH_Restaurant_API.service.HoaDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/hoadon")
@CrossOrigin(origins = "*", maxAge = 3600)
public class HoaDonController {
    @Autowired
    private HoaDonService hoaDonService;

    @PostMapping("")
    public HoaDonPD themHoaDonTheoPhieuDat(@Valid @RequestBody HoaDonDTO hoaDonDTO){
        return hoaDonService.themHoaDonTheoPhieuDat(hoaDonDTO);
    }

    @PostMapping("/phieudattruoc")
    public HoaDonPDT themHoaDonTheoPhieuDatTruoc(@Valid @RequestBody HoaDonDTO hoaDonDTO){
        return hoaDonService.themHoaDonTheoPhieuDatTruoc(hoaDonDTO);
    }

    @PostMapping("/tachhoadon")
    public List<HoaDonTach> tachHoaDon(@Valid @RequestBody List<TachHoaDon> listHD){
        return hoaDonService.tachHoaDon(listHD);
    }
}
