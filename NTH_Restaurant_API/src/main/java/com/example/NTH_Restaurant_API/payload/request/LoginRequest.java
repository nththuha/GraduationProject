package com.example.NTH_Restaurant_API.payload.request;

public class LoginRequest {
    private String maTK;
    private String matKhau;

    public LoginRequest() {
        super();
    }

    public LoginRequest(String maTK, String matKhau) {
        super();
        this.maTK = maTK;
        this.matKhau = matKhau;
    }

    public String getMaTK() {
        return maTK;
    }

    public void setMaTK(String maTK) {
        this.maTK = maTK;
    }

    public String getMatKhau() {
        return matKhau;
    }

    public void setMatKhau(String matKhau) {
        this.matKhau = matKhau;
    }
}
