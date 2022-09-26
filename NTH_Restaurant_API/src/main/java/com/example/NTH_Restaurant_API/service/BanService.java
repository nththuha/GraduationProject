package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.BanDTO;

import java.util.List;

public interface BanService {
    List<BanDTO> layDSBan();

    String themBan(BanDTO banDTO);

    String suaBan(BanDTO banDTO);

    String xoaBan(String maBan);
}
