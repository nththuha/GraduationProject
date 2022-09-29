package com.example.nthrestaurant.viewmodel

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.nthrestaurant.network.RestaurantApi
import com.example.nthrestaurant.network.model.BanEntity
import com.example.nthrestaurant.network.model.PhieuDatEntity
import com.example.nthrestaurant.network.model.PhongEntity
import kotlinx.coroutines.launch

class PhucVuViewModel : ViewModel() {
    var token: String = ""

    private val _dsPhieuDat = MutableLiveData<List<PhieuDatEntity>>()
    val dsPhieuDat: LiveData<List<PhieuDatEntity>> = _dsPhieuDat

    private val _phieuDat = MutableLiveData<PhieuDatEntity>()
    val phieuDat: LiveData<PhieuDatEntity> = _phieuDat

    private val _dsPhong = MutableLiveData<List<PhongEntity>>()
    val dsPhong: LiveData<List<PhongEntity>> = _dsPhong

    private val _phong = MutableLiveData<PhongEntity>()
    val phong: LiveData<PhongEntity> = _phong

    private val _dsBan = MutableLiveData<List<BanEntity>>()
    val dsBan: LiveData<List<BanEntity>> = _dsBan

    private val _ban = MutableLiveData<BanEntity>()
    val ban: LiveData<BanEntity> = _ban

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

    fun layDSPhong(): LiveData<List<PhongEntity>> {
        viewModelScope.launch {
            try {
                _dsPhong.value = RestaurantApi.retrofitService.layDSPhong(token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds phòng", e.message.toString())
            }
        }
        return dsPhong
    }

    fun thietLapPhong(phong: PhongEntity){
        this._phong.value = phong
    }

    fun layDSBanTheoPhong(): LiveData<List<BanEntity>> {
        viewModelScope.launch {
            try {
                _dsBan.value = RestaurantApi.retrofitService.layDSBanTheoPhong(phong.value?.maPhong + "", token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds bàn", e.message.toString())
            }
        }
        return dsBan
    }

    fun thietLapBan(ban: BanEntity){
        this._ban.value = ban
    }
}