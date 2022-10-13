package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.MonAnDTO;
import com.example.NTH_Restaurant_API.entity.LoaiMonAnEntity;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.ThayDoiGiaMonEntity;
import com.example.NTH_Restaurant_API.repository.LoaiMonAnRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.ThayDoiGiaMonRepository;
import com.example.NTH_Restaurant_API.service.MonAnService;
import com.example.NTH_Restaurant_API.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class MonAnServiceImpl implements MonAnService {
    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    @Autowired
    private ThayDoiGiaMonRepository thayDoiGiaMonRepository;

    @Autowired
    private LoaiMonAnRepository loaiMonAnRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired

    @Override
    public List<MonAnDTO> layDSMonAn() {
        List<MonAnEntity> dsMA = monAnRepository.findAll();
        List<MonAnDTO> dsMADTO = dsMA.stream().map(MonAnDTO::new).collect(Collectors.toList());
        for(int i = 0; i < dsMADTO.size(); i++){
            dsMADTO.get(i).setGia(thayDoiGiaMonService.layGiaHienTai(dsMADTO.get(i).getMaMA()));
        }
        return dsMADTO;
    }

    @Override
    public String themMonAn(MonAnDTO monAnDTO) {
        if(monAnRepository.existsByMaMA(monAnDTO.getMaMA())) return "false";
        LoaiMonAnEntity loaiMonAnEntity = loaiMonAnRepository.getById(monAnDTO.getMalma());
        MonAnEntity monAnTemp = monAnDTO.toEntity();
        monAnTemp.setMalma(loaiMonAnEntity);
        try{
            monAnRepository.save(monAnTemp);
            ThayDoiGiaMonEntity thayDoiGiaMonEntity = new ThayDoiGiaMonEntity(-1, monAnDTO.getGia(), new Date(), monAnRepository.getById(monAnDTO.getMaMA()), nhanVienRepository.getById(monAnDTO.getIdNV()));
            thayDoiGiaMonRepository.save(thayDoiGiaMonEntity);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaMonAn(MonAnDTO monAnDTO) {
        if(!monAnRepository.existsByMaMA(monAnDTO.getMaMA())) return "false";
        LoaiMonAnEntity loaiMonAnEntity = loaiMonAnRepository.getById(monAnDTO.getMalma());
        MonAnEntity monAnEntity = monAnDTO.toEntity();
        monAnEntity.setMalma(loaiMonAnEntity);
        try {
            monAnRepository.save(monAnEntity);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaMonAn(String maMA) {
        MonAnEntity monAn = monAnRepository.getById(maMA);
        monAn.setTrangThai("Đã ngừng kinh doanh");
        try{
            monAnRepository.save(monAn);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
