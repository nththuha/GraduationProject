package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class ChiTietDatMonEntity(
    @Json(name = "chuThich") val chuThich: String?,
    @Json(name = "gia") val gia: Int,
    @Json(name = "giaTungMon") val giaTungMon: Int,
    @Json(name = "hinhAnh") val hinhAnh: String,
    @Json(name = "idCTDM") val idCTDM: Int,
    @Json(name = "idpd") val idPD: Int,
    @Json(name = "malma") val maLMA: String,
    @Json(name = "mama") val maMA: String,
    @Json(name = "soLuong") val soLuong: Int,
    @Json(name = "tenBan") val tenBan: String?,
    @Json(name = "tenPhong") val tenPhong: String?,
    @Json(name = "tenma") val tenMA: String,
    @Json(name = "trangThai") val trangThai: String
)