package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_HoaDonEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_HoaDonRepository extends JpaRepository<CT_HoaDonEntity, Integer> {
    List<CT_HoaDonEntity> findByIdpd_IdPD(Integer idPD);
}
