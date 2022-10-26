package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.BanDaDat;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.List;

public interface CT_BanRepository extends JpaRepository<CT_BanEntity, Integer> {
    List<CT_BanEntity> findByMaphong_MaPhong(String maPhong);

    List<CT_BanEntity> findByMaban_MaBan(String maBan);

    @Transactional
    @Modifying
    @Query(value = "select t.idctb, t.maphong, t.maban \n" +
            "from (select idpdt \n" +
            "from phieudattruoc \n" +
            "where ngaydat = :ngay) pdt, \n" +
            "(select ctb.idctb, ctb.maban, ctb.maphong, dbt.idpdt \n" +
            "from ct_ban ctb, ct_datbantruoc dbt \n" +
            "where ctb.idctb = dbt.idctb and ctb.maphong = :maPhong) t \n" +
            "where pdt.idpdt = t.idpdt", nativeQuery = true)
    List<BanDaDat> layCTBanDaDat(@Param("ngay") String ngay, @Param("maPhong") String maPhong);
}
