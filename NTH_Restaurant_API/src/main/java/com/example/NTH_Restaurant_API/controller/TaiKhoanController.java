package com.example.NTH_Restaurant_API.controller;

import com.example.NTH_Restaurant_API.payload.request.LoginRequest;
import com.example.NTH_Restaurant_API.payload.response.JwtResponse;
import com.example.NTH_Restaurant_API.repository.BoPhanRepository;
import com.example.NTH_Restaurant_API.repository.TaiKhoanRepository;
import com.example.NTH_Restaurant_API.security.jwt.JwtUtils;
import com.example.NTH_Restaurant_API.security.service.UserDetailsImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;
import java.util.stream.Collectors;

@RestController
@RequestMapping("/api/taikhoan")
@CrossOrigin(origins = "*", maxAge = 3600)
public class TaiKhoanController {
    @Autowired
    AuthenticationManager authenticationManager;

    @Autowired
    TaiKhoanRepository taiKhoanRepository;

    @Autowired
    BoPhanRepository boPhanRepository;

    @Autowired
    PasswordEncoder encoder;

    @Autowired
    JwtUtils jwtUtils;

    @PostMapping("/dangnhap")
    public ResponseEntity<?> authenticateUser(@Valid @RequestBody LoginRequest loginRequest) {
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
}
