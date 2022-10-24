package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class ThucDonDTO {
    private Integer idTD;
    private String tenTD;
    private Date ngayTao;
    private Integer gia;
    private String loaitd;
    private List<CT_ThucDonDTO> listCT_ThucDon;

    public ThucDonDTO(ThucDonEntity thucDonEntity){
        this.idTD = thucDonEntity.getIdTD();
        this.tenTD = thucDonEntity.getTenTD();
        this.ngayTao = thucDonEntity.getNgayTao();
        this.loaitd = thucDonEntity.getLoaitd();
        this.gia = thucDonEntity.getGia();
        this.listCT_ThucDon = thucDonEntity.getCtThucdonList().stream().map(CT_ThucDonDTO::new).collect(Collectors.toList());
    }

    public ThucDonEntity toEntity(){
        ThucDonEntity thucDonEntity = new ThucDonEntity();
        thucDonEntity.setIdTD(this.idTD);
        thucDonEntity.setTenTD(this.tenTD);
        thucDonEntity.setNgayTao(this.ngayTao);
        thucDonEntity.setLoaitd(this.loaitd);
        return thucDonEntity;
    }
}
