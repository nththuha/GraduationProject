package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.TempDTO;
import com.example.NTH_Restaurant_API.entity.HoaDonEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;
@Repository
public interface HoaDonRepository extends JpaRepository<HoaDonEntity, String> {
    @Transactional
    @Modifying
    @Query(value = "select to_char(ngay, 'yyyy') as nam, to_char(ngay, 'MM') as thang , sum(giasauthue) as doanhthu \n" +
            "from hoadon \n" +
            "where ngay >= :ngayBD and ngay <= :ngayKT\n" +
            "group by nam, thang \n" +
            "order by thang, nam desc", nativeQuery = true)
    List<TempDTO> layThongKeDoanhThu(@Param("ngayBD") Date ngayBD, @Param("ngayKT") Date ngayKT);
}
