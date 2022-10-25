package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_ThucDonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_ThucDonDTO {
    private Integer idCTTD;
    private Integer soLuong;
    private String mama;
    private String tenma;
    private Integer gia;
    private Integer idtd;

    public CT_ThucDonDTO(CT_ThucDonEntity ct_thucDonEntity){
        this.idCTTD = ct_thucDonEntity.getIdCTTD();
        this.soLuong = ct_thucDonEntity.getSoLuong();
        this.mama = ct_thucDonEntity.getMama().getMaMA();
        this.tenma = ct_thucDonEntity.getMama().getTenMA();
        this.gia = ct_thucDonEntity.getGia();
        this.idtd = ct_thucDonEntity.getIdtd().getIdTD();
    }

    public CT_ThucDonEntity toEntity(){
        CT_ThucDonEntity ct_thucDonEntity = new CT_ThucDonEntity();
        ct_thucDonEntity.setIdCTTD(this.idCTTD);
        ct_thucDonEntity.setSoLuong(this.soLuong);
        ct_thucDonEntity.setGia(this.gia);
        return ct_thucDonEntity;
    }
}
