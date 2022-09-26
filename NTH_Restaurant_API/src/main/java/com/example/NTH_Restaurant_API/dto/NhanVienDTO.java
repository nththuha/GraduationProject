package com.example.NTH_Restaurant_API.dto;

import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class NhanVienDTO {
    private Integer idNV;

    private String hoTen;

    private String sDT;

    private String diaChi;

    private String email;

    private String taiKhoan;

    private String maBP;

    private String tenBP;

    public NhanVienDTO(NhanVienEntity nhanVienEntity) {
        this.idNV = nhanVienEntity.getIdNV();
        this.hoTen = nhanVienEntity.getHoTen();
        this.sDT = nhanVienEntity.getSDT();
        this.diaChi = nhanVienEntity.getDiaChi();
        this.email = nhanVienEntity.getEmail();
        if (nhanVienEntity.getTaikhoan() != null) this.taiKhoan = nhanVienEntity.getTaikhoan().getMaTK();
        this.maBP = nhanVienEntity.getMapb().getMaBP();
        this.tenBP = nhanVienEntity.getMapb().getTenBP().name();
    }

    public NhanVienEntity toEntity() {
        NhanVienEntity nhanVienEntity = new NhanVienEntity();
        nhanVienEntity.setIdNV(this.idNV);
        nhanVienEntity.setHoTen(this.hoTen);
        nhanVienEntity.setSDT(this.sDT);
        nhanVienEntity.setDiaChi(this.diaChi);
        nhanVienEntity.setEmail(this.email);
        return nhanVienEntity;
    }
}
