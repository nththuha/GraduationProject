package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.LoaiMonAnDTO;
import com.example.NTH_Restaurant_API.dto.MonAnDTO;
import com.example.NTH_Restaurant_API.entity.LoaiMonAnEntity;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.repository.LoaiMonAnRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.service.LoaiMonAnService;
import com.example.NTH_Restaurant_API.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class LoaiMonAnServiceImpl implements LoaiMonAnService {
    @Autowired
    private LoaiMonAnRepository loaiMonAnRepository;

    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    @Autowired
    private MonAnRepository monAnRepository;

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

    @Override
    public List<MonAnDTO> layDSMonAnTheoLoaiMonAn(String maLMA) {
        List<MonAnEntity> dsMA = monAnRepository.findByMalma_MaLMA(maLMA);
        List<MonAnDTO> dsMADTO = dsMA.stream().map(MonAnDTO::new).collect(Collectors.toList());

        for(int i = 0; i < dsMADTO.size(); i++) {
            if (dsMADTO.get(i).getTrangThai().equals("Đã ngừng kinh doanh")) {
                dsMADTO.remove(i);
                i--;
            }
        }
        for(int i = 0; i < dsMADTO.size(); i++){
            dsMADTO.get(i).setGia(thayDoiGiaMonService.layGiaHienTai(dsMADTO.get(i).getMaMA()));
        }
        return dsMADTO;
    }
}
