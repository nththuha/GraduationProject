package com.example.nthrestaurant.viewmodel

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.nthrestaurant.network.RestaurantApi
import com.example.nthrestaurant.network.model.ChiTietDatMonEntity
import com.example.nthrestaurant.network.model.NhanVienEntity
import com.example.nthrestaurant.network.model.TaiKhoanEntity
import kotlinx.coroutines.launch
import kotlinx.coroutines.runBlocking

class BepViewModel : ViewModel() {
    var token: String = ""
    var maTK: String = ""

    private val _nhanVien = MutableLiveData<NhanVienEntity?>()
    val nhanVien: LiveData<NhanVienEntity?> = _nhanVien

    private val _dsCTDatMon = MutableLiveData<List<ChiTietDatMonEntity>>()
    val dsCTDatMon: LiveData<List<ChiTietDatMonEntity>> = _dsCTDatMon

    fun thietLapToken(token: String) {
        this.token = token
    }

    fun thietLapMaTK(maTK: String) {
        this.maTK = maTK
    }

    fun resetNhanVien() {
        _nhanVien.value = null
    }

    fun layThongTinNhanVien(maTK: String) {
        viewModelScope.launch {
            try {
                _nhanVien.value =
                    RestaurantApi.retrofitService.layThongTinNhanVienTheoMaTaiKhoan(maTK, token)
            } catch (e: Exception) {
                Log.e("Lấy thông tin nhân viên", e.message.toString())
            }
        }
    }

    fun suaTaiKhoan(taiKhoan: TaiKhoanEntity): Boolean {
        var thongBao = false
        runBlocking {
            try {
                thongBao = RestaurantApi.retrofitService.suaTaiKhoan(taiKhoan, token)
            } catch (e: Exception) {
                Log.e("Lỗi sửa tt ct đặt món", e.message.toString())
            }
        }
        return thongBao;
    }

    fun layDSDatMonMonAn(): LiveData<List<ChiTietDatMonEntity>> {
        viewModelScope.launch {
            try {
                _dsCTDatMon.value = RestaurantApi.retrofitService.layDSDatMonBep(token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds CTDM", e.message.toString())
            }
        }
        return dsCTDatMon
    }

    fun suaTrangThaiDangLam(ctdatmon: ChiTietDatMonEntity): Boolean {
        var thongBao = false
        runBlocking {
            try {
                thongBao = RestaurantApi.retrofitService.suaTrangThaiDangLam(ctdatmon.idCTDM, token)
            } catch (e: Exception) {
                Log.e("Lỗi sửa tt ct đặt món", e.message.toString())
            }
        }
        return thongBao;
    }

    fun suaTrangThaiChoPhucVu(ctdatmon: ChiTietDatMonEntity): Boolean {
        var thongBao = false
        runBlocking {
            try {
                thongBao =
                    RestaurantApi.retrofitService.suaTrangThaiChoPhucVu(ctdatmon.idCTDM, token)
            } catch (e: Exception) {
                Log.e("Lỗi sửa tt ct đặt món", e.message.toString())
            }
        }
        return thongBao;
    }

    fun xoaCTDM(idCTDM: Int): Boolean {
        var thongBao = false
        runBlocking {
            try {
                thongBao = RestaurantApi.retrofitService.xoaCTDM(idCTDM, token)
                layDSDatMonMonAn()
            } catch (e: Exception) {
                Log.e("Lỗi xóa ctdm", e.message.toString())
            }
        }
        return thongBao
    }
}