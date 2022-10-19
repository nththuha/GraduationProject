package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.KhachHangEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface KhachHangRepository extends JpaRepository<KhachHangEntity, Integer> {
    Boolean existsByIdKH(Integer idKH);
}
