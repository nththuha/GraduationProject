package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;
import com.example.NTH_Restaurant_API.entity.NguyenLieuEntity;
import com.example.NTH_Restaurant_API.repository.NguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.NguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class NguyenLieuServiceImpl implements NguyenLieuService {
    @Autowired
    private NguyenLieuRepository nguyenLieuRepository;

    @Override
    public List<NguyenLieuDTO> layDSNguyenLieu() {
        List<NguyenLieuEntity> dsNL = nguyenLieuRepository.findAll();
        return dsNL.stream().map(NguyenLieuDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themNguyenLieu(NguyenLieuDTO nguyenLieuDTO) {
        if(nguyenLieuRepository.existsByMaNL(nguyenLieuDTO.getMaNL())) return "false";
        try{
            nguyenLieuRepository.save(nguyenLieuDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaNguyenLieu(NguyenLieuDTO nguyenLieuDTO) {
        if(!nguyenLieuRepository.existsByMaNL(nguyenLieuDTO.getMaNL())) return "false";
        try{
            nguyenLieuRepository.save(nguyenLieuDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaNguyenLieu(String maNL) {
        try {
            nguyenLieuRepository.deleteById(maNL);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
