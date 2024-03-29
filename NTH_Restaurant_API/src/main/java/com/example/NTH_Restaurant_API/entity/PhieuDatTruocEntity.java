package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "PHIEUDATTRUOC")
public class PhieuDatTruocEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDPDT")
    private Integer idPDT;

    @Column(name = "NGAYTAO")
    @Temporal(TemporalType.DATE)
    private Date ngayTao;

    @Column(name = "NGAYDAT")
    @Temporal(TemporalType.DATE)
    private Date ngayDat;

    @Column(name = "GIODAT")
    private Integer gioDat;

    @Column(name = "GIA")
    private Integer gia;

    @Column(name = "GIASAUTHUE")
    private Integer giaSauThue;

    @Column(name = "TRANGTHAI")
    private String trangThai;

    @JoinColumn(name = "IDKH")
    @ManyToOne
    private KhachHangEntity idkh;

    @JoinColumn(name = "IDNV")
    @ManyToOne
    private NhanVienEntity idnv;

    @OneToOne(mappedBy = "idpdt")
    private PhieuDatEntity idpdt;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpdt")
    private List<CT_DatBanTruocEntity> ctDatbantruocList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpdt")
    private List<TienCocEntity> tiencocList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpdt")
    private List<HuyPhieuDatTruocEntity> huyphieudattruocList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpdt")
    private List<CT_DatMonTruocEntity> ctDatmontruocList;
}
