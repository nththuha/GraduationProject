package com.example.NTH_Restaurant_API.dto;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class TienMuaNguyenLieu {
    private String nam;
    private String thang;
    private String maNL;
    private Integer triGia;
}
