package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.TienCocDTO;
import com.example.NTH_Restaurant_API.repository.TienCocRepository;
import com.example.NTH_Restaurant_API.service.TienCocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TienCocServiceImpl implements TienCocService {
    @Autowired
    private TienCocRepository tienCocRepository;

    @Override
    public List<TienCocDTO> latDSTienCocTheoPDT(Integer idpdt) {
        return null;
    }

    @Override
    public String themTienCoc(TienCocDTO tienCocDTO) {
        return null;
    }

    @Override
    public String xoaTienCoc(Integer idTC) {
        return null;
    }
}
