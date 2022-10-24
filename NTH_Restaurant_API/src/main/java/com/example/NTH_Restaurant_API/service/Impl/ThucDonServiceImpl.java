package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_ThucDonDTO;
import com.example.NTH_Restaurant_API.dto.ThucDonDTO;
import com.example.NTH_Restaurant_API.entity.CT_DatBanTruocEntity;
import com.example.NTH_Restaurant_API.entity.CT_ThucDonEntity;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import com.example.NTH_Restaurant_API.repository.CT_DatBanTruocRepository;
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
    private CT_DatBanTruocRepository ct_datBanTruocRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Override
    public List<ThucDonDTO> layDSThucDon() {
        List<ThucDonEntity> listTD = thucDonRepository.findAll();
        for(ThucDonEntity i: listTD){
            int t = 0;
            for(CT_ThucDonEntity j: i.getCtThucdonList()){
                int gia = thayDoiGiaMonService.layGiaHienTai(j.getMama().getMaMA());
                j.setGia(gia);
                ct_thucDonRepository.save(j);
                t += gia;
            }
            i.setGia(t);
            thucDonRepository.save(i);
        }
        return listTD.stream().map(ThucDonDTO::new).collect(Collectors.toList());
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
    public String xoaThucDon(Integer idTD) {
        if(!thucDonRepository.existsByIdTD(idTD)) return "false";
        List<CT_DatBanTruocEntity> listCTDBT = ct_datBanTruocRepository.findByIdtd_IdTD(idTD);
        if(listCTDBT.size() > 0) return "false";
        List<CT_ThucDonEntity> listCTT = ct_thucDonRepository.findByIdtd_IdTD(idTD);
        try {
            ct_thucDonRepository.deleteAll(listCTT);
            thucDonRepository.deleteById(idTD);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String saoChepThucDon(ThucDonDTO thucDonDTO) {

        return null;
    }
}
