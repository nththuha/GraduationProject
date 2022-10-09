package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.Date;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "TIENCOC")
public class TienCocEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDTC")
    private Integer idTC;

    @Column(name = "NGAY")
    @Temporal(TemporalType.DATE)
    private Date ngay;

    @Column(name = "TRIGIA")
    private Integer triGia;

    @Column(name = "CMND")
    @Size(max = 50)
    private String cmnd;

    @Column(name = "HOTENKH")
    @Size(max = 50)
    private String hoTenKH;

    @JoinColumn(name = "IDNV")
    @ManyToOne()
    private NhanVienEntity idnv;

    @JoinColumn(name = "IDPDT")
    @ManyToOne
    private PhieuDatTruocEntity idpdt;
}
