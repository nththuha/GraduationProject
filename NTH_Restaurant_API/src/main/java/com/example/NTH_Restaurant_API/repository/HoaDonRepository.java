package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.NguyenLieu;
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

    @Transactional
    @Modifying
    @Query(value = "select to_char(ngay, 'yyyy') as nam, to_char(ngay, 'MM') as thang , sum(trigia) as doanhthu \n" +
            "from hoadon \n" +
            "where ngay >= :ngayBD and ngay <= :ngayKT\n" +
            "group by nam, thang \n" +
            "order by thang, nam desc", nativeQuery = true)
    List<TempDTO> layTongTriGiaHoaDonTheoThang(@Param("ngayBD") Date ngayBD, @Param("ngayKT") Date ngayKT);

    @Transactional
    @Modifying
    @Query(value = "select temp.nam, temp. thang, cm.manl , sum(temp.soluong * cm.soluong) as soluong\n" +
            "from ct_monan cm , (select t.nam, t.thang, cd.mama , sum(cd.soluong) as soluong\n" +
            "\t\t\t\t\tfrom ct_datmon cd, (select idpd , idpdt, to_char(ngay, 'yyyy') as nam, to_char(ngay, 'MM') as thang\n" +
            "\t\t\t\t\t\t\t\t\t\tfrom phieudat  \n" +
            "\t\t\t\t\t\t\t\t\t\twhere ngay >= :ngayBD and ngay <= :ngayKT) as t\n" +
            "\t\t\t\t\twhere cd.idpd = t.idpd\t\t\t\t\t\n" +
            "\t\t\t\t\tgroup by nam, thang, mama \n" +
            "\t\t\t\t\torder by thang, nam desc) as temp \n" +
            "where cm.mama = temp.mama\t\n" +
            "group by nam, thang, manl ", nativeQuery = true)
    List<NguyenLieu> laySoNguyenLieuSuDung(@Param("ngayBD") Date ngayBD, @Param("ngayKT") Date ngayKT);
}
