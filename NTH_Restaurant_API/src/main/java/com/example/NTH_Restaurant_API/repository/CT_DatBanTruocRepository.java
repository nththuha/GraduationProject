package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.CT_DatBanTruocEntity;
import io.swagger.models.auth.In;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CT_DatBanTruocRepository extends JpaRepository<CT_DatBanTruocEntity, Integer> {
    Boolean existsByIdCTDBT(Integer idCTDBT);

    List<CT_DatBanTruocEntity> findByIdtd_IdTD(Integer idTD);

    List<CT_DatBanTruocEntity> findByIdpdt_IdPDT(Integer idPDT);
}
