package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.NguyenLieuEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class NguyenLieuDTO {
    private String maNL;
    private String tenNL;
    private String donVi;
    private Integer slTon;
    private Integer slToiThieu;

    public NguyenLieuDTO(NguyenLieuEntity nguyenLieuEntity){
        this.maNL = nguyenLieuEntity.getMaNL();
        this.tenNL = nguyenLieuEntity.getTenNL();
        this.donVi = nguyenLieuEntity.getDonVi();
        this.slTon = nguyenLieuEntity.getSlTon();
        this.slToiThieu = nguyenLieuEntity.getSlToiThieu();
    }

    public NguyenLieuEntity toEntity(){
        NguyenLieuEntity nguyenLieu = new NguyenLieuEntity();
        nguyenLieu.setMaNL(this.maNL);
        nguyenLieu.setTenNL(this.tenNL);
        nguyenLieu.setDonVi(this.donVi);
        nguyenLieu.setSlTon(this.slTon);
        nguyenLieu.setSlToiThieu(this.slToiThieu);
        return nguyenLieu;
    }
}
