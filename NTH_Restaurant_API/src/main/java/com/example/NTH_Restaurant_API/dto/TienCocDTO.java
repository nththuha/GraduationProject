package com.example.NTH_Restaurant_API.dto;

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
}
