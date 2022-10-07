package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.PhieuNhapNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.PhieuNhapNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class PhieuNhapNguyenLieuServiceImpl implements PhieuNhapNguyenLieuService {
    @Autowired
    private PhieuNhapNguyenLieuRepository phieuNhapNguyenLieuRepository;
}
