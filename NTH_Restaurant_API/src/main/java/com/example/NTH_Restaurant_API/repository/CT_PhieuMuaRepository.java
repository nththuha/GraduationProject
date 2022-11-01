package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_PhieuMuaEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Date;
import java.util.List;

public interface CT_PhieuMuaRepository extends JpaRepository<CT_PhieuMuaEntity, Integer> {
    List<CT_PhieuMuaEntity> findByIdpm_Ngay(Date ngay);
}
