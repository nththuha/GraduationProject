package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "CT_HOADON")
public class CT_HoaDonEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTHD")
    private Integer idCTHD;

    @JoinColumn(name = "MAHD")
    @ManyToOne
    private HoaDonEntity mahd;

    @JoinColumn(name = "IDPD")
    @ManyToOne
    private PhieuDatEntity idpd;
}
