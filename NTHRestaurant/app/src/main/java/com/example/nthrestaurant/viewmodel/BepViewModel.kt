package com.example.nthrestaurant.viewmodel

import androidx.lifecycle.ViewModel

class BepViewModel: ViewModel() {
    var token: String = ""

    fun thietLapToken(token: String){
        this.token = token
    }
}