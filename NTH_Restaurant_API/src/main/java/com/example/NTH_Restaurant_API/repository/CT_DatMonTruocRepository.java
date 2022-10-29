package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.CTDatMon;
import com.example.NTH_Restaurant_API.entity.CT_DatMonTruocEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.List;

public interface CT_DatMonTruocRepository extends JpaRepository<CT_DatMonTruocEntity, Integer> {
    List<CT_DatMonTruocEntity> findByIdpdt_IdPDT(Integer idPDT);

    @Transactional
    @Modifying
    @Query(value = "select ct.mama , ct.soluong , ct.gia\n" +
                "from ct_thucdon ct , (select cd.idtd\n" +
                "from ct_datbantruoc cd \n" +
                "where cd.idpdt = :idPDT) t\n" +
                "where ct.idtd = t.idtd", nativeQuery = true)
    public List<CTDatMon> layDSChiTietDatMon(@Param("idPDT") int idPDT);
}
