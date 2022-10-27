package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class PhieuDatTruocDTO {
    private Integer idPDT;
    private Date ngayTao;
    private Date ngayDat;
    private Integer idkh;
    private String hoTenKH;
    private String sdt;
    private Integer idnv;
    private String hoTenNV;

    public PhieuDatTruocDTO(PhieuDatTruocEntity phieuDatTruocEntity){
        this.idPDT = phieuDatTruocEntity.getIdPDT();
        this.ngayTao = phieuDatTruocEntity.getNgayTao();
        this.ngayDat = phieuDatTruocEntity.getNgayDat();
        this.idnv = phieuDatTruocEntity.getIdnv().getIdNV();
        this.hoTenNV = phieuDatTruocEntity.getIdnv().getHoTen();
        this.idkh = phieuDatTruocEntity.getIdkh().getIdKH();
        this.hoTenKH = phieuDatTruocEntity.getIdkh().getHoTen();
        this.sdt = phieuDatTruocEntity.getIdkh().getSDT();
    }

    public PhieuDatTruocEntity toEntity(){
        PhieuDatTruocEntity pdt = new PhieuDatTruocEntity();
        pdt.setIdPDT(this.idPDT);
        pdt.setNgayDat(this.ngayDat);
        pdt.setNgayTao(this.ngayTao);
        return pdt;
    }
}
