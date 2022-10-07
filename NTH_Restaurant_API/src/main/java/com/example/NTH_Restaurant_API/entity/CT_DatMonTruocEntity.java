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
@Table(name = "CT_DATMONTRUOC")
public class CT_DatMonTruocEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDCTDMT")
    private Integer idctdmt;

    @Column(name = "SOLUONG")
    private Integer soluong;

    @Column(name = "CHUTHICH")
    @Size(max = 255)
    private String chuthich;

    @JoinColumn(name = "MAMA")
    @ManyToOne
    private MonAnEntity mama;

    @JoinColumn(name = "IDPDT")
    @ManyToOne
    private PhieuDatTruocEntity idpdt;
}
