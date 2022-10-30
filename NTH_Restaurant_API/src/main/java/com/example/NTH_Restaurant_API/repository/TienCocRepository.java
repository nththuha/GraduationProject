package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.TienCocEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TienCocRepository extends JpaRepository<TienCocEntity, Integer> {
    Boolean existsByIdTC(Integer idTC);
    List<TienCocEntity> findByIdpdt_IdPDT(Integer idPDT);
}
