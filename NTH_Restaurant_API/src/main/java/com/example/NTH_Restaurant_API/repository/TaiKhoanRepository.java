package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.TaiKhoanEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface TaiKhoanRepository extends JpaRepository<TaiKhoanEntity, String> {
    Optional<TaiKhoanEntity> findByMaTK(String maTK);

    Boolean existsByMaTK(String maTK);

    TaiKhoanEntity findByIdnv_IdNV(Integer idnv);
}
