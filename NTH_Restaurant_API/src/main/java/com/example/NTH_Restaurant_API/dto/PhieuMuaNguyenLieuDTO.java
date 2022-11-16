package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhieuMuaNguyenLieuEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class PhieuMuaNguyenLieuDTO {
    private Integer idPM;
    private Date ngay;
    private Integer idnv;
    private String hoTenNV;

    public PhieuMuaNguyenLieuDTO(PhieuMuaNguyenLieuEntity phieuMuaNguyenLieuEntity){
        this.idPM = phieuMuaNguyenLieuEntity.getIdPM();
        this.ngay = phieuMuaNguyenLieuEntity.getNgay();
        this.idnv = phieuMuaNguyenLieuEntity.getIdnv().getIdNV();
        this.hoTenNV = phieuMuaNguyenLieuEntity.getIdnv().getHoTen();
    }

    public PhieuMuaNguyenLieuEntity toEntity(){
        PhieuMuaNguyenLieuEntity pm = new PhieuMuaNguyenLieuEntity();
        pm.setIdPM(this.idPM);
        pm.setNgay(this.ngay);
        return pm;
    }
}
