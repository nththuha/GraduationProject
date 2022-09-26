package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.BoPhanEntity;
import com.example.NTH_Restaurant_API.entity.EnumBoPhan;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface BoPhanRepository extends JpaRepository<BoPhanEntity, String> {
    Optional<BoPhanEntity> findByTenBP(EnumBoPhan name);

}
