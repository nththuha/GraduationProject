package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.KhachHangEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class KhachHangDTO {
    private Integer idKH;

    private String hoTen;

    private String sDT;

    private String cmnd;

    public KhachHangDTO(KhachHangEntity khachHangEntity) {
        this.idKH = khachHangEntity.getIdKH();
        this.hoTen = khachHangEntity.getHoTen();
        this.sDT = khachHangEntity.getSDT();
        this.cmnd = khachHangEntity.getCmnd();
    }

    public KhachHangEntity toEntity() {
        KhachHangEntity khachHangEntity = new KhachHangEntity();
        khachHangEntity.setIdKH(this.idKH);
        khachHangEntity.setHoTen(this.hoTen);
        khachHangEntity.setSDT(this.sDT);
        khachHangEntity.setCmnd(this.cmnd);
        return khachHangEntity;
    }
}
