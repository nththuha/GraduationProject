package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.CT_DatBanTruocEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
public class CT_DatBanTruocDTO {
    private Integer idCTDBT;
    private Integer idctb;
    private Integer idpdt;
    private Integer idtd;
    private String tentd;
    private String maBan;
    private String tenBan;
    private String maPhong;
    private String tenPhong;

    public CT_DatBanTruocDTO(CT_DatBanTruocEntity ct_datBanTruocEntity){
        this.idCTDBT = ct_datBanTruocEntity.getIdCTDBT();
        this.idctb = ct_datBanTruocEntity.getIdctb().getIdCTB();
        this.idpdt = ct_datBanTruocEntity.getIdpdt().getIdPDT();
        this.idtd = ct_datBanTruocEntity.getIdtd().getIdTD();
        this.tentd = ct_datBanTruocEntity.getIdtd().getTenTD();
        this.maBan = ct_datBanTruocEntity.getIdctb().getMaban().getMaBan();
        this.tenBan = ct_datBanTruocEntity.getIdctb().getMaban().getTenBan();
        this.maPhong = ct_datBanTruocEntity.getIdctb().getMaphong().getMaPhong();
        this.tenPhong = ct_datBanTruocEntity.getIdctb().getMaphong().getTenPhong();
    }
}
