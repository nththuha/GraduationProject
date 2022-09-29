package com.example.nthrestaurant

import java.text.DecimalFormat

fun Int.doiIntThanhTien(): String {
    val dec = DecimalFormat("#,###.##")
    return dec.format(this) + " VND"
}