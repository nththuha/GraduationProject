package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhieuNhapNguyenLieuEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class PhieuNhapNguyenLieuDTO {
    private Integer idPN;
    private Date ngay;
    private Integer idnv;

    public PhieuNhapNguyenLieuDTO(PhieuNhapNguyenLieuEntity pnnl){
        this.idPN = pnnl.getIdPN();
        this.ngay = pnnl.getNgay();
        this.idnv = pnnl.getIdnv().getIdNV();
    }

    public PhieuNhapNguyenLieuEntity toEntity(){
        PhieuNhapNguyenLieuEntity pnnl = new PhieuNhapNguyenLieuEntity();
        pnnl.setIdPN(this.idPN);
        pnnl.setNgay(this.ngay);
        return pnnl;
    }
}
