package com.example.NTH_Restaurant_API.dto;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import java.sql.Timestamp;
import java.time.OffsetDateTime;
import java.util.Date;
import java.util.TimerTask;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class PhongNgay {
    private String maPhong;
    private Date ngay;
    private Date gio;
}
