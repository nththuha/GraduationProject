package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.NhanVienDTO;
import com.example.NTH_Restaurant_API.entity.BoPhanEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.TaiKhoanEntity;
import com.example.NTH_Restaurant_API.payload.request.SignupRequest;
import com.example.NTH_Restaurant_API.repository.BoPhanRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.TaiKhoanRepository;
import com.example.NTH_Restaurant_API.service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class NhanVienServiceImpl implements NhanVienService {
    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private TaiKhoanRepository taiKhoanRepository;

    @Autowired
    private BoPhanRepository boPhanRepository;

    @Override
    public NhanVienDTO layThongTinNhanVienTheoMaTaiKhoan(String taikhoan) {
        NhanVienEntity nhanVien = nhanVienRepository.findByTaikhoan_MaTK(taikhoan);
        return new NhanVienDTO(nhanVien);
    }

    @Override
    public List<SignupRequest> layDSNhanVienVaTaiKhoan() {
        List<NhanVienEntity> listNV = nhanVienRepository.findAll();
        List<SignupRequest> list = new ArrayList<>();
        for (NhanVienEntity nv : listNV) {
            SignupRequest temp = new SignupRequest();
            temp.setIdnv(nv.getIdNV());
            temp.setEmail(nv.getEmail());
            temp.setDiaChi(nv.getDiaChi());
            temp.setHoTen(nv.getHoTen());
            temp.setSDT(nv.getSDT());
            temp.setMaBP(nv.getMapb().getMaBP());
            temp.setTenBP(nv.getMapb().getTenBP().toString());
            TaiKhoanEntity taiKhoan = taiKhoanRepository.findByIdnv_IdNV(nv.getIdNV());
            temp.setMaTK(taiKhoan.getMaTK());
            list.add(temp);
        }
        return list;
    }

    @Override
    public String suaNhanVien(NhanVienDTO nhanVienDTO) {
        if(!nhanVienRepository.existsByIdNV(nhanVienDTO.getIdNV())) return "false";
        BoPhanEntity boPhan = boPhanRepository.getById(nhanVienDTO.getMaBP());
        NhanVienEntity nhanVien = nhanVienDTO.toEntity();
        nhanVien.setMapb(boPhan);
        try{
            nhanVienRepository.save(nhanVien);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
