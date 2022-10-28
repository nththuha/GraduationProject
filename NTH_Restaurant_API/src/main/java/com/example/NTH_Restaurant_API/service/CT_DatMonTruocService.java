package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_DatMonTruocDTO;

import java.util.List;

public interface CT_DatMonTruocService {
    List<CT_DatMonTruocDTO> layDSDatMonTheoPhieuDatTruoc(Integer idpdt);
}
