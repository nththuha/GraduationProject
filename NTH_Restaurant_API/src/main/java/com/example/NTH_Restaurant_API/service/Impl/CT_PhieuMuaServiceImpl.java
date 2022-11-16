package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_PhieuMuaDTO;
import com.example.NTH_Restaurant_API.entity.CT_PhieuMuaEntity;
import com.example.NTH_Restaurant_API.repository.CT_PhieuMuaRepository;
import com.example.NTH_Restaurant_API.service.CT_PhieuMuaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_PhieuMuaServiceImpl implements CT_PhieuMuaService {
    @Autowired
    private CT_PhieuMuaRepository ct_phieuMuaRepository;

    @Override
    public List<CT_PhieuMuaDTO> layDSCT_PhieuMuaTheoPhieuMua(Integer idPM) {
        List<CT_PhieuMuaEntity> listCTPM = ct_phieuMuaRepository.findByIdpm_IdPM(idPM);
        return listCTPM.stream().map(CT_PhieuMuaDTO::new).collect(Collectors.toList());
    }
}
