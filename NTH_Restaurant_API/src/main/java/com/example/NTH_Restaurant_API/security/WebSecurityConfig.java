package com.example.NTH_Restaurant_API.security;

import com.example.NTH_Restaurant_API.security.jwt.AuthEntryPointJwt;
import com.example.NTH_Restaurant_API.security.jwt.AuthTokenFilter;
import com.example.NTH_Restaurant_API.security.service.UserDetailsServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.method.configuration.EnableGlobalMethodSecurity;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;

@Configuration
@EnableWebSecurity
@EnableGlobalMethodSecurity(prePostEnabled = true)
public class WebSecurityConfig extends WebSecurityConfigurerAdapter {
    @Autowired
    UserDetailsServiceImpl userDetailsService;

    @Autowired
    private AuthEntryPointJwt unAuthEntryPointJwt;

    @Bean
    public AuthTokenFilter authenticationJwtTokenFilter() {
        return new AuthTokenFilter();
    }

    @Override
    protected void configure(AuthenticationManagerBuilder authenticationManagerBuilder) throws Exception {
        authenticationManagerBuilder.userDetailsService(userDetailsService).passwordEncoder(passwordEncoder());
    }

    @Bean
    @Override
    public AuthenticationManager authenticationManagerBean() throws Exception {
        return super.authenticationManagerBean();
    }

    @Bean
    public PasswordEncoder passwordEncoder() {
        return new BCryptPasswordEncoder();
    }

    @Override
    protected void configure(HttpSecurity http) throws Exception {
        http.cors().and().csrf().disable()
                .exceptionHandling().authenticationEntryPoint(unAuthEntryPointJwt).and()
                .sessionManagement().sessionCreationPolicy(SessionCreationPolicy.STATELESS).and()
                .authorizeRequests()
                .antMatchers("/**").permitAll()
                .antMatchers("/api/ban/**").permitAll()
                .antMatchers("/api/bophan/**").permitAll()
                .antMatchers("/api/ctban/**").permitAll()
                .antMatchers("/api/ctdatmon/**").permitAll()
                .antMatchers("/api/ctdatmontruoc/**").permitAll()
                .antMatchers("/api/ctmonan/**").permitAll()
                .antMatchers("/api/ctphieumua/**").permitAll()
                .antMatchers("/api/ctphieunhap/**").permitAll()
                .antMatchers("/api/ctthucdon/**").permitAll()
                .antMatchers("/api/hoadon/**").permitAll()
                .antMatchers("/api/khachhang/**").permitAll()
                .antMatchers("/api/loaimonan/**").permitAll()
                .antMatchers("/api/monan/**").permitAll()
                .antMatchers("/api/nhanvien/**").permitAll()
                .antMatchers("/api/phieudat/**").permitAll()
                .antMatchers("/api/phieudattruoc/**").permitAll()
                .antMatchers("/api/phieumuanguyenlieu/**").permitAll()
                .antMatchers("/api/phieunhapnguyenlieu/**").permitAll()
                .antMatchers("/api/phong/**").permitAll()
                .antMatchers("/api/taikhoan/**").permitAll()
                .antMatchers("/api/thaydoigiamon/**").permitAll()
                .antMatchers("/api/thongke/**").permitAll()
                .antMatchers("/api/thucdon/**").permitAll()
                .antMatchers("/api/tiencoc/**").permitAll()
                .anyRequest().authenticated();

        http.addFilterBefore(authenticationJwtTokenFilter(), UsernamePasswordAuthenticationFilter.class);
    }
}
