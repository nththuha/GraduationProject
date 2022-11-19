package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_PhieuNhapEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class CT_PhieuNhapDTO {
    private Integer idCTPN;
    private Integer soLuong;
    private Integer gia;
    private String manl;
    private String tennl;
    private String donVi;
    private Integer idpn;

    public CT_PhieuNhapDTO(CT_PhieuNhapEntity ct_phieuNhap) {
        this.idCTPN = ct_phieuNhap.getIdCTPN();
        this.soLuong = ct_phieuNhap.getSoLuong();
        this.gia = ct_phieuNhap.getGia();
        this.manl = ct_phieuNhap.getManl().getMaNL();
        this.tennl = ct_phieuNhap.getManl().getTenNL();
        this.donVi = ct_phieuNhap.getManl().getDonVi();
        this.idpn = ct_phieuNhap.getIdpn().getIdPN();
    }

    public CT_PhieuNhapEntity toEntity() {
        CT_PhieuNhapEntity ct_phieuNhap = new CT_PhieuNhapEntity();
        ct_phieuNhap.setIdCTPN(this.idCTPN);
        ct_phieuNhap.setSoLuong(this.soLuong);
        ct_phieuNhap.setGia(this.gia);
        return ct_phieuNhap;
    }
}
