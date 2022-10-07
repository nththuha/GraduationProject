package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.TienCocRepository;
import com.example.NTH_Restaurant_API.service.TienCocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class TienCocServiceImpl implements TienCocService {
    @Autowired
    private TienCocRepository tienCocRepository;
}
