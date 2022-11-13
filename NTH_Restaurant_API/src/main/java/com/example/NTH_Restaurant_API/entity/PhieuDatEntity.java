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
@Table(name = "PHIEUDAT")
public class PhieuDatEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDPD")
    private Integer idPD;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    private Date ngay;

    @JoinColumn(name = "IDPDT")
    @OneToOne
    private PhieuDatTruocEntity idpdt;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpd")
    private List<CT_DatMonEntity> ctDatmonList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpd")
    private List<CT_DatBanEntity> ctDatbanList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idpd")
    private List<CT_HoaDonEntity> ctHoadonList;
    @ManyToOne
    @JoinColumn(name = "IDKH")
    private KhachHangEntity idkh;
    @ManyToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;
}
