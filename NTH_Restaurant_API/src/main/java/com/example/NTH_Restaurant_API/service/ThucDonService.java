package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.ThucDonDTO;

import java.util.List;

public interface ThucDonService {
    List<ThucDonDTO> layDSThucDon();

    String themThucDon(ThucDonDTO thucDonDTO);

    String xoaThucDon(Integer idTD);

    String saoChepThucDon(ThucDonDTO thucDonDTO);
}
