package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class PhongNgay(
    @Json(name = "maPhong") val maPhong: String,
    @Json(name = "ngay") val ngay: String,
    @Json(name = "gio") val gio: Int?
)