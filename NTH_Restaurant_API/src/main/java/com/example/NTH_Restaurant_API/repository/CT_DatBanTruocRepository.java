package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_DatBanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatBanTruocEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_DatBanTruocRepository extends JpaRepository<CT_DatBanEntity, Integer> {
    List<CT_DatBanTruocEntity> findByIdtd_IdTD(Integer idTD);
}
