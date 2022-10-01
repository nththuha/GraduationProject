package com.example.nthrestaurant.viewmodel

import android.icu.lang.UCharacter.GraphemeClusterBreak.L
import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.example.nthrestaurant.network.RestaurantApi
import com.example.nthrestaurant.network.model.*
import kotlinx.coroutines.async
import kotlinx.coroutines.launch

class PhucVuViewModel : ViewModel() {
    var token: String = ""

    private val _nhanVien = MutableLiveData<NhanVienEntity>()
    val nhanVien: LiveData<NhanVienEntity> = _nhanVien

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

    private val _dsLMA = MutableLiveData<List<LoaiMonAnEntity>>()
    val dsLMA: LiveData<List<LoaiMonAnEntity>> = _dsLMA

    private val _loaiMonAn = MutableLiveData<LoaiMonAnEntity>()
    val loaiMonAn: LiveData<LoaiMonAnEntity> = _loaiMonAn

    private val _dsMA = MutableLiveData<List<MonAnEntity>>()
    val dsMA: LiveData<List<MonAnEntity>> = _dsMA

    private val _monAn = MutableLiveData<MonAnEntity>()
    val monAn: LiveData<MonAnEntity> = _monAn

    private val _dsCTDatMon = MutableLiveData<List<ChiTietDatMonEntity>>()
    val dsCTDatMon: LiveData<List<ChiTietDatMonEntity>> = _dsCTDatMon

    private val _dsCTDatMonCPV = MutableLiveData<List<ChiTietDatMonEntity>>()
    val dsCTDatMonCPV: LiveData<List<ChiTietDatMonEntity>> = _dsCTDatMonCPV

    fun thietLapToken(token: String){
        this.token = token
    }

    fun layThongTinNhanVien(maTK: String){
        viewModelScope.launch {
            try {
                _nhanVien.value = RestaurantApi.retrofitService.layThongTinNhanVienTheoMaTaiKhoan(maTK, token)
            }
            catch (e: Exception){
                Log.e("Lấy thông tin nhân viên", e.message.toString())
            }
        }
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

    fun layDSLoaiMonAn(): LiveData<List<LoaiMonAnEntity>> {
        viewModelScope.launch {
            try {
                _dsLMA.value = RestaurantApi.retrofitService.layDSLoaiMonAn(token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds loại món ăn", e.message.toString())
            }
        }
        return dsLMA
    }

    fun thietLapLoaiMonAn(loaiMonAn: LoaiMonAnEntity) {
        this._loaiMonAn.value = loaiMonAn
    }

    fun layDSMonAnTheoLoaiMonAn(): LiveData<List<MonAnEntity>> {
        viewModelScope.launch {
            try {
                _dsMA.value = RestaurantApi.retrofitService.layDSMonAnTheoLoaiMonAn(loaiMonAn.value?.maLMA + "", token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds món ăn", e.message.toString())
            }
        }
        return dsMA
    }

    fun thietLapMonAn(monAn: MonAnEntity) {
        this._monAn.value = monAn
    }

    fun layDSDatMonTheoPD(): LiveData<List<ChiTietDatMonEntity>> {
        viewModelScope.launch {
            try {
                _dsCTDatMon.value = phieuDat.value?.let {
                    RestaurantApi.retrofitService.layDSDatMonTheoPD(it.idPD, token)
                }
            } catch (e: Exception) {
                Log.e("Lỗi load ds CTDM", e.message.toString())
            }
        }
        return dsCTDatMon
    }

    fun layDSDatMonChuaPhucVu(): LiveData<List<ChiTietDatMonEntity>> {
        viewModelScope.launch {
            try {
                _dsCTDatMonCPV.value = RestaurantApi.retrofitService.layDSDatMonChuaPhucVu(token)
            } catch (e: Exception) {
                Log.e("Lỗi load ds CTDM", e.message.toString())
            }
        }
        return dsCTDatMonCPV
    }

    fun themPhieuDat(phieuDat: PhieuDatEntity){
        var temp = ""
        viewModelScope.launch {
            try {
                temp = RestaurantApi.retrofitService.themPhieuDat(phieuDat, token)
            }
            catch (e: Exception){
                Log.e("Lỗi thêm phiếu đặt", e.message.toString())
            }
        }
        if(temp != "false") _phieuDat.value?.idPD = temp.toInt()
    }

    fun suaCTDM(ctdm: ChiTietDatMonEntity){
        viewModelScope.launch {
            try {
                RestaurantApi.retrofitService.suaCTDM(ctdm, token)
            }
            catch (e: Exception){
                Log.e("Lỗi sửa ctdm", e.message.toString())
            }
        }
    }

    fun xoaCTDM(idCTDM: Int): String{
        var thongBao = "false"
        viewModelScope.launch {
            try {
                thongBao = RestaurantApi.retrofitService.xoaCTDM(idCTDM, token)
            }
            catch (e: Exception){
                Log.e("Lỗi xóa ctdm", e.message.toString())
            }
        }
        return thongBao
    }
}