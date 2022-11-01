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
@Table(name = "CT_PHIEUMUA")
public class  CT_PhieuMuaEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTPM")
    private Integer idCTPM;

    @Column(name = "SOLUONG")
    private Integer soLuong;

    @JoinColumn(name = "MANL")
    @ManyToOne
    private NguyenLieuEntity manl;

    @JoinColumn(name = "IDPM")
    @ManyToOne
    private PhieuMuaNguyenLieuEntity idpm;
}
