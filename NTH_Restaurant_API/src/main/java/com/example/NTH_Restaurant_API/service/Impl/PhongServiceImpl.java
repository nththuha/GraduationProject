package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhongDTO;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.PhongEntity;
import com.example.NTH_Restaurant_API.repository.CT_BanRepository;
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

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<PhongDTO> layDSPhong() {
        List<PhongEntity> dsPhong = phongRepository.findAll();
        List<PhongDTO> ds = dsPhong.stream().map(PhongDTO::new).collect(Collectors.toList());
        String trangThai = "";
        for(int i = 0; i < ds.size(); i++){
            trangThai = "Hết chỗ";
            List<CT_BanEntity> dsCT_Ban = ct_banRepository.findByMaphong_MaPhong(ds.get(i).getMaPhong());
            for (int j = 0; j < dsCT_Ban.size(); j++) {
                if (dsCT_Ban.get(j).getTrangThai().equals("Còn chỗ")) {
                    trangThai = "Còn chỗ";
                    break;
                }
            }
            ds.get(i).setTrangThai(trangThai);
        }
        return ds;
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
