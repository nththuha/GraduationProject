package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_DatMonTruocRepository;
import com.example.NTH_Restaurant_API.service.CT_DatMonTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_DatMonTruocServiceImpl implements CT_DatMonTruocService {
    @Autowired
    private CT_DatMonTruocRepository ct_datMonTruocRepository;
}
