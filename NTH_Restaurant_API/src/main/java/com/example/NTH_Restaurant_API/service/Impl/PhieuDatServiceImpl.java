package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.dto.PhieuDatDTO;
import com.example.NTH_Restaurant_API.dto.PhieuDatTruocDTO;
import com.example.NTH_Restaurant_API.entity.*;
import com.example.NTH_Restaurant_API.repository.*;
import com.example.NTH_Restaurant_API.service.PhieuDatService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class PhieuDatServiceImpl implements PhieuDatService {
    @Autowired
    private PhieuDatRepository phieuDatRepository;

    @Autowired
    private CT_DatBanRepository ct_datBanRepository;

    @Autowired
    private CT_BanRepository ct_banRepository;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private PhieuDatTruocRepository phieuDatTruocRepository;

    @Autowired
    private CT_DatBanTruocRepository ct_datBanTruocRepository;

    @Autowired
    private CT_HoaDonRepository ct_hoaDonRepository;

    @Autowired
    private CT_DatMonRepository ct_datMonRepository;

    @Autowired
    private CT_DatMonTruocRepository ct_datMonTruocRepository;

    @Override
    public List<PhieuDatDTO> layDSPhieuDatChuaCoHoaDon() {
        List<PhieuDatEntity> ds = phieuDatRepository.findAll();

        for (int i = 0; i < ds.size(); i++) {
            List<CT_HoaDonEntity> listCTHD = ct_hoaDonRepository.findByIdpd_IdPD(ds.get(i).getIdPD());
            if (listCTHD.size() > 0) {
                ds.remove(ds.get(i));
                i--;
            } else if (ds.get(i).getIdpdt() != null) {
                ds.remove(ds.get(i));
                i--;
            }
        }

        List<PhieuDatDTO> list = new ArrayList<>();

        for (int i = 0; i < ds.size(); i++) {
            list.add(new PhieuDatDTO(ds.get(i)));
            CT_DatBanEntity ct_datBanEntity = ct_datBanRepository.findByIdpd_IdPD(ds.get(i).getIdPD());
            if (ct_datBanEntity != null) {
                CT_BanEntity ct_banEntity = ct_banRepository.getById(ct_datBanEntity.getIdctb().getIdCTB());
                list.get(i).setMaPhong(ct_banEntity.getMaphong().getMaPhong());
                list.get(i).setTenPhong(ct_banEntity.getMaphong().getTenPhong());
                list.get(i).setMaBan(ct_banEntity.getMaban().getMaBan());
                list.get(i).setTenBan(ct_banEntity.getMaban().getTenBan());
            }

            List<CT_DatMonEntity> listCTDM = ct_datMonRepository.findByIdpd_IdPD(ds.get(i).getIdPD());
            int t = 0;
            for (CT_DatMonEntity j : listCTDM) {
                t += j.getGia();
            }
            list.get(i).setGia(t);
            list.get(i).setGiaSauThue((int) (t * 1.1));
        }

        return list;
    }

    @Override
    public PhieuDatDTO themPhieuDat(PhieuDatDTO phieuDatDTO) {
        List<CT_BanEntity> temp = ct_banRepository.findByMaphong_MaPhong(phieuDatDTO.getMaPhong());
        CT_BanEntity ct_banEntity = null;
        for (CT_BanEntity ctBanEntity : temp) {
            if (ctBanEntity.getMaban().getMaBan().equals(phieuDatDTO.getMaBan())) {
                ct_banEntity = ctBanEntity;
                ct_banEntity.setTrangThai("Hết chỗ");
                ct_banRepository.save(ct_banEntity);
                break;
            }
        }

        NhanVienEntity nhanVien = nhanVienRepository.getById(phieuDatDTO.getIdnv());
        PhieuDatEntity phieuDat = phieuDatDTO.toEntity();
        phieuDat.setIdPD(null);
        phieuDat.setIdnv(nhanVien);

        try {
            PhieuDatEntity pd = phieuDatRepository.save(phieuDat);

            CT_DatBanEntity ct_datBan = new CT_DatBanEntity();
            ct_datBan.setIdctb(ct_banEntity);
            ct_datBan.setIdpd(pd);
            ct_datBanRepository.save(ct_datBan);

            return new PhieuDatDTO(pd);
        } catch (Exception e) {
            return null;
        }
    }

    @Override
    public String themPhieuDatDuaTrenPhieuDatTruoc(PhieuDatTruocDTO phieuDatTruocDTO) {
        PhieuDatTruocEntity pdt = phieuDatTruocRepository.getById(phieuDatTruocDTO.getIdPDT());
        pdt.setTrangThai("Đã đến");
        PhieuDatEntity pd = new PhieuDatEntity();
        pd.setIdpdt(pdt);
        pd.setIdkh(pdt.getIdkh());
        pd.setIdnv(nhanVienRepository.getById(phieuDatTruocDTO.getIdnv()));
        pd.setNgay(new Date());
        try {
            phieuDatRepository.save(pd);
            phieuDatTruocRepository.save(pdt);

            List<CT_DatBanTruocEntity> listCTDBT = ct_datBanTruocRepository.findByIdpdt_IdPDT(pdt.getIdPDT());
            List<CT_BanEntity> listCTB = new ArrayList<>();
            for (CT_DatBanTruocEntity i : listCTDBT) {
                CT_BanEntity ctBan = i.getIdctb();
                ctBan.setTrangThai("Hết chỗ");
                listCTB.add(ctBan);
            }
            ct_banRepository.saveAll(listCTB);

            return "true";
        } catch (Exception e) {
            return "false";
        }
    }

    @Override
    public List<PhieuDatDTO> layDSPhieuDatPhieuDatTruoc() {
        List<PhieuDatEntity> ds = phieuDatRepository.findAll();
        for (int i = 0; i < ds.size(); i++) {
            List<CT_HoaDonEntity> listCTHD = ct_hoaDonRepository.findByIdpd_IdPD(ds.get(i).getIdPD());
            if (listCTHD.size() > 0) {
                ds.remove(ds.get(i));
                i--;
            } else if (ds.get(i).getIdpdt() == null) {
                ds.remove(ds.get(i));
                i--;
            }
        }
        List<PhieuDatDTO> listPD = ds.stream().map(PhieuDatDTO::new).collect(Collectors.toList());
        for (PhieuDatDTO i : listPD) {
            List<CT_DatMonTruocEntity> listCTDMT = ct_datMonTruocRepository.findByIdpdt_IdPDT(i.getIdPDT());
            int tong = 0;
            for (CT_DatMonTruocEntity j : listCTDMT) {
                tong += j.getGia();
            }
            i.setGia(tong);
            i.setGiaSauThue((int) (tong * 1.1));
        }

        return listPD;
    }
}
