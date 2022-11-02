package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.NguyenLieuCanMua;
import com.example.NTH_Restaurant_API.entity.PhieuMuaNguyenLieuEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;

public interface PhieuMuaNguyenLieuRepository extends JpaRepository<PhieuMuaNguyenLieuEntity, Integer> {
    Boolean existsByNgay(Date ngay);

    PhieuMuaNguyenLieuEntity findByNgay(Date ngay);

    @Transactional
    @Modifying
    @Query(value = "select * \n" +
                    "from phieumuanguyenlieu p \n" +
                    "order by ngay desc ", nativeQuery = true)
    List<PhieuMuaNguyenLieuEntity> layDSPhieuMuaNguyenLieu();

    @Transactional
    @Modifying
    @Query(value = "select t.manl as manl, sum(t.soluong) as soluong\n" +
            "from (select ctma.manl, (ctma.soluong * ma.soluong) as soluong\n" +
            "from (select td.mama, td.soluong\n" +
            "from (select p.idpdt\n" +
            "from phieudattruoc p \n" +
            "where p.ngaydat = :ngay) pdt, ct_datbantruoc dbt, ct_thucdon td\n" +
            "where pdt.idpdt = dbt.idpdt and dbt.idtd = td.idtd) ma, ct_monan ctma\n" +
            "where ma.mama = ctma.mama) as t\n" +
            "group by t.manl", nativeQuery = true)
    List<NguyenLieuCanMua> layDSNguyenLieuCanMuaTheoNgay(@Param("ngay") Date ngay);
}
