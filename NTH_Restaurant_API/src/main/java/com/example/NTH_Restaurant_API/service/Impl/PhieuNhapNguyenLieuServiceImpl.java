package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhieuNhapNguyenLieuDTO;
import com.example.NTH_Restaurant_API.entity.*;
import com.example.NTH_Restaurant_API.repository.*;
import com.example.NTH_Restaurant_API.service.PhieuNhapNguyenLieuService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class PhieuNhapNguyenLieuServiceImpl implements PhieuNhapNguyenLieuService {
    @Autowired
    private PhieuNhapNguyenLieuRepository phieuNhapNguyenLieuRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private PhieuMuaNguyenLieuRepository phieuMuaNguyenLieuRepository;

    @Autowired
    private CT_PhieuMuaRepository ct_phieuMuaRepository;

    @Autowired
    private CT_PhieuNhapRepository ct_phieuNhapRepository;

    @Override
    public PhieuNhapNguyenLieuDTO themPhieuNhapNguyenLieu(PhieuNhapNguyenLieuDTO phieuNhapNguyenLieuDTO) {
        if(phieuNhapNguyenLieuRepository.existsByIdPN(phieuNhapNguyenLieuDTO.getIdPN())) return null;
        NhanVienEntity nv = nhanVienRepository.getById(phieuNhapNguyenLieuDTO.getIdnv());
        PhieuNhapNguyenLieuEntity pn = phieuNhapNguyenLieuDTO.toEntity();
        pn.setIdnv(nv);
        try {
            pn = phieuNhapNguyenLieuRepository.save(pn);
            return new PhieuNhapNguyenLieuDTO(pn);
        }
        catch (Exception e){
            return null;
        }
    }

    @Override
    public String chuyenPhieuMuaThanhPhieuNhap(Integer idPM) {
        if(!phieuMuaNguyenLieuRepository.existsByIdPM(idPM)) return "false";

        PhieuMuaNguyenLieuEntity phieuMua = phieuMuaNguyenLieuRepository.getById(idPM);
        PhieuNhapNguyenLieuEntity phieuNhap = new PhieuNhapNguyenLieuEntity();
        phieuNhap.setNgay(phieuMua.getNgay());
        phieuNhap.setIdnv(phieuMua.getIdnv());
        phieuNhap.setIdpm(phieuMua);

        List<CT_PhieuMuaEntity> listCTPM = ct_phieuMuaRepository.findByIdpm_IdPM(idPM);

        try {
            phieuNhap = phieuNhapNguyenLieuRepository.save(phieuNhap);

            for (CT_PhieuMuaEntity i: listCTPM){
                CT_PhieuNhapEntity ct_phieuNhap = new CT_PhieuNhapEntity();
                ct_phieuNhap.setSoLuong(i.getSoLuong());
                ct_phieuNhap.setManl(i.getManl());
                ct_phieuNhap.setGia(0);
                ct_phieuNhap.setIdpn(phieuNhap);
                ct_phieuNhapRepository.save(ct_phieuNhap);
            }
            return phieuNhap.getIdPN().toString();
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public PhieuNhapNguyenLieuDTO layThongTinPhieuNhap(Integer idPN) {
        if(!phieuNhapNguyenLieuRepository.existsByIdPN(idPN)) return null;
        PhieuNhapNguyenLieuEntity phieuNhap = phieuNhapNguyenLieuRepository.getById(idPN);
        PhieuNhapNguyenLieuDTO pn = new PhieuNhapNguyenLieuDTO(phieuNhap);
        return pn;
    }
}
