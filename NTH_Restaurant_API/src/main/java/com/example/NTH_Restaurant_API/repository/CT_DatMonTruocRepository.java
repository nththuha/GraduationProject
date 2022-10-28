package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_DatMonTruocEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_DatMonTruocRepository extends JpaRepository<CT_DatMonTruocEntity, Integer> {
    List<CT_DatMonTruocEntity> findByIdpdt_IdPDT(Integer idPDT);
    Long deleteByIdpdt_IdPDT(Integer idPDT);
}
