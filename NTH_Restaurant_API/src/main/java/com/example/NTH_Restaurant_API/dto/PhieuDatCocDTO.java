package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
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
public class PhieuDatCocDTO {
    private Integer idPDT;
    private Date ngayTao;
    private Date ngayDat;
    private Integer gia;
    private Integer giaSauThue;
    private String giaChu;
    private Integer idkh;
    private String hoTenKH;
    private String sdt;
    private Integer idnv;
    private String hoTenNV;

    private List<CT_DatMonTruocDTO> listCTDMT;
    private List<TienCocDTO> listTC;

    public PhieuDatCocDTO(PhieuDatTruocEntity pdt){
        this.idPDT = pdt.getIdPDT();
        this.ngayTao = pdt.getNgayTao();
        this.ngayDat = pdt.getNgayDat();
        this.gia = pdt.getGia();
        this.giaSauThue = pdt.getGiaSauThue();
        this.idnv = pdt.getIdnv().getIdNV();
        this.hoTenNV = pdt.getIdnv().getHoTen();
        this.idkh = pdt.getIdkh().getIdKH();
        this.hoTenKH = pdt.getIdkh().getHoTen();
        this.sdt = pdt.getIdkh().getSDT();
    }
}
