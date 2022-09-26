package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.BoPhanDTO;
import com.example.NTH_Restaurant_API.service.BoPhanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("/api/bophan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class BoPhanController {
    @Autowired
    private BoPhanService boPhanService;

    @GetMapping("")
    public List<BoPhanDTO> layDSBoPhan() {
        return boPhanService.layDSBoPhan();
    }
}
