package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.service.PhieuDatTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class PhieuDatTruocServiceImpl implements PhieuDatTruocService {
    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;
}
