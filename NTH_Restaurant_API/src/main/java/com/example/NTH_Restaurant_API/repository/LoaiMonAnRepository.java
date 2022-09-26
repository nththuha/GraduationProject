package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.LoaiMonAnEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface LoaiMonAnRepository extends JpaRepository<LoaiMonAnEntity, String> {
    Boolean existsByMaLMA(String maLMA);
}
