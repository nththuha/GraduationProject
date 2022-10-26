package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_DatBanTruocDTO;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatBanTruocEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import com.example.NTH_Restaurant_API.repository.CT_BanRepository;
import com.example.NTH_Restaurant_API.repository.CT_DatBanTruocRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.repository.ThucDonRepository;
import com.example.NTH_Restaurant_API.service.CT_DatBanTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_DatBanTruocServiceImpl implements CT_DatBanTruocService {
    @Autowired
    private CT_DatBanTruocRepository ct_datBanTruocRepository;

    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;

    @Autowired
    private ThucDonRepository thucDonRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Override
    public List<CT_DatBanTruocDTO> layDSCT_DatBanTruocTheoPDT(Integer idpdt) {
        List<CT_DatBanTruocEntity> listCTDBT = ct_datBanTruocRepository.findByIdpdt_IdPDT(idpdt);
        return listCTDBT.stream().map(CT_DatBanTruocDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themCT_DatBanTruoc(CT_DatBanTruocDTO ct_datBanTruocDTO) {
        CT_DatBanTruocEntity ct_datBanTruoc = new CT_DatBanTruocEntity();
        ThucDonEntity thucDon = thucDonRepository.getById(ct_datBanTruocDTO.getIdtd());
        PhieuDatTruocEntity pdt = phieuDatTruocRepository.getById(ct_datBanTruocDTO.getIdpdt());
        CT_BanEntity ctBan = ct_banRepository.getById(ct_datBanTruocDTO.getIdctb());
        ct_datBanTruoc.setIdtd(thucDon);
        ct_datBanTruoc.setIdpdt(pdt);
        ct_datBanTruoc.setIdctb(ctBan);
        try {
            ct_datBanTruocRepository.save(ct_datBanTruoc);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaCT_DatBanTruoc(Integer idCTDBT) {
        try {
            ct_datBanTruocRepository.deleteById(idCTDBT);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
