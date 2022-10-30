package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CTDatMon;
import com.example.NTH_Restaurant_API.dto.CT_DatMonTruocDTO;
import com.example.NTH_Restaurant_API.dto.PhieuDatCocDTO;
import com.example.NTH_Restaurant_API.dto.TienCocDTO;
import com.example.NTH_Restaurant_API.entity.CT_DatMonTruocEntity;
import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import com.example.NTH_Restaurant_API.entity.TienCocEntity;
import com.example.NTH_Restaurant_API.repository.CT_DatMonTruocRepository;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.PhieuDatTruocRepository;
import com.example.NTH_Restaurant_API.repository.TienCocRepository;
import com.example.NTH_Restaurant_API.service.CT_DatMonTruocService;
import com.example.NTH_Restaurant_API.service.HoaDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

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

    @Autowired
    private TienCocRepository tienCocRepository;

    @Autowired
    private HoaDonService hoaDonService;

    @Override
    public PhieuDatCocDTO layDSDatMonTheoPhieuDatTruoc(int idpdt) {
        try {
            List<CT_DatMonTruocEntity> listT = ct_datMonTruocRepository.findByIdpdt_IdPDT(idpdt);
            for(CT_DatMonTruocEntity i: listT){
                ct_datMonTruocRepository.deleteById(i.getIdctdmt());
            }
        }
        catch (Exception e){
            return null;
        }
        PhieuDatTruocEntity pdt = phieuDatTruocRepository.getById(idpdt);
        List<CTDatMon> list = ct_datMonTruocRepository.layDSChiTietDatMon(idpdt);
        List<CT_DatMonTruocEntity> listDMT = new ArrayList<>();
        CT_DatMonTruocEntity ct_datMonTruoc;
        String maMA = "";
        int tongTien = 0;
        for(int i = 0; i < list.size(); i++){
            tongTien += list.get(i).getGia();
            if(i == 0){
                ct_datMonTruoc = new CT_DatMonTruocEntity();
                ct_datMonTruoc.setIdpdt(pdt);
                ct_datMonTruoc.setGia(list.get(i).getGia());
                ct_datMonTruoc.setSoluong(list.get(i).getSoluong());
                ct_datMonTruoc.setMama(monAnRepository.getById(list.get(i).getMama()));
                maMA = list.get(i).getMama();
                listDMT.add(ct_datMonTruoc);
            }
            else{
                if(list.get(i).getMama().equals(maMA)){
                    listDMT.get(listDMT.size() - 1).setSoluong(listDMT.get(listDMT.size() - 1).getSoluong() + list.get(i).getSoluong());
                    listDMT.get(listDMT.size() - 1).setGia(listDMT.get(listDMT.size() - 1).getGia() + list.get(i).getGia());
                }
                else{
                    ct_datMonTruoc = new CT_DatMonTruocEntity();
                    ct_datMonTruoc.setIdpdt(pdt);
                    ct_datMonTruoc.setGia(list.get(i).getGia());
                    ct_datMonTruoc.setSoluong(list.get(i).getSoluong());
                    ct_datMonTruoc.setMama(monAnRepository.getById(list.get(i).getMama()));
                    maMA = list.get(i).getMama();
                    listDMT.add(ct_datMonTruoc);
                }
            }
        }
        pdt.setGia(tongTien);
        pdt.setGiaSauThue((int) (tongTien * 1.1));

        List<TienCocEntity> listTC = tienCocRepository.findByIdpdt_IdPDT(idpdt);

        try {
            pdt = phieuDatTruocRepository.save(pdt);
            listDMT = ct_datMonTruocRepository.saveAll(listDMT);
        }
        catch (Exception e){
            return null;
        }

        PhieuDatCocDTO pdc = new PhieuDatCocDTO(pdt);
        pdc.setGiaChu(hoaDonService.chuyenSangChu(pdc.getGiaSauThue() + ""));
        pdc.setListCTDMT(listDMT.stream().map(CT_DatMonTruocDTO::new).collect(Collectors.toList()));
        pdc.setListTC(listTC.stream().map(TienCocDTO::new).collect(Collectors.toList()));
        return pdc;
    }
}
