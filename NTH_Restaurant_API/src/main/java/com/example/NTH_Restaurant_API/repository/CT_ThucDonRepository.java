package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_ThucDonEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_ThucDonRepository extends JpaRepository<CT_ThucDonEntity, Integer> {
    List<CT_ThucDonEntity> findByIdtd_IdTD(Integer idTD);
}
