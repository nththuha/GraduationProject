package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.HuyPhieuDatTruocEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class HuyPhieuDatTruocDTO {
    private Integer idHPDT;
    private Date ngay;
    private Integer soTien;
    private Integer idnv;
    private Integer idpdt;

    public HuyPhieuDatTruocDTO(HuyPhieuDatTruocEntity hpdt){
        this.idHPDT = hpdt.getIdHPDT();
        this.ngay = hpdt.getNgay();
        this.soTien = hpdt.getSoTien();
        this.idnv = hpdt.getIdnv().getIdNV();
        this.idpdt = hpdt.getIdpdt().getIdPDT();
    }

    public HuyPhieuDatTruocEntity toEntity(){
        HuyPhieuDatTruocEntity hpdt = new HuyPhieuDatTruocEntity();
        hpdt.setIdHPDT(this.idHPDT);
        hpdt.setNgay(this.ngay);
        hpdt.setSoTien(this.soTien);
        return hpdt;
    }
}
