package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "HUYPHIEUDATTRUOC")
public class HuyPhieuDatTruocEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDHPDT")
    private Integer idHPDT;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    private Date ngay;

    @Column(name = "SOTIEN")
    private Integer soTien;

    @JoinColumn(name = "IDNV", referencedColumnName = "IDNV")
    @ManyToOne
    private NhanVienEntity idnv;

    @JoinColumn(name = "IDPDT", referencedColumnName = "IDPDT")
    @ManyToOne
    private PhieuDatTruocEntity idpdt;
}
