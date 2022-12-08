package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.NguyenLieuMua;
import com.example.NTH_Restaurant_API.dto.TempDTO;
import com.example.NTH_Restaurant_API.entity.PhieuNhapNguyenLieuEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;

public interface PhieuNhapNguyenLieuRepository extends JpaRepository<PhieuNhapNguyenLieuEntity, Integer> {
    Boolean existsByIdPN(Integer idPN);

    @Transactional
    @Modifying
    @Query(value = "select to_char(ngay, 'yyyy') as nam, to_char(ngay, 'MM') as thang, sum(ct.gia) as doanhthu\n" +
            "from(select p.idpn , p.ngay " +
            "from phieunhapnguyenlieu as p " +
            "where p.ngay >= :ngayBD and ngay <= :ngayKT) as t, ctpn_nguyenlieu as ct " +
            "where t.idpn = ct.idpn " +
            "group by nam, thang " +
            "order by thang, nam desc", nativeQuery = true)
    List<TempDTO> layThongKeTienMuaNguyenLieu(@Param("ngayBD") Date ngayBD, @Param("ngayKT") Date ngayKT);

    @Transactional
    @Modifying
    @Query(value = "select manl , soluong , gia\n" +
            "from ctpn_nguyenlieu cn, (select idpn\n" +
            "\t\t\t\t\t\t\tfrom phieunhapnguyenlieu\n" +
            "\t\t\t\t\t\t\twhere to_char(ngay, 'yyyy') = :nam and to_char(ngay, 'MM') = :thang) as t \n" +
            "where cn.idpn = t.idpn and cn.manl = :maNL\t", nativeQuery = true)
    List<NguyenLieuMua> layThongTinNguyenLieuDaMua(@Param("nam") String nam, @Param("thang") String thang, @Param("maNL") String maNL);
}
