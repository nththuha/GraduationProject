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
@Table(name = "CT_DATBAN")
public class CT_DatBanEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTDB")
    private Integer idCTDB;

    @ManyToOne
    @JoinColumn(name = "IDCTB")
    private CT_BanEntity idctb;

    @ManyToOne
    @JoinColumn(name = "IDPD")
    private PhieuDatEntity idpd;

    @JoinColumn(name = "IDTD")
    @ManyToOne()
    private ThucDonEntity idtd;
}
