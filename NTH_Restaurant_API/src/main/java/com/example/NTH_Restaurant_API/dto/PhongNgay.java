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
public class PhongNgay {
    private String maPhong;
    private Date ngay;
    private Date gio;
}
