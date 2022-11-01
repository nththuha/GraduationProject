package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.CT_PhieuMuaDTO;
import com.example.NTH_Restaurant_API.dto.NguyenLieuCanMua;
import com.example.NTH_Restaurant_API.dto.NguyenLieuDTO;
import com.example.NTH_Restaurant_API.dto.PhongNgay;
import com.example.NTH_Restaurant_API.entity.NguyenLieuEntity;
import com.example.NTH_Restaurant_API.repository.NguyenLieuRepository;
import com.example.NTH_Restaurant_API.repository.PhieuMuaNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.PhieuMuaNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class PhieuMuaNguyenLieuServiceImpl implements PhieuMuaNguyenLieuService {
    @Autowired
    private PhieuMuaNguyenLieuRepository phieuMuaNguyenLieuRepository;

    @Autowired
    private NguyenLieuRepository nguyenLieuRepository;

    @Override
    public List<CT_PhieuMuaDTO> layDSNguyenLieuCanMua(PhongNgay ngay) {
        List<NguyenLieuCanMua> listNL = phieuMuaNguyenLieuRepository.layDSNguyenLieuCanMuaTheoNgay(ngay.getNgay());
        List<CT_PhieuMuaDTO> list = new ArrayList<>();
        for(NguyenLieuCanMua i: listNL){
            NguyenLieuEntity nl = nguyenLieuRepository.getById(i.getManl());
            CT_PhieuMuaDTO ct = new CT_PhieuMuaDTO();
            int soLuong = i.getSoluong() + (nl.getSlToiThieu() - nl.getSlTon());
            ct.setManl(nl.getMaNL());
            ct.setTennl(nl.getTenNL());
            ct.setSoLuong(soLuong);
            list.add(ct);
        }
        return list;
    }
}
