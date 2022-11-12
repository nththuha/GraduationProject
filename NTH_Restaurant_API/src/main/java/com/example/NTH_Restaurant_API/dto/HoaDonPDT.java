package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.HoaDonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class HoaDonPDT {
    private String maHD;
    private Date ngay;
    private int trigia;
    private int giaSauThue;
    private String masothue;
    private String hotenkh;
    private Integer idnv;
    private String hoTenNV;

    private List<CT_DatMonTruocDTO> ctDatMonTruocList;

    private List<TienCocDTO> tienCocList;

    private Integer tongCoc;

    private Integer giaConLai;

    private String giaChu;

    public HoaDonPDT(HoaDonEntity hoaDonEntity) {
        this.maHD = hoaDonEntity.getMaHD();
        this.ngay = hoaDonEntity.getNgay();
        this.trigia = hoaDonEntity.getTrigia();
        this.giaSauThue = hoaDonEntity.getGiaSauThue();
        if (hoaDonEntity.getMasothue() != null) this.masothue = hoaDonEntity.getMasothue();
        if (hoaDonEntity.getHotenkh() != null) this.hotenkh = hoaDonEntity.getHotenkh();
        this.idnv = hoaDonEntity.getIdnv().getIdNV();
        this.hoTenNV = hoaDonEntity.getIdnv().getHoTen();
    }
}
