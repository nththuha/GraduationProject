package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.HoaDonDTO;
import com.example.NTH_Restaurant_API.dto.HoaDonPD;
import com.example.NTH_Restaurant_API.dto.HoaDonPDT;

public interface HoaDonService {
    public String chuyenSangChu(String x);

    HoaDonPD themHoaDonTheoPhieuDat(HoaDonDTO hoaDonDTO);

    HoaDonPDT themHoaDonTheoPhieuDatTruoc(HoaDonDTO hoaDonDTO);
}
