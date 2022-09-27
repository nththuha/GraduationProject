package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.MonAnDTO;
import com.example.NTH_Restaurant_API.service.MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api/monan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class MonAnController {
    @Autowired
    private MonAnService monAnService;

    @GetMapping("")
    public List<MonAnDTO> layDSMonAn(){
        return monAnService.layDSMonAn();
    }

    @PostMapping("")
    public String themMonAn(@Valid @RequestBody MonAnDTO monAnDTO){
        return monAnService.themMonAn(monAnDTO);
    }

    @PutMapping("")
    public String suaMonAn(@Valid @RequestBody MonAnDTO monAnDTO){
        return monAnService.suaMonAn(monAnDTO);
    }

    @DeleteMapping("/{maMA}")
    public String xoaMonAn(@PathVariable String maMA){
        return monAnService.xoaMonAn(maMA);
    }
}
