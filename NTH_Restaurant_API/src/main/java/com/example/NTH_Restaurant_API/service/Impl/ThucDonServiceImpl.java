package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.ThucDonDTO;
import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import com.example.NTH_Restaurant_API.repository.CT_ThucDonRepository;
import com.example.NTH_Restaurant_API.repository.ThucDonRepository;
import com.example.NTH_Restaurant_API.service.ThucDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class ThucDonServiceImpl implements ThucDonService {
    @Autowired
    private ThucDonRepository thucDonRepository;

    @Autowired
    private CT_ThucDonRepository ct_thucDonRepository;

    @Override
    public List<ThucDonDTO> layDSThucDon() {
        List<ThucDonEntity> listTD = thucDonRepository.findAll();
        return listTD.stream().map(ThucDonDTO::new).collect(Collectors.toList());
    }
}
