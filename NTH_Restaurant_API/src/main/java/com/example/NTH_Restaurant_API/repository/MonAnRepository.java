package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface MonAnRepository extends JpaRepository<MonAnEntity, String> {
    Boolean existsByMaMA(String maMA);

    List<MonAnEntity> findByMalma_MaLMA(String maLMA);
}
