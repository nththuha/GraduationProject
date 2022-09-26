package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.BanDTO;
import com.example.NTH_Restaurant_API.entity.BanEntity;
import com.example.NTH_Restaurant_API.repository.BanRepository;
import com.example.NTH_Restaurant_API.service.BanService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class BanServiceImpl implements BanService {
    @Autowired
    private BanRepository banRepository;

    @Override
    public List<BanDTO> layDSBan() {
        List<BanEntity> dsBan = banRepository.findAll();
        return dsBan.stream().map(BanDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themBan(BanDTO banDTO) {
        if(banRepository.existsByMaBan(banDTO.getMaBan())) return "false";
        try{
            banRepository.save(banDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaBan(BanDTO banDTO) {
        if(!banRepository.existsByMaBan(banDTO.getMaBan())) return "false";
        try{
            banRepository.save(banDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaBan(String maBan) {
        try{
            banRepository.deleteById(maBan);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
