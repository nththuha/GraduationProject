package com.example.NTH_Restaurant_API.service.Impl;

import com.example.NTH_Restaurant_API.repository.HoaDonRepository;
import com.example.NTH_Restaurant_API.service.HoaDonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.HashMap;

@Service
public class HoaDonServiceImpl implements HoaDonService {
    @Autowired
    private HoaDonRepository hoaDonRepository;

    public static HashMap<String, String> hm_tien = new HashMap<String, String>() {
        {
            put("0", "không");
            put("1", "một");
            put("2", "hai");
            put("3", "ba");
            put("4", "bốn");
            put("5", "năm");
            put("6", "sáu");
            put("7", "bảy");
            put("8", "tám");
            put("9", "chín");
        }
    };
    public static HashMap<String, String> hm_hanh = new HashMap<String, String>() {
        {
            put("1", "VND");
            put("2", "mươi");
            put("3", "trăm");
            put("4", "nghìn");
            put("5", "mươi");
            put("6", "trăm");
            put("7", "triệu");
            put("8", "mươi");
            put("9", "trăm");
            put("10", "tỷ");
            put("11", "mươi");
            put("12", "trăm");
            put("13", "nghìn");
            put("14", "mươi");
            put("15", "trăm");
        }
    };

    public static String chuyenSangChu(String x) {
        StringBuilder kq = new StringBuilder();
        String m = x;
        int dem = m.length();
        String dau = "";
        int flag10 = 1;
        while (!m.equals("")) {
            if (m.length() <= 3 && m.length() > 1 && Long.parseLong(m) == 0) {
            } else {
                dau = m.substring(0, 1);
                if (dem % 3 == 1 && m.startsWith("1") && flag10 == 0) {
                    kq.append("mốt ");
                } else if (dem % 3 == 1 && m.startsWith("5") && flag10 == 0) {
                    kq.append("lăm ");
                } else if (dem % 3 == 2 && m.startsWith("1")) {
                    kq.append("mười ");
                    flag10 = 1;
                } else if (dem % 3 == 2 && m.startsWith("0") && m.charAt(1) != '0') {
                    kq.append("lẻ ");
                    flag10 = 1;
                } else {
                    if (!m.startsWith("0")) {
                        kq.append(hm_tien.get(dau)).append(" ");
                        flag10 = 0;
                    }
                }
                if (dem % 3 != 1 && m.startsWith("0")) {
                    //lẻ -> do nothing
                } else {
                    if (dem % 3 == 2 && (m.startsWith("1") || m.startsWith("0"))) {
                        //mười -> do nothing
                    } else {
                        kq.append(hm_hanh.get(dem + "")).append(" ");
                    }
                }
            }
            m = m.substring(1);
            dem = m.length();
        }
        kq = new StringBuilder(kq.substring(0, kq.length() - 1));
        return kq.toString();
    }
}
