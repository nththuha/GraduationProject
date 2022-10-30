package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.TienCocEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TienCocDTO {
    private Integer idTC;
    private Date ngay;
    private Integer triGia;
    private String sdt;
    private String hoTenKH;
    private Integer idnv;
    private Integer idpdt;

    public TienCocDTO(TienCocEntity tienCocEntity){
        this.idTC = tienCocEntity.getIdTC();
        this.ngay = tienCocEntity.getNgay();
        this.triGia = tienCocEntity.getTriGia();
        this.sdt = tienCocEntity.getSdt();
        this.hoTenKH = tienCocEntity.getHoTenKH();
        this.idnv = tienCocEntity.getIdnv().getIdNV();
        this.idpdt = tienCocEntity.getIdpdt().getIdPDT();
    }

    public TienCocEntity toEntity(){
        TienCocEntity tienCoc = new TienCocEntity();
        tienCoc.setIdTC(this.idTC);
        tienCoc.setNgay(this.ngay);
        tienCoc.setTriGia(this.triGia);
        tienCoc.setSdt(this.sdt);
        tienCoc.setHoTenKH(this.hoTenKH);
        return tienCoc;
    }
}
