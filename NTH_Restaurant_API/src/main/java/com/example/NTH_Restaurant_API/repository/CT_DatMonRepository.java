package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_DatMonEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_DatMonRepository extends JpaRepository<CT_DatMonEntity, Integer> {
    public List<CT_DatMonEntity> findByIdpd_IdPD(Integer idpd);
}
