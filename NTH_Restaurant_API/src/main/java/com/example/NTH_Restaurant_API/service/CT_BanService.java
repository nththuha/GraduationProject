package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.BanDTO;
import com.example.NTH_Restaurant_API.dto.CT_BanDTO;

import java.util.List;

public interface CT_BanService {
    List<BanDTO> layDSBanTheoPhong(String maphong);

    List<CT_BanDTO> layDSCTBanTheoPhong(String maphong);
}
