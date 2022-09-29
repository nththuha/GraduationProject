package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class MonAnEntity(
    @Json(name = "chuThich") val chuThich: String?,
    @Json(name = "gia") val gia: Int,
    @Json(name = "hinhAnh") val hinhAnh: String,
    @Json(name = "maMA") val maMA: String,
    @Json(name = "malma") val maLMA: String,
    @Json(name = "tenMA") val tenMA: String,
    @Json(name = "tenlma") val tenLMA: String,
    @Json(name = "trangThai") val trangThai: String
)