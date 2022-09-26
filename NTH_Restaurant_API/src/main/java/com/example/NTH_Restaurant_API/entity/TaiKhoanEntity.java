package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "TAIKHOAN")
public class TaiKhoanEntity {
    @Id
    @Column(name = "MATK")
    @Size(max = 10)
    private String maTK;

    @Column(name = "MATKHAU")
    @Size(max = 255)
    private String matKhau;

    @OneToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;
}
