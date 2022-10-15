package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.dto.TaiKhoanDTO;
import com.example.NTH_Restaurant_API.entity.NhanVienEntity;
import com.example.NTH_Restaurant_API.entity.TaiKhoanEntity;
import com.example.NTH_Restaurant_API.payload.request.LoginRequest;
import com.example.NTH_Restaurant_API.payload.request.SignupRequest;
import com.example.NTH_Restaurant_API.payload.response.JwtResponse;
import com.example.NTH_Restaurant_API.payload.response.MessageResponse;
import com.example.NTH_Restaurant_API.repository.BoPhanRepository;
import com.example.NTH_Restaurant_API.repository.NhanVienRepository;
import com.example.NTH_Restaurant_API.repository.TaiKhoanRepository;
import com.example.NTH_Restaurant_API.security.jwt.JwtUtils;
import com.example.NTH_Restaurant_API.security.service.UserDetailsImpl;
import com.example.NTH_Restaurant_API.service.NhanVienService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;
import java.util.Random;
import java.util.stream.Collectors;

@RestController
@RequestMapping("/api/taikhoan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class TaiKhoanController {
    @Autowired
    private AuthenticationManager authenticationManager;

    @Autowired
    private TaiKhoanRepository taiKhoanRepository;

    @Autowired
    private BoPhanRepository boPhanRepository;

    @Autowired
    private PasswordEncoder encoder;

    @Autowired
    private NhanVienRepository nhanVienRepository;

    @Autowired
    private NhanVienService nhanVienService;

    @Autowired
    private JwtUtils jwtUtils;

    @PostMapping("/dangnhap")
    public ResponseEntity<?> dangNhap(@Valid @RequestBody LoginRequest loginRequest) {
        Authentication authentication = authenticationManager.authenticate(
                new UsernamePasswordAuthenticationToken(loginRequest.getMaTK(), loginRequest.getMatKhau())
        );
        SecurityContextHolder.getContext().setAuthentication(authentication);
        String jwt = jwtUtils.generateJwtToken(authentication);

        UserDetailsImpl userDetails = (UserDetailsImpl) authentication.getPrincipal();
        List<String> roles = userDetails.getAuthorities().stream()
                .map(GrantedAuthority::getAuthority)
                .collect(Collectors.toList());
        return ResponseEntity.ok(new JwtResponse(jwt, userDetails.getUsername(), roles.get(0)));
    }

    @PostMapping("/dangky")
    public ResponseEntity<?> dangKy(@Validated @RequestBody SignupRequest signupRequest) {
        if (taiKhoanRepository.existsByMaTK(signupRequest.getMaTK())) {
            return ResponseEntity
                    .badRequest()
                    .body(new MessageResponse("Lỗi: Mã tài khoản đã tồn tại!"));
        }

        NhanVienEntity nhanVien = new NhanVienEntity();
        nhanVien.setHoTen(signupRequest.getHoTen());
        nhanVien.setEmail(signupRequest.getEmail());
        nhanVien.setSDT(signupRequest.getSDT());
        nhanVien.setDiaChi(signupRequest.getDiaChi());
        nhanVien.setMapb(boPhanRepository.getById(signupRequest.getMaBP()));

        try {
            NhanVienEntity nv = nhanVienRepository.save(nhanVien);
            TaiKhoanEntity taiKhoan = new TaiKhoanEntity();
            taiKhoan.setMaTK(signupRequest.getMaTK());
            taiKhoan.setMatKhau(encoder.encode(signupRequest.getMatKhau()));
            taiKhoan.setIdnv(nv);
            taiKhoanRepository.save(taiKhoan);
            return ResponseEntity.ok(new MessageResponse("Đăng ký thành công!"));
        }
        catch (Exception e){
            return ResponseEntity.ok(new MessageResponse("Đăng ký thất bại!"));
        }
    }

    @GetMapping("")
    public List<TaiKhoanDTO> layDSTaiKhoan(){
        List<TaiKhoanEntity> listTK = taiKhoanRepository.findAll();
        return listTK.stream().map(TaiKhoanDTO::new).collect(Collectors.toList());
    }

    @PutMapping("")
    public String suaTaiKhoan(@Valid @RequestBody TaiKhoanDTO taiKhoan){
        TaiKhoanEntity taiKhoanEntity = taiKhoan.toEntity();
        NhanVienEntity nhanVien = nhanVienRepository.getById(taiKhoan.getIdnv());
        taiKhoanEntity.setIdnv(nhanVien);
        taiKhoanEntity.setMatKhau(encoder.encode(taiKhoanEntity.getMatKhau()));
        try {
            taiKhoanRepository.save(taiKhoanEntity);
            return "true";
        }
        catch (Exception e){
            return "false";
        }
    }

}
