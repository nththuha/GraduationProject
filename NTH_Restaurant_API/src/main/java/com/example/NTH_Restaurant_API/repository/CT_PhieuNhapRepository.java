package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_PhieuNhapEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_PhieuNhapRepository extends JpaRepository<CT_PhieuNhapEntity, Integer> {
    List<CT_PhieuNhapEntity> findByIdpn_IdPN(Integer idPN);
    Boolean existByIdCTPN(Integer idCTPN);
}
