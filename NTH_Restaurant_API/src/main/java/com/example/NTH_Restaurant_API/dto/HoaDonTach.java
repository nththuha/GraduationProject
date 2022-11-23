package com.example.NTH_Restaurant_API.dto;

import lombok.*;

import java.util.Date;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class HoaDonTach {
    private String maHD;
    private Date ngay;
    private String hoTenKh;
    private String maSoThue;
    private String noiDung;
    private double gia;
    private Integer giaSauThue;
    private String tienChu;

    public HoaDonTach(TachHoaDon tachHoaDon){
        this.maHD = tachHoaDon.getMaHD();
        this.ngay = tachHoaDon.getNgay();
        this.maSoThue = tachHoaDon.getMaSoThue();
        this.hoTenKh = tachHoaDon.getHoTenKH();
        this.noiDung = tachHoaDon.getNoiDung();
        this.giaSauThue = tachHoaDon.getSoTien();
        this.gia = this.giaSauThue/ 1.1;
    }
}
