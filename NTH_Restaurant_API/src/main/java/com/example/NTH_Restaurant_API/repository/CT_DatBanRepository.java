package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import com.example.NTH_Restaurant_API.entity.CT_DatBanEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_DatBanRepository extends JpaRepository<CT_DatBanEntity, Integer> {
    CT_DatBanEntity findByIdpd_IdPD(Integer idPD);

    List<CT_BanEntity> findByIdctb_IdCTB(Integer idCTB);
}
