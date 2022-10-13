package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_MonAnDTO;
import com.example.NTH_Restaurant_API.entity.CT_MonAnEntity;
import com.example.NTH_Restaurant_API.repository.CT_MonAnRepository;
import com.example.NTH_Restaurant_API.service.CT_MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_MonAnServiceImpl implements CT_MonAnService {
    @Autowired
    private CT_MonAnRepository ct_monAnRepository;

    @Override
    public List<CT_MonAnDTO> layDSCT_MonAnTheoMonAn(String mama) {
        List<CT_MonAnEntity> listCTMA = ct_monAnRepository.findByMama_MaMA(mama);
        return listCTMA.stream().map(CT_MonAnDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themCT_MonAn(CT_MonAnDTO ct_monAnDTO) {
        if(ct_monAnRepository.existsByIdCTMA(ct_monAnDTO.getIdCTMA())) return "false";
        try{
            ct_monAnRepository.save(ct_monAnDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaCT_MonAn(Integer idCTMA) {
        try {
            ct_monAnRepository.deleteById(idCTMA);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
