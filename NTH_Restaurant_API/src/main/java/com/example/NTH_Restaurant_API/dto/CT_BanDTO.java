package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_BanDTO {
    private Integer idCTB;

    private Integer soGhe;

    private String trangThai;

    private String maban;

    private String tenban;

    private String maphong;

    private String tenphong;

    public CT_BanDTO(CT_BanEntity ct_banEntity) {
        this.idCTB = ct_banEntity.getIdCTB();
        this.soGhe = ct_banEntity.getSoGhe();
        this.trangThai = ct_banEntity.getTrangThai();
        this.maban = ct_banEntity.getMaban().getMaBan();
        this.tenban = ct_banEntity.getMaban().getTenBan();
        this.maphong = ct_banEntity.getMaphong().getMaPhong();
        this.tenphong = ct_banEntity.getMaphong().getTenPhong();
    }

    public CT_BanEntity toEntity() {
        CT_BanEntity ct_banEntity = new CT_BanEntity();
        ct_banEntity.setIdCTB(this.idCTB);
        ct_banEntity.setTrangThai(this.trangThai);
        ct_banEntity.setSoGhe(this.soGhe);
        return ct_banEntity;
    }
}
