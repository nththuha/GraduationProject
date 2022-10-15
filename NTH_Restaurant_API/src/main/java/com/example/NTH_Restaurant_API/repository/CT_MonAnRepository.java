package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_MonAnEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_MonAnRepository extends JpaRepository<CT_MonAnEntity, Integer> {
    List<CT_MonAnEntity> findByMama_MaMA(String maMA);

    Boolean existsByIdCTMA(Integer idCTMA);
}
