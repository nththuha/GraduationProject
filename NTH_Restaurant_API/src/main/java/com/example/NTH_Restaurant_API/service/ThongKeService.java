package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.ThongKeDTO;

import java.util.List;

public interface ThongKeService {
    List<ThongKeDTO> thongKeDoanhThuTheoThang(ThongKeDTO thongKeDTO);

    List<ThongKeDTO> thongKeLoiNhuanTheoThang(ThongKeDTO thongKeDTO);
}
