package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.PhieuNhapNguyenLieuEntity;
import org.springframework.data.jpa.repository.JpaRepository;

public interface PhieuNhapNguyenLieuRepository extends JpaRepository<PhieuNhapNguyenLieuEntity, Integer> {
    Boolean existsByIdPN(Integer idPN);
}
