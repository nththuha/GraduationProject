package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;

public interface MonAnRepository extends JpaRepository<MonAnEntity, String> {
    Boolean existsByMaMA(String maMA);

    List<MonAnEntity> findByMalma_MaLMA(String maLMA);

    @Transactional
    @Modifying
    @Query(value = "select * from monan order by monan.malma", nativeQuery = true)
    public List<MonAnEntity> layDSMonAnTheoLoai();
}
