package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.BanDTO;
import com.example.NTH_Restaurant_API.dto.CT_BanDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.service.CT_BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctban")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_BanController {
    @Autowired
    private CT_BanService ct_banService;

    @GetMapping("/{maphong}")
    public List<BanDTO> layDSBanTheoPhong(@PathVariable String maphong){
        return ct_banService.layDSBanTheoPhong(maphong);
    }

    @GetMapping("/danhsach/{maphong}")
    public List<CT_BanDTO> layDSCTBanTheoPhong(@PathVariable String maphong) {
        return ct_banService.layDSCTBanTheoPhong(maphong);
    }

    @GetMapping("/dattruoc")
    public List<BanDTO> layDSBanTheoPhongTheoNgay(@Valid @RequestBody PhongNgay phongNgay){
        return ct_banService.layDSBanTheoPhongTheoNgay(phongNgay);
    }

    @PostMapping("")
    public String themCT_Ban(@Valid @RequestBody CT_BanDTO ct_banDTO){
        return ct_banService.themCT_Ban(ct_banDTO);
    }

    @DeleteMapping("/{idCTB}")
    public String xoaCT_Ban(@PathVariable Integer idCTB){
        return ct_banService.xoaCT_Ban(idCTB);
    }
}
