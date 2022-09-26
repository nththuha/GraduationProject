package com.example.NTH_Restaurant_API.security.service;

import com.example.NTH_Restaurant_API.entity.TaiKhoanEntity;
import com.example.NTH_Restaurant_API.repository.TaiKhoanRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;

@Service
public class UserDetailsServiceImpl implements UserDetailsService {
    @Autowired
    TaiKhoanRepository taiKhoanRepository;

    @Override
    @Transactional
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        TaiKhoanEntity user = taiKhoanRepository.findByMaTK(username)
                .orElseThrow(() -> new UsernameNotFoundException("User Not Found with user name" + username));
        return UserDetailsImpl.build(user);
    }
}
