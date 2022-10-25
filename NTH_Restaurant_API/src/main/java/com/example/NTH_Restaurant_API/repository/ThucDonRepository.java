package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.ThucDonEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;

import javax.transaction.Transactional;
import java.util.List;

public interface ThucDonRepository extends JpaRepository<ThucDonEntity, Integer> {
    Boolean existsByIdTD(Integer idTD);

    @Transactional
    @Modifying
    @Query(value = "select * from thucdon order by thucdon.loaitd desc", nativeQuery = true)
    public List<ThucDonEntity> layDSThucDonTheoLoai();
}
