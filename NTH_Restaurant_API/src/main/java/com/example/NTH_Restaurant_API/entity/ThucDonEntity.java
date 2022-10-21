package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.Date;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "THUCDON")
public class ThucDonEntity {
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "IDTD")
    private Integer idTD;

    @Column(name = "TENTD")
    @Size(max = 50)
    private String tenTD;

    @Column(name = "NGAYTAO")
    @Temporal(TemporalType.DATE)
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private Date ngayTao;

    @Column(name = "GIA")
    private Integer gia;

    @Column(name = "LOAITD")
    @Size(max = 50)
    private String loaitd;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idtd")
    private List<CT_ThucDonEntity> ctThucdonList;

    @OneToMany(cascade = CascadeType.REFRESH, mappedBy = "idtd")
    private List<CT_DatBanTruocEntity> ctDatbantruocList;
}
