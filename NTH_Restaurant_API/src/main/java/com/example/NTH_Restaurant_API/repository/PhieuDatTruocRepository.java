package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.PhieuDatTruocEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;

public interface PhieuDatTruocRepository extends JpaRepository<PhieuDatTruocEntity, Integer> {
    Boolean existsByIdPDT(Integer idPDT);

    PhieuDatTruocEntity findByIdpdt_IdPD(Integer idPD);

    @Transactional
    @Modifying
    @Query(value = "select * from phieudattruoc where phieudattruoc.ngaydat = :ngay", nativeQuery = true)
    public List<PhieuDatTruocEntity> layDSPhieuDatTruocNgayNgay(@Param("ngay") Date ngay);

    @Transactional
    @Modifying
    @Query(value = "select * from phieudattruoc where phieudattruoc.ngaydat >= current_date", nativeQuery = true)
    public List<PhieuDatTruocEntity> layDSPhieuDatTruoc();
}
