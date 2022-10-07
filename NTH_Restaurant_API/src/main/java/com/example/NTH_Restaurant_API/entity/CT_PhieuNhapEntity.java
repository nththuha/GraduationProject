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
@Table(name = "CTPN_NGUYENLIEU")
public class CT_PhieuNhapEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTPN")
    private Integer idCTPN;

    @Column(name = "SOLUONG")
    private Integer soLuong;

    @Column(name = "GIA")
    private Integer gia;

    @ManyToOne
    @JoinColumn(name = "MANL")
    private NguyenLieuEntity manl;

    @ManyToOne
    @JoinColumn(name = "IDPN")
    private PhieuNhapNguyenLieuEntity idpn;
}
