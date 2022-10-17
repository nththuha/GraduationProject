package com.example.nthrestaurant.network

import com.example.nthrestaurant.network.model.*
import com.squareup.moshi.Moshi
import com.squareup.moshi.kotlin.reflect.KotlinJsonAdapterFactory
import okhttp3.OkHttpClient
import okhttp3.Protocol
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Retrofit
import retrofit2.converter.moshi.MoshiConverterFactory
import retrofit2.http.*
import java.util.*
import java.util.concurrent.TimeUnit

private const val BASE_URL =
    "https://nth-restaurant-api.herokuapp.com/api/"

private val moshi = Moshi.Builder()
    .add(KotlinJsonAdapterFactory())
    .build()

private val retrofit = Retrofit.Builder()
    .addConverterFactory(MoshiConverterFactory.create(moshi))
    .baseUrl(BASE_URL)
    .client(OkHttpClient().newBuilder().also { client ->
        val loggingInterceptor = HttpLoggingInterceptor()
        loggingInterceptor.setLevel(HttpLoggingInterceptor.Level.BODY)
        client.addNetworkInterceptor(loggingInterceptor)
        client.connectTimeout(120, TimeUnit.SECONDS)
        client.writeTimeout(120, TimeUnit.SECONDS)
        client.protocols(Collections.singletonList(Protocol.HTTP_1_1))
    }.build())
    .build()

interface RestaurantApiService {
    @POST("taikhoan/dangnhap")
    suspend fun dangNhap(@Body taiKhoan: TaiKhoanEntity): Token

    @GET("nhanvien/{maTK}")
    suspend fun layThongTinNhanVienTheoMaTaiKhoan(@Path("maTK") maTK: String, @Header("Authorization") token: String): NhanVienEntity

    @GET("phieudat")
    suspend fun layDSPhieuDatChuaCoHoaDon(@Header("Authorization") token: String): List<PhieuDatEntity>

    @POST("phieudat")
    suspend fun themPhieuDat(@Body phieuDat: PhieuDatEntity,  @Header("Authorization") token: String): String

    @GET("phong")
    suspend fun layDSPhong(@Header("Authorization") token: String): List<PhongEntity>

    @GET("ctban/{maPhong}")
    suspend fun layDSBanTheoPhong(@Path("maPhong") maPhong: String, @Header("Authorization") token: String): List<BanEntity>

    @GET("loaimonan")
    suspend fun layDSLoaiMonAn( @Header("Authorization") token: String): List<LoaiMonAnEntity>

    @GET("loaimonan/{maLMA}")
    suspend fun layDSMonAnTheoLoaiMonAn(@Path("maLMA") maLMA: String, @Header("Authorization") token: String): List<MonAnEntity>

    @GET("ctdatmon/{idpd}")
    suspend fun layDSDatMonTheoPD(@Path("idpd") idpd: Int, @Header("Authorization") token: String): List<ChiTietDatMonEntity>

    @GET("ctdatmon/phucvu/monan")
    suspend fun layDSDatMonChuaPhucVu(@Header("Authorization") token: String): List<ChiTietDatMonEntity>

    @DELETE("ctdatmon/{idCTDM}")
    suspend fun xoaCTDM(@Path("idCTDM") idCTDM: Int, @Header("Authorization") token: String): Boolean

    @PUT("ctdatmon")
    suspend fun suaCTDM(@Body ctdm: ChiTietDatMonEntity, @Header("Authorization") token: String): String

    @POST("ctdatmon")
    suspend fun themCTDatMon(@Body ctdatmon: ChiTietDatMonEntity, @Header("Authorization") token: String): Boolean
}

object RestaurantApi {
    val retrofitService: RestaurantApiService by lazy { retrofit.create(RestaurantApiService::class.java) }
}