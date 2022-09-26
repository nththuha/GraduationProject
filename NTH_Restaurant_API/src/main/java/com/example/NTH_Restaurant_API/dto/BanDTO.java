package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.BanEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class BanDTO {
    private String maBan;

    private String tenBan;

    private String trangThai;

    private Integer soGhe;

    public BanDTO(BanEntity banEntity) {
        this.maBan = banEntity.getMaBan();
        this.tenBan = banEntity.getTenBan();
        this.soGhe = banEntity.getSoGhe();
    }

    public BanEntity toEntity() {
        BanEntity banEntity = new BanEntity();
        banEntity.setSoGhe(this.soGhe);
        banEntity.setMaBan(this.maBan);
        banEntity.setTenBan(this.tenBan);
        return banEntity;
    }
}
