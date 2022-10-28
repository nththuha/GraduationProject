package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_DatMonTruocEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class CT_DatMonTruocDTO {
    private Integer idctdmt;
    private Integer soluong;
    private Integer gia;
    private String mama;
    private String tenma;
    private Integer idpdt;

    public  CT_DatMonTruocDTO(CT_DatMonTruocEntity ct_datMonTruocEntity){
        this.idctdmt = ct_datMonTruocEntity.getIdctdmt();
        this.soluong = ct_datMonTruocEntity.getSoluong();
        this.gia = ct_datMonTruocEntity.getGia();
        this.mama = ct_datMonTruocEntity.getMama().getMaMA();
        this.tenma = ct_datMonTruocEntity.getMama().getTenMA();
        this.idpdt = ct_datMonTruocEntity.getIdpdt().getIdPDT();
    }

    public CT_DatMonTruocEntity toEntity(){
        CT_DatMonTruocEntity ct_datMonTruoc = new CT_DatMonTruocEntity();
        ct_datMonTruoc.setIdctdmt(this.idctdmt);
        ct_datMonTruoc.setSoluong(this.soluong);
        ct_datMonTruoc.setGia(this.gia);
        return ct_datMonTruoc;
    }
}
