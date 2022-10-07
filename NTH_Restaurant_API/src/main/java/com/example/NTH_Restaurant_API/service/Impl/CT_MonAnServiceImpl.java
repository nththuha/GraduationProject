package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_MonAnRepository;
import com.example.NTH_Restaurant_API.service.CT_MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_MonAnServiceImpl implements CT_MonAnService {
    @Autowired
    private CT_MonAnRepository ct_monAnRepository;
}
