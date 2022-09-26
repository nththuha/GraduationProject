package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.BoPhanDTO;
import com.example.NTH_Restaurant_API.entity.BoPhanEntity;
import com.example.NTH_Restaurant_API.repository.BoPhanRepository;
import com.example.NTH_Restaurant_API.service.BoPhanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class BoPhanServiceImpl implements BoPhanService {
    @Autowired
    private BoPhanRepository boPhanRepository;

    @Override
    public List<BoPhanDTO> layDSBoPhan() {
        List<BoPhanEntity> dsBoPhan = boPhanRepository.findAll();
        return dsBoPhan.stream().map(BoPhanDTO::new).collect(Collectors.toList());
    }
}
