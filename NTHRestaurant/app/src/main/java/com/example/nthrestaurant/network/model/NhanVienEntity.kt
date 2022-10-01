package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class NhanVienEntity(
    @Json(name = "diaChi") val diaChi: String,
    @Json(name = "email") val email: String,
    @Json(name = "hoTen") val hoTen: String,
    @Json(name = "idNV") val idNV: Int,
    @Json(name = "maBP") val maBP: String,
    @Json(name = "sdt") val sdt: String,
    @Json(name = "taiKhoan") val taiKhoan: String,
    @Json(name = "tenBP") val tenBP: String
)