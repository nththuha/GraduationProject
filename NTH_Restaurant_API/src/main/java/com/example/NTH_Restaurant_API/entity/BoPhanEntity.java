package com.example.NTH_Restaurant_API.entity;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.Size;
import java.util.List;

@Getter
@Setter
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name = "BOPHAN")
public class BoPhanEntity {
    @Id
    @Column(name = "MABP")
    @Size(max = 10)
    private String maBP;

    @Enumerated(EnumType.STRING)
    @Column(length = 50)
    private EnumBoPhan tenBP;

    @OneToMany(mappedBy = "mapb")
    private List<NhanVienEntity> nhanVienList;
}