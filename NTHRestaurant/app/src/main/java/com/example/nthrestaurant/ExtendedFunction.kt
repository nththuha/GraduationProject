package com.example.nthrestaurant

import android.app.Activity
import android.widget.Toast
import androidx.fragment.app.Fragment
import java.text.DecimalFormat

fun Int.doiIntThanhTien(): String {
    val dec = DecimalFormat("#,###.##")
    return dec.format(this) + " VND"
}

fun Fragment.showToast(s: String){
    Toast.makeText(this.context, s, Toast.LENGTH_SHORT).show()
}

fun Activity.showToast(s: String){
    Toast.makeText(this, s, Toast.LENGTH_SHORT).show()
}