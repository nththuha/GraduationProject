package com.example.NTH_Restaurant_API.service;

import com.example.NTH_Restaurant_API.dto.CT_PhieuMuaDTO;
import com.example.NTH_Restaurant_API.dto.PhieuMuaNguyenLieuDTO;

import java.util.List;

public interface PhieuMuaNguyenLieuService {
    List<CT_PhieuMuaDTO> layDSNguyenLieuCanMua(PhieuMuaNguyenLieuDTO phieuMuaNguyenLieuDTO);

    List<PhieuMuaNguyenLieuDTO> layDSPhieuMuaNguyenLieu();
}
