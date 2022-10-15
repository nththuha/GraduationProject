package com.example.NTH_Restaurant_API.payload.request;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class SignupRequest {
    private Integer idnv;
    private String maTK;
    private String matKhau;
    private String hoTen;
    private String sDT;
    private String diaChi;
    private String email;
    private String maBP;
    private String tenBP;
}
