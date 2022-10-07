package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.service.TienCocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/tiencoc")
@CrossOrigin(origins = "*", maxAge = 3600)
public class TienCocController {
    @Autowired
    private TienCocService tienCocService;
}
