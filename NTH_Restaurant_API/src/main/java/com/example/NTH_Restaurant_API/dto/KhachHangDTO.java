package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.KhachHangEntity;
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
public class KhachHangDTO {
    private Integer idKH;

    private String hoTen;

    private String sDT;

    public KhachHangDTO(KhachHangEntity khachHangEntity) {
        this.idKH = khachHangEntity.getIdKH();
        this.hoTen = khachHangEntity.getHoTen();
        this.sDT = khachHangEntity.getSDT();
    }

    public KhachHangEntity toEntity() {
        KhachHangEntity khachHangEntity = new KhachHangEntity();
        khachHangEntity.setIdKH(this.idKH);
        khachHangEntity.setHoTen(this.hoTen);
        khachHangEntity.setSDT(this.sDT);
        return khachHangEntity;
    }
}
