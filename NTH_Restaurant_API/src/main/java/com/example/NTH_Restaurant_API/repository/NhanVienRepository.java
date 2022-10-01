package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface NhanVienRepository extends JpaRepository<NhanVienEntity, Integer> {
    Boolean existsByEmail(String email);

    NhanVienEntity findByTaikhoan_MaTK(String maTK);
}
