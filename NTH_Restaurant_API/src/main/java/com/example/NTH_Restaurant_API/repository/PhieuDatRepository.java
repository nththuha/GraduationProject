package com.example.NTH_Restaurant_API.repository;

import com.example.NTH_Restaurant_API.dto.BanDaDat;
import com.example.NTH_Restaurant_API.entity.PhieuDatEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import javax.transaction.Transactional;
import java.util.Date;
import java.util.List;

public interface PhieuDatRepository extends JpaRepository<PhieuDatEntity, Integer> {
}
