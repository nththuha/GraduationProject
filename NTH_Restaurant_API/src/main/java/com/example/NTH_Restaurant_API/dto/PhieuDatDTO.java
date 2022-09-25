package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhieuDatEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

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

    public PhieuDatDTO(PhieuDatEntity phieuDatEntity) {
        this.idPD = phieuDatEntity.getIdPD();
        this.ngay = phieuDatEntity.getNgay();
        if (phieuDatEntity.getMahd() != null) this.mahd = phieuDatEntity.getMahd().getMaHD();
        this.idnv = phieuDatEntity.getIdnv().getIdNV();
        this.hoTenNV = phieuDatEntity.getIdnv().getHoTen();
        if (phieuDatEntity.getIdkh() != null) this.idkh = phieuDatEntity.getIdkh().getIdKH();
        if (phieuDatEntity.getIdkh() != null) this.hoTenKH = phieuDatEntity.getIdkh().getHoTen();
    }

    public PhieuDatEntity toEntity() {
        PhieuDatEntity phieuDatEntity = new PhieuDatEntity();
        phieuDatEntity.setIdPD(this.idPD);
        phieuDatEntity.setNgay(this.ngay);
        return phieuDatEntity;
    }
}
