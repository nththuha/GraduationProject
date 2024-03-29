package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.BanDaDat;
import com.example.NTH_Restaurant_API.entity.CT_BanEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;

public interface CT_BanRepository extends JpaRepository<CT_BanEntity, Integer> {
    List<CT_BanEntity> findByMaphong_MaPhong(String maPhong);

    List<CT_BanEntity> findByMaban_MaBan(String maBan);

    @Transactional
    @Modifying
    @Query(value = "select * \n" +
                "from ct_ban \n" +
                "where maban = :maBan and maphong = :maPhong", nativeQuery = true)
    List<CT_BanEntity> layCTBanTheoPhongBan(@Param("maPhong") String maPhong, @Param("maBan") String maBan);

    @Transactional
    @Modifying
    @Query(value = "select t.idctb, t.maphong, t.maban " +
            "from (select idpdt " +
            "from phieudattruoc " +
            "where ngaydat = :ngay and giodat - 4 < :gio and giodat + 4 > :gio and trangthai != 'Hủy phiếu') pdt," +
            "(select ctb.idctb, ctb.maban, ctb.maphong, dbt.idpdt " +
            "from ct_ban ctb, ct_datbantruoc dbt " +
            "where ctb.idctb = dbt.idctb and ctb.maphong = :maPhong) t " +
            "where pdt.idpdt = t.idpdt", nativeQuery = true)
    List<BanDaDat> layCTBanDaDat(@Param("ngay") Date ngay, @Param("gio") Integer gio, @Param("maPhong") String maPhong);

    @Transactional
    @Modifying
    @Query(value = "select t.idctb, t.maphong, t.maban " +
            "from (select idpdt " +
            "from phieudattruoc " +
            "where ngaydat = :ngay and giodat - 4 < :gio and giodat + 4 > :gio and trangthai = 'Đã đặt') pdt," +
            "(select ctb.idctb, ctb.maban, ctb.maphong, dbt.idpdt " +
            "from ct_ban ctb, ct_datbantruoc dbt \n" +
            "where ctb.idctb = dbt.idctb and ctb.maphong = :maPhong) t " +
            "where pdt.idpdt = t.idpdt", nativeQuery = true)
    List<BanDaDat> layCTBanDaDatTrongNgay(@Param("ngay") Date ngay, @Param("gio") Integer gio, @Param("maPhong") String maPhong);
}
