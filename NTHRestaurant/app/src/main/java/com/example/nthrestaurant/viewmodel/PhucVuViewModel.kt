package com.example.nthrestaurant.viewmodel

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.nthrestaurant.network.RestaurantApi
import com.example.nthrestaurant.network.model.PhieuDatEntity
import kotlinx.coroutines.launch

class PhucVuViewModel : ViewModel() {
    var token: String = ""

    private val _dsPhieuDat = MutableLiveData<List<PhieuDatEntity>>()
    val dsPhieuDat: LiveData<List<PhieuDatEntity>> = _dsPhieuDat

    fun thietLapToken(token: String){
        this.token = token
    }

    fun layDSPhieuDatChuaCoHoaDon(): LiveData<List<PhieuDatEntity>> {
        viewModelScope.launch {
            try {
                _dsPhieuDat.value = RestaurantApi.retrofitService.layDSPhieuDatChuaCoHoaDon(token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds phiếu đặt", e.message.toString())
            }
        }
        return dsPhieuDat
    }

}