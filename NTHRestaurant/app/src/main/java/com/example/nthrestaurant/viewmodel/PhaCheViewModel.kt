package com.example.nthrestaurant.viewmodel

import androidx.lifecycle.ViewModel

class PhaCheViewModel : ViewModel() {
    var token: String = ""

    fun thietLapToken(token: String){
        this.token = token
    }
}