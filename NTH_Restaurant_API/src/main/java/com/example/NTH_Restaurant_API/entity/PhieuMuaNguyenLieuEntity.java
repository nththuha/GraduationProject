package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.util.Date;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "PHIEUMUANGUYENLIEU")
public class PhieuMuaNguyenLieuEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDPM")
    private Integer idPM;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date ngay;

    @ManyToOne
    @JoinColumn(name = "IDNV")
    private NhanVienEntity idnv;

    @OneToMany(mappedBy = "idpm")
    private List<PhieuNhapNguyenLieuEntity> phieunhapnguyenlieuList;

    @OneToMany(mappedBy = "idpm")
    private List<CT_PhieuMuaEntity> ctPhieumuaList;
}
