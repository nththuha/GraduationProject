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
public class TachHoaDon {
    private String maHD;
    private String hoTenKH;
    private String maSoThue;
    private String noiDung;
    private Date ngay;
    private Integer soTien;
    private Integer idPD;
    private Integer idNV;

    public HoaDonEntity toEntity(){
        HoaDonEntity hd = new HoaDonEntity();
        hd.setMaHD(this.maHD);
        hd.setHotenkh(this.hoTenKH);
        hd.setMasothue(this.maSoThue);
        hd.setNgay(this.ngay);
        hd.setTrigia((int) (this.soTien/1.1));
        hd.setGiaSauThue(this.soTien);
        return hd;
    }
}
