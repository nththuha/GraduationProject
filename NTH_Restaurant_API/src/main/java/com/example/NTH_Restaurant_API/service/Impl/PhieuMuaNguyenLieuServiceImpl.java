package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.PhieuMuaNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.PhieuMuaNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class PhieuMuaNguyenLieuServiceImpl implements PhieuMuaNguyenLieuService {
    @Autowired
    private PhieuMuaNguyenLieuRepository phieuMuaNguyenLieuRepository;
}
