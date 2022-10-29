package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CTDatMon;
import com.example.NTH_Restaurant_API.dto.CT_DatMonTruocDTO;
import com.example.NTH_Restaurant_API.entity.CT_DatMonTruocEntity;
import com.example.NTH_Restaurant_API.repository.CT_DatMonTruocRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.service.CT_DatMonTruocService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.persistence.Access;
import javax.transaction.Transactional;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class CT_DatMonTruocServiceImpl implements CT_DatMonTruocService {
    @Autowired
    private CT_DatMonTruocRepository ct_datMonTruocRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;

    @Override
    public List<CT_DatMonTruocDTO> layDSDatMonTheoPhieuDatTruoc(int idpdt) {
        try {
            List<CT_DatMonTruocEntity> listT = ct_datMonTruocRepository.findByIdpdt_IdPDT(idpdt);
            for(CT_DatMonTruocEntity i: listT){
                ct_datMonTruocRepository.deleteById(i.getIdctdmt());
            }
        }
        catch (Exception e){
            return null;
        }
        List<CTDatMon> list = ct_datMonTruocRepository.layDSChiTietDatMon(idpdt);
        List<CT_DatMonTruocEntity> listDMT = new ArrayList<>();
        CT_DatMonTruocEntity ct_datMonTruoc;
        for(CTDatMon i: list){
            ct_datMonTruoc = new CT_DatMonTruocEntity();
            ct_datMonTruoc.setIdpdt(phieuDatTruocRepository.getById(idpdt));
            ct_datMonTruoc.setMama(monAnRepository.getById(i.getMama()));
            ct_datMonTruoc.setSoluong(i.getSoluong());
            ct_datMonTruoc.setGia(i.getGia());
            listDMT.add(ct_datMonTruoc);
        }

//        CT_DatMonTruocEntity ct_datMonTruoc;
//        String maMA = "";
//        for(int i = 0; i < list.size(); i++){
//            if(i == 0){
//                ct_datMonTruoc = new CT_DatMonTruocEntity();
//                ct_datMonTruoc.setIdpdt(phieuDatTruocRepository.getById(idpdt));
//                ct_datMonTruoc.setGia(list.get(i).getGia());
//                ct_datMonTruoc.setSoluong(list.get(i).getSoluong());
//                ct_datMonTruoc.setMama(monAnRepository.getById(list.get(i).getMama()));
//                maMA = list.get(i).getMama();
//                listDMT.add(ct_datMonTruoc);
//            }
//            else{
//                if(list.get(i).getMama().equals(maMA)){
//                    listDMT.get(list.size() - 1).setSoluong(listDMT.get(list.size() - 1).getSoluong() + list.get(i).getSoluong());
//                }
//                else{
//                    ct_datMonTruoc = new CT_DatMonTruocEntity();
//                    ct_datMonTruoc.setIdpdt(phieuDatTruocRepository.getById(idpdt));
//                    ct_datMonTruoc.setGia(list.get(i).getGia());
//                    ct_datMonTruoc.setSoluong(list.get(i).getSoluong());
//                    ct_datMonTruoc.setMama(monAnRepository.getById(list.get(i).getMama()));
//                    maMA = list.get(i).getMama();
//                    listDMT.add(ct_datMonTruoc);
//                }
//            }
//        }
        try {
            ct_datMonTruocRepository.saveAll(listDMT);
        }
        catch (Exception e){
            return null;
        }
        return listDMT.stream().map(CT_DatMonTruocDTO::new).collect(Collectors.toList());
    }
}
