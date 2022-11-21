package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.*;

import java.util.List;

public interface HoaDonService {
    public String chuyenSangChu(String x);

    HoaDonPD themHoaDonTheoPhieuDat(HoaDonDTO hoaDonDTO);

    HoaDonPDT themHoaDonTheoPhieuDatTruoc(HoaDonDTO hoaDonDTO);

    List<HoaDonTach> tachHoaDon(List<TachHoaDon> listHD);
}
