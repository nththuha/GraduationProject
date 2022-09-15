package com.example.nthrestaurant.network

import com.squareup.moshi.Moshi
import com.squareup.moshi.kotlin.reflect.KotlinJsonAdapterFactory
import okhttp3.OkHttpClient
import okhttp3.Protocol
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Retrofit
import retrofit2.converter.moshi.MoshiConverterFactory
import java.util.*
import java.util.concurrent.TimeUnit

private const val BASE_URL =
    "https://api-restaurantmanagement.herokuapp.com/api/"

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
}

object RestaurantApi {
    val retrofitService: RestaurantApiService by lazy { retrofit.create(RestaurantApiService::class.java) }
}