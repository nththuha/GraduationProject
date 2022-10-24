package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_ThucDonDTO;
import com.example.NTH_Restaurant_API.dto.ThucDonDTO;
import com.example.NTH_Restaurant_API.entity.CT_ThucDonEntity;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import com.example.NTH_Restaurant_API.repository.CT_ThucDonRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.ThucDonRepository;
import com.example.NTH_Restaurant_API.service.ThayDoiGiaMonService;
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

    @Autowired
    private ThayDoiGiaMonService thayDoiGiaMonService;

    @Autowired
    private MonAnRepository monAnRepository;

    @Override
    public List<ThucDonDTO> layDSThucDon() {
        List<ThucDonEntity> listTD = thucDonRepository.findAll();
        List<ThucDonDTO> list = listTD.stream().map(ThucDonDTO::new).collect(Collectors.toList());
        for(ThucDonDTO i: list){
            int t = 0;
            for(CT_ThucDonDTO j: i.getListCT_ThucDon()){
                int gia = thayDoiGiaMonService.layGiaHienTai(j.getMama());
                j.setGia(gia);
                t += gia;
            }
            i.setGia(t);
        }
        return list;
    }

    @Override
    public String themThucDon(ThucDonDTO thucDonDTO) {
        ThucDonEntity thucDon = thucDonDTO.toEntity();
        List<CT_ThucDonDTO> listCTTD = thucDonDTO.getListCT_ThucDon();
        try{
            ThucDonEntity td = thucDonRepository.save(thucDon);
            for(CT_ThucDonDTO i: listCTTD){
                CT_ThucDonEntity temp = i.toEntity();
                temp.setIdCTTD(null);
                MonAnEntity monAn = monAnRepository.getById(i.getMama());
                temp.setMama(monAn);
                temp.setIdtd(td);
                ct_thucDonRepository.save(temp);
            }
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaThucDon() {
        return null;
    }

    @Override
    public String xoaThucDon() {
        return null;
    }
}
