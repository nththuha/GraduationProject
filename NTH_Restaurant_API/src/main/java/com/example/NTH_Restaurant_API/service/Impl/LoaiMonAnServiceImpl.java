package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.LoaiMonAnDTO;
import com.example.NTH_Restaurant_API.entity.LoaiMonAnEntity;
import com.example.NTH_Restaurant_API.repository.LoaiMonAnRepository;
import com.example.NTH_Restaurant_API.service.LoaiMonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class LoaiMonAnServiceImpl implements LoaiMonAnService {
    @Autowired
    private LoaiMonAnRepository loaiMonAnRepository;

    @Override
    public List<LoaiMonAnDTO> layDSLoaiMonAn() {
        List<LoaiMonAnEntity> dsLMA = loaiMonAnRepository.findAll();
        return dsLMA.stream().map(LoaiMonAnDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO) {
        if(loaiMonAnRepository.existsByMaLMA(loaiMonAnDTO.getMaLMA())) return "false";
        try{
            loaiMonAnRepository.save(loaiMonAnDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaLoaiMonAn(LoaiMonAnDTO loaiMonAnDTO) {
        if(!loaiMonAnRepository.existsByMaLMA(loaiMonAnDTO.getMaLMA())) return "false";
        try{
            loaiMonAnRepository.save(loaiMonAnDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaLoaiMonAn(String maLMA) {
        try{
            loaiMonAnRepository.deleteById(maLMA);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
