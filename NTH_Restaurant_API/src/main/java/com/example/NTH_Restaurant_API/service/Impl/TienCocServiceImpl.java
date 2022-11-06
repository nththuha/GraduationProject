package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.TienCocDTO;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.entity.TienCocEntity;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.repository.TienCocRepository;
import com.example.NTH_Restaurant_API.service.TienCocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class TienCocServiceImpl implements TienCocService {
    @Autowired
    private TienCocRepository tienCocRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;

    @Override
    public List<TienCocDTO> layDSTienCocTheoPDT(Integer idpdt) {
        List<TienCocEntity> listTC = tienCocRepository.findByIdpdt_IdPDT(idpdt);
        return listTC.stream().map(TienCocDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themTienCoc(TienCocDTO tienCocDTO) {
        if(tienCocRepository.existsByIdTC(tienCocDTO.getIdTC())) return "false";
        List<TienCocEntity> listTC = tienCocRepository.findByIdpdt_IdPDT(tienCocDTO.getIdpdt());
        int tong = tienCocDTO.getTriGia();;
        for(TienCocEntity i: listTC){
            tong += i.getTriGia();
        }
        PhieuDatTruocEntity pdt = phieuDatTruocRepository.getById(tienCocDTO.getIdpdt());
        if(tong > pdt.getGiaSauThue()){
            return "money";
        }
        TienCocEntity tienCoc = tienCocDTO.toEntity();
        NhanVienEntity nv = nhanVienRepository.getById(tienCocDTO.getIdnv());
        tienCoc.setIdpdt(pdt);
        tienCoc.setIdnv(nv);
        try {
            tienCocRepository.save(tienCoc);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaTienCoc(Integer idTC) {
        if(!tienCocRepository.existsByIdTC(idTC)) return "false";
        try {
            tienCocRepository.deleteById(idTC);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
