package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class PhieuDatEntity(
    @Json(name = "hoTenKH") val hoTenKH: String?,
    @Json(name = "hoTenNV") val hoTenNV: String,
    @Json(name = "idPD") val idPD: Int,
    @Json(name = "idkh") val idkh: Int?,
    @Json(name = "idnv") val idnv: Int,
    @Json(name = "maBan") val maBan: String,
    @Json(name = "maPhong") val maPhong: String,
    @Json(name = "ngay") val ngay: String,
    @Json(name = "tenBan") val tenBan: String,
    @Json(name = "tenPhong") val tenPhong: String
)