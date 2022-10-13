package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.CT_MonAnDTO;
import com.example.NTH_Restaurant_API.service.CT_MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/ctmonan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class CT_MonAnController {
    @Autowired
    private CT_MonAnService ct_monAnService;

    @GetMapping("/{mama}")
    public List<CT_MonAnDTO> layDSCT_MonAnTheoMonAn(@PathVariable String mama){
        return ct_monAnService.layDSCT_MonAnTheoMonAn(mama);
    }

    @PostMapping("")
    public String themCT_MonAn(@Valid @RequestBody CT_MonAnDTO ct_monAnDTO){
        return ct_monAnService.themCT_MonAn(ct_monAnDTO);
    }

    @DeleteMapping("/{idCTMA}")
    public String xoaCT_MonAn(@PathVariable Integer idCTMA){
        return ct_monAnService.xoaCT_MonAn(idCTMA);
    }
}
