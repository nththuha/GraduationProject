package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhongEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PhongDTO {
    private String maPhong;
    private String tenPhong;

    private String trangThai;

    public PhongDTO(PhongEntity phongEntity) {
        this.maPhong = phongEntity.getMaPhong();
        this.tenPhong = phongEntity.getTenPhong();
    }

    public PhongEntity toEntity() {
        PhongEntity phongEntity = new PhongEntity();
        phongEntity.setMaPhong(this.maPhong);
        phongEntity.setTenPhong(this.tenPhong);
        return phongEntity;
    }
}
