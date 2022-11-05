package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_PhieuMuaEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class CT_PhieuMuaDTO {
    private Integer idCTPM;
    private Integer soLuong;
    private String manl;
    private String tennl;
    private String donVi;
    private Integer idpm;

    public CT_PhieuMuaDTO(CT_PhieuMuaEntity ct_phieuMuaEntity){
        this.idCTPM = ct_phieuMuaEntity.getIdCTPM();
        this.soLuong = ct_phieuMuaEntity.getSoLuong();
        this.manl = ct_phieuMuaEntity.getManl().getMaNL();
        this.tennl = ct_phieuMuaEntity.getManl().getTenNL();
        this.donVi = ct_phieuMuaEntity.getManl().getDonVi();
        this.idpm = ct_phieuMuaEntity.getIdpm().getIdPM();
    }

    public CT_PhieuMuaEntity toEntity(){
        CT_PhieuMuaEntity ct_phieuMua = new CT_PhieuMuaEntity();
        ct_phieuMua.setIdCTPM(this.idCTPM);
        ct_phieuMua.setSoLuong(this.soLuong);
        return ct_phieuMua;
    }
}
