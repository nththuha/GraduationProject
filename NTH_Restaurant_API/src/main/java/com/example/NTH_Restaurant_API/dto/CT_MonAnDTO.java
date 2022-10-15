package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_MonAnEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_MonAnDTO {
    private Integer idCTMA;
    private Integer soLuong;
    private String mama;
    private String tenma;
    private String manl;
    private String tennl;
    private String donVi;

    public CT_MonAnDTO(CT_MonAnEntity ct_monAnEntity){
        this.idCTMA = ct_monAnEntity.getIdCTMA();
        this.soLuong = ct_monAnEntity.getSoLuong();
        this.mama = ct_monAnEntity.getMama().getMaMA();
        this.tenma = ct_monAnEntity.getMama().getTenMA();
        this.manl = ct_monAnEntity.getManl().getMaNL();
        this.tennl = ct_monAnEntity.getManl().getTenNL();
        this.donVi = ct_monAnEntity.getManl().getDonVi();
    }

    public CT_MonAnEntity toEntity(){
        CT_MonAnEntity ct_monAnEntity = new CT_MonAnEntity();
        ct_monAnEntity.setIdCTMA(this.idCTMA);
        ct_monAnEntity.setSoLuong(this.soLuong);
        return ct_monAnEntity;
    }
}
