package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.HuyPhieuDatTruocEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface HuyPhieuDatTruocRepository extends JpaRepository<HuyPhieuDatTruocEntity, Integer> {
    Boolean existsByIdHPDT(Integer idHPDT);
}
