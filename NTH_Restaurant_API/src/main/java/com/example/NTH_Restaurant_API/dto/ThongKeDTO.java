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
public class ThongKeDTO {
    private String ngay;
    private String thang;
    private String nam;
    private Integer doanhThu;
    private Date ngayBD;
    private Date ngayKT;
}
