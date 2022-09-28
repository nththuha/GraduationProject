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

    private val _phieuDat = MutableLiveData<PhieuDatEntity>()
    val phieuDat: LiveData<PhieuDatEntity> = _phieuDat

    fun thietLapToken(token: String){
        this.token = token
    }

    fun thietLapPhieuDat(phieuDat: PhieuDatEntity){
        this._phieuDat.value = phieuDat
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