package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_PhieuNhapRepository;
import com.example.NTH_Restaurant_API.service.CT_PhieuNhapService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_PhieuNhapServiceImpl implements CT_PhieuNhapService {
    @Autowired
    private CT_PhieuNhapRepository ct_phieuNhapRepository;
}
