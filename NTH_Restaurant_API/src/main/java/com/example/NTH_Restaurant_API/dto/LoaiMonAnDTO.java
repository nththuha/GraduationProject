package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.LoaiMonAnEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class LoaiMonAnDTO {
    private String maLMA;

    private String tenLMA;

    private String hinhAnh;

    public LoaiMonAnDTO(LoaiMonAnEntity loaiMonAnEntity) {
        this.maLMA = loaiMonAnEntity.getMaLMA();
        this.tenLMA = loaiMonAnEntity.getTenLMA();
        this.hinhAnh = loaiMonAnEntity.getHinhAnh();
    }

    public LoaiMonAnEntity toEntity() {
        LoaiMonAnEntity loaiMonAnEntity = new LoaiMonAnEntity();
        loaiMonAnEntity.setMaLMA(this.maLMA);
        loaiMonAnEntity.setTenLMA(this.tenLMA);
        loaiMonAnEntity.setHinhAnh(this.hinhAnh);
        return loaiMonAnEntity;
    }
}
