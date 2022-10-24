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
@Table(name = "CT_THUCDON")
public class CT_ThucDonEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTTD")
    private Integer idCTTD;

    @Column(name = "SOLUONG")
    private Integer soLuong;

    @Column(name = "GIA")
    private Integer gia;

    @ManyToOne
    @JoinColumn(name = "MAMA")
    private MonAnEntity mama;

    @ManyToOne
    @JoinColumn(name = "IDTD")
    private ThucDonEntity idtd;

}
