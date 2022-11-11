package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.HoaDonEntity;
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
public class HoaDonDTO {
    private String maHD;
    private Date ngay;
    private String masothue;
    private String hotenkh;
    private List<PhieuDatDTO> phieudatList;
    private Integer idnv;

    public HoaDonDTO(HoaDonEntity hoaDonEntity) {
        this.maHD = hoaDonEntity.getMaHD();
        this.ngay = hoaDonEntity.getNgay();
        if (hoaDonEntity.getMasothue() != null) this.masothue = hoaDonEntity.getMasothue();
        if (hoaDonEntity.getHotenkh() != null) this.hotenkh = hoaDonEntity.getHotenkh();
        if (hoaDonEntity.getPhieudatList() != null)
            this.phieudatList = hoaDonEntity.getPhieudatList().stream().map(PhieuDatDTO::new).collect(Collectors.toList());
        this.idnv = hoaDonEntity.getIdnv().getIdNV();
    }

    public HoaDonEntity toEntity() {
        HoaDonEntity hoaDonEntity = new HoaDonEntity();
        hoaDonEntity.setMaHD(this.maHD);
        hoaDonEntity.setNgay(this.ngay);
        if (this.masothue != null) hoaDonEntity.setMasothue(this.masothue);
        if (this.hotenkh != null) hoaDonEntity.setHotenkh(this.hotenkh);
        return hoaDonEntity;
    }
}
