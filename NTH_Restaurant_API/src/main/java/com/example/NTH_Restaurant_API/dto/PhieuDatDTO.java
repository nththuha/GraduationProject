package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhieuDatEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PhieuDatDTO {
    private Integer idPD;
    private Date ngay;
    private String mahd;
    private Integer idkh;
    private String hoTenKH;
    private Integer idnv;
    private String hoTenNV;
    private String maBan;
    private String tenBan;
    private String maPhong;
    private String tenPhong;
    private Integer idPDT;
    private Integer gia;
    private Integer giaSauThue;

    public PhieuDatDTO(PhieuDatEntity phieuDatEntity) {
        this.idPD = phieuDatEntity.getIdPD();
        this.ngay = phieuDatEntity.getNgay();
        this.idnv = phieuDatEntity.getIdnv().getIdNV();
        this.hoTenNV = phieuDatEntity.getIdnv().getHoTen();
        if(phieuDatEntity.getIdpdt() != null) this.idPDT = phieuDatEntity.getIdpdt().getIdPDT();
        if(phieuDatEntity.getIdkh() != null) this.idkh = phieuDatEntity.getIdkh().getIdKH();
        if(phieuDatEntity.getIdkh() != null) this.hoTenKH = phieuDatEntity.getIdkh().getHoTen();
    }

    public PhieuDatEntity toEntity() {
        PhieuDatEntity phieuDatEntity = new PhieuDatEntity();
        phieuDatEntity.setIdPD(this.idPD);
        phieuDatEntity.setNgay(this.ngay);
        return phieuDatEntity;
    }
}
