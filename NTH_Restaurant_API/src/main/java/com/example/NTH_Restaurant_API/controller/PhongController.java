package com.example.NTH_Restaurant_API.controller;

import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/phong")
@CrossOrigin(origins = "*", maxAge = 3600)
public class PhongController {
}
