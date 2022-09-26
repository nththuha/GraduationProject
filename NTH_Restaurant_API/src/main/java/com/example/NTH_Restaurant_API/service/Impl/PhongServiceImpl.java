package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhongDTO;
import com.example.NTH_Restaurant_API.entity.PhongEntity;
import com.example.NTH_Restaurant_API.repository.PhongRepository;
import com.example.NTH_Restaurant_API.service.PhongService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class PhongServiceImpl implements PhongService {
    @Autowired
    private PhongRepository phongRepository;

    @Override
    public List<PhongDTO> layDSPhong() {
        List<PhongEntity> dsPhong = phongRepository.findAll();
        return dsPhong.stream().map(PhongDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themPhong(PhongDTO phongDTO) {
        if(phongRepository.existsByMaPhong(phongDTO.getMaPhong())) return "false";
        try{
            phongRepository.save(phongDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaPhong(PhongDTO phongDTO) {
        if(!phongRepository.existsByMaPhong(phongDTO.getMaPhong())) return "false";
        try{
            phongRepository.save(phongDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaPhong(String maPhong) {
        try {
            phongRepository.deleteById(maPhong);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
