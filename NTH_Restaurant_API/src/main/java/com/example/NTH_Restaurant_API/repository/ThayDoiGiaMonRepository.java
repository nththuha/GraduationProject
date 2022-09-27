package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.ThayDoiGiaMonEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface ThayDoiGiaMonRepository extends JpaRepository<ThayDoiGiaMonEntity, Integer> {
    List<ThayDoiGiaMonEntity> findByMama_MaMAOrderByNgayDesc(String maMA);
}
