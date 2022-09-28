package com.example.nthrestaurant.network.model

import com.squareup.moshi.Json

data class Token(
    @Json(name = "maTK") val maTK: String,
    @Json(name = "roles") val roles: String,
    @Json(name = "token") val token: String,
    @Json(name = "type") val type: String
)