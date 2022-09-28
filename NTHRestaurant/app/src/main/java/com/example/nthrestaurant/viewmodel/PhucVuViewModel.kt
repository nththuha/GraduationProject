package com.example.nthrestaurant.viewmodel

import android.util.Log
import android.widget.Toast
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.nthrestaurant.network.RestaurantApi
import com.example.nthrestaurant.network.model.TaiKhoanEntity
import com.example.nthrestaurant.network.model.Token
import kotlinx.coroutines.async
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class PhucVuViewModel : ViewModel() {
    var token: String = ""

    fun thietLapToken(token: String){
        this.token = token
    }

}