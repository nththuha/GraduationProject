package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.BanEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BanRepository extends JpaRepository<BanEntity, String> {
    Boolean existsByMaBan(String maBan);
}
