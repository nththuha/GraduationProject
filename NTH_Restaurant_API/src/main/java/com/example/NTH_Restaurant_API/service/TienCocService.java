package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.TienCocDTO;

import java.util.List;

public interface TienCocService {
    List<TienCocDTO> latDSTienCocTheoPDT(Integer idpdt);

    String themTienCoc(TienCocDTO tienCocDTO);

    String xoaTienCoc(Integer idTC);
}
