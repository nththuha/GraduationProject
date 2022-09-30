package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.ThayDoiGiaMonDTO;
import com.example.NTH_Restaurant_API.entity.MonAnEntity;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.ThayDoiGiaMonEntity;
import com.example.NTH_Restaurant_API.repository.MonAnRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.ThayDoiGiaMonRepository;
import com.example.NTH_Restaurant_API.service.ThayDoiGiaMonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class ThayDoiGiaMonServiceImpl implements ThayDoiGiaMonService {
    @Autowired
    private ThayDoiGiaMonRepository thayDoiGiaMonRepository;

    @Autowired
    private MonAnRepository monAnRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Override
    public List<ThayDoiGiaMonDTO> layDSGiaMon(String maMA) {
        List<ThayDoiGiaMonEntity> thayDoiGiaMonEntity = thayDoiGiaMonRepository.findByMama_MaMAOrderByNgayDesc(maMA);
        return thayDoiGiaMonEntity.stream().map(ThayDoiGiaMonDTO::new).collect(Collectors.toList());
    }

    @Override
    public String themGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        if(!monAnRepository.existsByMaMA(thayDoiGiaMonDTO.getMama())) return "false";
        MonAnEntity monAnEntity = monAnRepository.getById(thayDoiGiaMonDTO.getMama());
        NhanVienEntity nhanVienEntity = nhanVienRepository.getById(thayDoiGiaMonDTO.getIdnv());
        ThayDoiGiaMonEntity temp = thayDoiGiaMonDTO.toEntity();
        temp.setIdGM(null);
        temp.setIdnv(nhanVienEntity);
        temp.setMama(monAnEntity);
        try{
            thayDoiGiaMonRepository.save(temp);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public int layGiaHienTai(String maMA) {
        List<ThayDoiGiaMonEntity> ds = thayDoiGiaMonRepository.findByMama_MaMAOrderByNgayDesc(maMA);
        DateFormat simpleDateFormat = new SimpleDateFormat("yyyy-MM-dd");
        Date currentDate = new Date();
        String now = simpleDateFormat.format(currentDate);
        Date hienTai = new Date();
        try {
            hienTai = simpleDateFormat.parse(now);
        } catch (Exception e) {
            System.out.println(e);
        }
        long min = 100000000;
        int vt = -1;
        for (int i = 0; i < ds.size(); i++) {
            long getDiff = hienTai.getTime() - ds.get(i).getNgay().getTime();
            long getDaysDiff = getDiff / (24 * 60 * 60 * 1000);
            if (getDaysDiff >= 0 && getDaysDiff < min) {
                min = getDaysDiff;
                vt = i;
            }
        }
        if (ds.size() > 0 && vt >= 0) return ds.get(vt).getGia();
        return 0;
    }

    @Override
    public String suaGiaMon(ThayDoiGiaMonDTO thayDoiGiaMonDTO) {
        if(!monAnRepository.existsByMaMA(thayDoiGiaMonDTO.getMama())) return "false";
        MonAnEntity monAnEntity = monAnRepository.getById(thayDoiGiaMonDTO.getMama());
        NhanVienEntity nhanVienEntity = nhanVienRepository.getById(thayDoiGiaMonDTO.getIdnv());
        ThayDoiGiaMonEntity giaMon = thayDoiGiaMonDTO.toEntity();
        giaMon.setGia(thayDoiGiaMonDTO.getGia());
        giaMon.setNgay(thayDoiGiaMonDTO.getNgay());
        giaMon.setMama(monAnEntity);
        giaMon.setIdnv(nhanVienEntity);
        try{
            thayDoiGiaMonRepository.save(giaMon);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

    @Override
    public String xoaGiaMon(Integer idGM) {
        try {
            thayDoiGiaMonRepository.deleteById(idGM);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }
}
