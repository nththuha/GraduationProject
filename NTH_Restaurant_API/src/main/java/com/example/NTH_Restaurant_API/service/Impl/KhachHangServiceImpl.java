package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.KhachHangDTO;
import com.example.NTH_Restaurant_API.entity.KhachHangEntity;
import com.example.NTH_Restaurant_API.repository.KhachHangRepository;
import com.example.NTH_Restaurant_API.service.KhachHangService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
public class KhachHangServiceImpl implements KhachHangService {
    @Autowired
    private KhachHangRepository khachHangRepository;

    @Override
    public List<KhachHangDTO> layDSKhachHang() {
        List<KhachHangEntity> dsKH = khachHangRepository.findAll();
        return dsKH.stream().map(KhachHangDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themKhachHang(KhachHangDTO khachHangDTO) {
        try {
            KhachHangEntity kh = khachHangRepository.save(khachHangDTO.toEntity());
            return kh.getIdKH() + "";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String suaKhachHang(KhachHangDTO khachHangDTO) {
        if(!khachHangRepository.existsByIdKH(khachHangDTO.getIdKH())) return "false";
        try {
            khachHangRepository.save(khachHangDTO.toEntity());
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaKhachHang(Integer idKH) {
        try {
            khachHangRepository.deleteById(idKH);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
