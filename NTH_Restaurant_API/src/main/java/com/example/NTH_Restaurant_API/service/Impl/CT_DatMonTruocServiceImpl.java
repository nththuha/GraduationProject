package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_DatMonTruocDTO;
import com.example.NTH_Restaurant_API.entity.CT_DatMonTruocEntity;
import com.example.NTH_Restaurant_API.repository.CT_DatMonTruocRepository;
import com.example.NTH_Restaurant_API.service.CT_DatMonTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.persistence.Access;
import javax.transaction.Transactional;
import java.util.List;

@Service
public class CT_DatMonTruocServiceImpl implements CT_DatMonTruocService {
    @Autowired
    private CT_DatMonTruocRepository ct_datMonTruocRepository;

    @Override
    @Transactional
    public List<CT_DatMonTruocDTO> layDSDatMonTheoPhieuDatTruoc(Integer idpdt) {
        try {
            ct_datMonTruocRepository.deleteByIdpdt_IdPDT(idpdt);
        }
        catch (Exception e){
            return null;
        }
        return null;
    }
}
