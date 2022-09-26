package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class MonAnDTO {
    private String maMA;

    private String tenMA;

    private String chuThich;

    private String trangThai;

    private String hinhAnh;

    private int gia;

    private String malma;

    private String tenlma;

    public MonAnDTO(MonAnEntity monAnEntity) {
        this.maMA = monAnEntity.getMaMA();
        this.tenMA = monAnEntity.getTenMA();
        this.chuThich = monAnEntity.getChuThich();
        this.hinhAnh = monAnEntity.getHinhAnh();
        this.trangThai = monAnEntity.getTrangThai();
        this.malma = monAnEntity.getMalma().getMaLMA();
        this.tenlma = monAnEntity.getMalma().getTenLMA();
    }

    public MonAnEntity toEntity() {
        MonAnEntity monAnEntity = new MonAnEntity();
        monAnEntity.setMaMA(this.maMA);
        monAnEntity.setTenMA(this.tenMA);
        monAnEntity.setHinhAnh(this.hinhAnh);
        monAnEntity.setChuThich(this.chuThich);
        monAnEntity.setTrangThai(this.trangThai);
        return monAnEntity;
    }
}
