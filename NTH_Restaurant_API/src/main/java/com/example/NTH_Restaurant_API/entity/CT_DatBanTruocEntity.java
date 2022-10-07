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
@Table(name = "CT_DATBANTRUOC")
public class CT_DatBanTruocEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTDBT")
    private Integer idCTDBT;

    @JoinColumn(name = "IDCTB")
    @ManyToOne
    private CT_BanEntity idctb;

    @JoinColumn(name = "IDPDT")
    @ManyToOne
    private PhieuDatEntity idpdt;
}
