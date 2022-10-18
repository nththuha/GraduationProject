package com.example.NTH_Restaurant_API.email;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.stereotype.Service;

import javax.mail.internet.InternetAddress;

@Service
public class EmailServiceImpl implements EmailService {
    @Autowired
    private JavaMailSender javaMailSender;

    @Value("${spring.mail.username}")
    private String sender;

    @Override
    public String guiMail(EmailDetail details) {
        try {
            // Creating a simple mail message
            SimpleMailMessage mailMessage = new SimpleMailMessage();

            // Setting up necessary details
            mailMessage.setFrom(String.valueOf(new InternetAddress("noreply@gmail.com", "noreply@gmail.com")));
            mailMessage.setTo(details.getNguoiNhan());
            mailMessage.setText(details.getNoiDung());
            mailMessage.setSubject(details.getTieuDe());

            // Sending the mail
            javaMailSender.send(mailMessage);
            return "true";
        }
        catch (Exception e) {
            return "false";
        }
    }
}
