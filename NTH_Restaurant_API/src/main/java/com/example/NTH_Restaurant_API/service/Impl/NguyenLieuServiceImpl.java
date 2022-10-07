package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.NguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.NguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class NguyenLieuServiceImpl implements NguyenLieuService {
    @Autowired
    private NguyenLieuRepository nguyenLieuRepository;
}
