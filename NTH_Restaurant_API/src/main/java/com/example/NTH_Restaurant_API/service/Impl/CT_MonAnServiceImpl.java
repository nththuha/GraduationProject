package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_MonAnDTO;
import com.example.NTH_Restaurant_API.entity.CT_MonAnEntity;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.NguyenLieuEntity;
import com.example.NTH_Restaurant_API.repository.CT_MonAnRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.NguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.CT_MonAnService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_MonAnServiceImpl implements CT_MonAnService {
    @Autowired
    private CT_MonAnRepository ct_monAnRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private NguyenLieuRepository nguyenLieuRepository;

    @Override
    public List<CT_MonAnDTO> layDSCT_MonAnTheoMonAn(String mama) {
        List<CT_MonAnEntity> listCTMA = ct_monAnRepository.findByMama_MaMA(mama);
        return listCTMA.stream().map(CT_MonAnDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themCT_MonAn(CT_MonAnDTO ct_monAnDTO) {
        if(ct_monAnRepository.existsByIdCTMA(ct_monAnDTO.getIdCTMA())) return "false";
        MonAnEntity monAn = monAnRepository.getById(ct_monAnDTO.getMama());
        NguyenLieuEntity nguyenLieu = nguyenLieuRepository.getById(ct_monAnDTO.getManl());
        CT_MonAnEntity ctMonAn = ct_monAnDTO.toEntity();
        ctMonAn.setIdCTMA(null);
        ctMonAn.setMama(monAn);
        ctMonAn.setManl(nguyenLieu);
        try{
            ct_monAnRepository.save(ctMonAn);
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
