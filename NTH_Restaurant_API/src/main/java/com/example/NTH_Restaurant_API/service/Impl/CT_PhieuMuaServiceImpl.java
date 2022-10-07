package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_PhieuMuaRepository;
import com.example.NTH_Restaurant_API.service.CT_PhieuMuaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_PhieuMuaServiceImpl implements CT_PhieuMuaService {
    @Autowired
    private CT_PhieuMuaRepository ct_phieuMuaRepository;
}
