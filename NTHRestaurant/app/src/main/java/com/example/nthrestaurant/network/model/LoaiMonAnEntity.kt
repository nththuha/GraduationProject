package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class LoaiMonAnEntity(
    @Json(name = "hinhAnh") val hinhAnh: String,
    @Json(name = "maLMA") val maLMA: String,
    @Json(name = "tenLMA") val tenLMA: String
)