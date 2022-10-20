package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "KHACHHANG")
public class KhachHangEntity {
    @Id
    @Column(name = "IDKH")
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idKH;

    @Column(name = "HOTEN")
    @Size(max = 50)
    private String hoTen;

    @Column(name = "SDT")
    @Size(max = 50)
    private String sDT;

    @Column(name = "CMND")
    @Size(max = 50)
    private String cmnd;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idkh")
    private List<PhieuDatTruocEntity> phieudattruocList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idkh")
    private List<PhieuDatEntity> phieudatList;

}
