package com.example.NTH_Restaurant_API.security.service;

import com.example.NTH_Restaurant_API.entity.TaiKhoanEntity;
import com.fasterxml.jackson.annotation.JsonIgnore;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.UserDetails;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.Objects;

public class UserDetailsImpl implements UserDetails {
    private static final long serialVersionUID = 1L;
    private String maTK;
    @JsonIgnore
    private String matKhau;
    private Collection<? extends GrantedAuthority> authorities;

    public UserDetailsImpl(String usernam, String password, Collection<? extends GrantedAuthority> authorities) {
        this.maTK = usernam;
        this.matKhau = password;
        this.authorities = authorities;
    }

    public static UserDetailsImpl build(TaiKhoanEntity user) {
        List<GrantedAuthority> authorities = new ArrayList<GrantedAuthority>();
        authorities.add(new SimpleGrantedAuthority(user.getIdnv().getMapb().getTenBP().name()));

        return new UserDetailsImpl(user.getMaTK(), user.getMatKhau(), authorities);
    }

    @Override
    public Collection<? extends GrantedAuthority> getAuthorities() {
        return authorities;
    }


    @Override
    public String getPassword() {
        return matKhau;
    }

    @Override
    public String getUsername() {
        return maTK;
    }

    @Override
    public boolean isAccountNonExpired() {
        return true;
    }

    @Override
    public boolean isAccountNonLocked() {
        return true;
    }

    @Override
    public boolean isCredentialsNonExpired() {
        return true;
    }

    @Override
    public boolean isEnabled() {
        return true;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj) return true;
        if (obj == null || getClass() != obj.getClass()) return false;
        UserDetailsImpl user = (UserDetailsImpl) obj;
        return Objects.equals(maTK, user.maTK);
    }
}
