package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface NhanVienRepository extends JpaRepository<NhanVienEntity, Integer> {
    Boolean existsByEmail(String email);
}
