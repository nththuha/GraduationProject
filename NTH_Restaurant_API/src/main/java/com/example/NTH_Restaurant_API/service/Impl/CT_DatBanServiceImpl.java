package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.CT_DatBanRepository;
import com.example.NTH_Restaurant_API.service.CT_DatBanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CT_DatBanServiceImpl implements CT_DatBanService {
    @Autowired
    private CT_DatBanRepository ct_datBanRepository;
}
