package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_DatBanTruocRepository;
import com.example.NTH_Restaurant_API.service.CT_DatBanTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_DatBanTruocServiceImpl implements CT_DatBanTruocService {
    @Autowired
    private CT_DatBanTruocRepository ct_datBanTruocRepository;
}
