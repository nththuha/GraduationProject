package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.*;
import com.example.NTH_Restaurant_API.entity.CT_PhieuMuaEntity;
import com.example.NTH_Restaurant_API.entity.NguyenLieuEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.PhieuMuaNguyenLieuEntity;
import com.example.NTH_Restaurant_API.repository.CT_PhieuMuaRepository;
import com.example.NTH_Restaurant_API.repository.NguyenLieuRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.PhieuMuaNguyenLieuRepository;
import com.example.NTH_Restaurant_API.service.PhieuMuaNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class PhieuMuaNguyenLieuServiceImpl implements PhieuMuaNguyenLieuService {
    @Autowired
    private PhieuMuaNguyenLieuRepository phieuMuaNguyenLieuRepository;

    @Autowired
    private CT_PhieuMuaRepository ct_phieuMuaRepository;

    @Autowired
    private NguyenLieuRepository nguyenLieuRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public List<CT_PhieuMuaDTO> layDSNguyenLieuCanMua(PhieuMuaNguyenLieuDTO phieuMuaNguyenLieuDTO) {
        if(phieuMuaNguyenLieuRepository.existsByNgay(phieuMuaNguyenLieuDTO.getNgay())){
            try{
                List<CT_PhieuMuaEntity> listCTPM = ct_phieuMuaRepository.findByIdpm_Ngay(phieuMuaNguyenLieuDTO.getNgay());
                ct_phieuMuaRepository.deleteAll(listCTPM);
                PhieuMuaNguyenLieuEntity pm = phieuMuaNguyenLieuRepository.findByNgay(phieuMuaNguyenLieuDTO.getNgay());
                phieuMuaNguyenLieuRepository.delete(pm);
            }
            catch (Exception e){
                return null;
            }
        }

        PhieuMuaNguyenLieuEntity pm = phieuMuaNguyenLieuDTO.toEntity();
        NhanVienEntity nv = nhanVienRepository.getById(phieuMuaNguyenLieuDTO.getIdnv());
        pm.setIdnv(nv);
        try{
            pm = phieuMuaNguyenLieuRepository.save(pm);
        }
        catch (Exception e){
            return null;
        }
        List<NguyenLieuCanMua> listNL = phieuMuaNguyenLieuRepository.layDSNguyenLieuCanMuaTheoNgay(phieuMuaNguyenLieuDTO.getNgay());
        List<CT_PhieuMuaEntity> listCTPM = new ArrayList<>();
        for(NguyenLieuCanMua i: listNL){
            NguyenLieuEntity nl = nguyenLieuRepository.getById(i.getManl());
            int soLuong = i.getSoluong() + (nl.getSlToiThieu() - nl.getSlTon());
            CT_PhieuMuaEntity ct = new CT_PhieuMuaEntity();
            ct.setSoLuong(soLuong);
            ct.setManl(nl);
            ct.setIdpm(pm);
            listCTPM.add(ct);
        }
        try {
            listCTPM = ct_phieuMuaRepository.saveAll(listCTPM);
        }
        catch (Exception e){
            return null;
        }
        return listCTPM.stream().map(CT_PhieuMuaDTO::new).collect(Collectors.toList());
    }

    @Override
    public List<PhieuMuaNguyenLieuDTO> layDSPhieuMuaNguyenLieu() {
        List<PhieuMuaNguyenLieuEntity> listPM = phieuMuaNguyenLieuRepository.layDSPhieuMuaNguyenLieu();
        return listPM.stream().map(PhieuMuaNguyenLieuDTO::new).collect(Collectors.toList());
    }
}
