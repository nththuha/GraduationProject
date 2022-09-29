package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class BanEntity(
    @Json(name = "maBan") val maBan: String,
    @Json(name = "soGhe") val soGhe: Int,
    @Json(name = "tenBan") val tenBan: String,
    @Json(name = "trangThai") val trangThai: String
)