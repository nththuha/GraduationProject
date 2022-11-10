package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_ThucDonDTO;
import com.example.NTH_Restaurant_API.entity.CT_DatBanTruocEntity;
import com.example.NTH_Restaurant_API.entity.CT_ThucDonEntity;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import com.example.NTH_Restaurant_API.repository.CT_DatBanTruocRepository;
import com.example.NTH_Restaurant_API.repository.CT_ThucDonRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.ThucDonRepository;
import com.example.NTH_Restaurant_API.service.CT_ThucDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_ThucDonServiceImpl implements CT_ThucDonService {
    @Autowired
    private CT_ThucDonRepository ct_thucDonRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private ThucDonRepository thucDonRepository;

    @Autowired
    private CT_DatBanTruocRepository ct_datBanTruocRepository;

    @Override
    public List<CT_ThucDonDTO> layDSCT_ThucDonTheoThucDon(Integer idtd) {
        List<CT_ThucDonEntity> listCTTD = ct_thucDonRepository.findByIdtd_IdTD(idtd);
        return listCTTD.stream().map(CT_ThucDonDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themCT_ThucDon(CT_ThucDonDTO ct_thucDonDTO) {
        CT_ThucDonEntity ct_thucDon = ct_thucDonDTO.toEntity();
        MonAnEntity monAn = monAnRepository.getById(ct_thucDonDTO.getMama());
        ThucDonEntity thucDon = thucDonRepository.getById(ct_thucDonDTO.getIdtd());
        ct_thucDon.setMama(monAn);
        ct_thucDon.setIdtd(thucDon);
        thucDon.setGia(thucDon.getGia() + ct_thucDon.getGia());
        try {
            thucDonRepository.save(thucDon);
            ct_thucDonRepository.save(ct_thucDon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaCT_ThucDon(Integer idCTTD) {
        try {
            ct_thucDonRepository.deleteById(idCTTD);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public List<CT_ThucDonDTO> layDSCT_ThucDonTheoCT_DatBanTruoc(Integer idctdbt) {
        if(!ct_datBanTruocRepository.existsByIdCTDBT(idctdbt)) return null;
        CT_DatBanTruocEntity ct_datBanTruoc = ct_datBanTruocRepository.getById(idctdbt);
        List<CT_ThucDonEntity> listCTTD = ct_thucDonRepository.findByIdtd_IdTD(ct_datBanTruoc.getIdtd().getIdTD());
        return listCTTD.stream().map(CT_ThucDonDTO::new).collect(Collectors.toList());
    }
}
