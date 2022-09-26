package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_BanRepository extends JpaRepository<CT_BanEntity, Integer> {
    List<CT_BanEntity> findByMaphong_MaPhong(String maPhong);

    List<CT_BanEntity> findByMaban_MaBan(String maBan);
}
