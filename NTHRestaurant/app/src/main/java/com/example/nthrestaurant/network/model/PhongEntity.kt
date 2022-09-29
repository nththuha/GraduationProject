package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class PhongEntity(
    @Json(name = "maPhong") val maPhong: String,
    @Json(name = "tenPhong") val tenPhong: String,
    @Json(name = "trangThai") val trangThai: String
)