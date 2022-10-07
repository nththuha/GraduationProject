package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_ThucDonRepository;
import com.example.NTH_Restaurant_API.service.CT_ThucDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_ThucDonServiceImpl implements CT_ThucDonService {
    @Autowired
    private CT_ThucDonRepository ct_thucDonRepository;
}
