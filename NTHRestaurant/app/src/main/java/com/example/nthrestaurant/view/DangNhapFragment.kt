package com.example.nthrestaurant.view

import android.os.Bundle
import android.util.Log
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentDangNhapBinding
import com.example.nthrestaurant.dialogThatBai
import com.example.nthrestaurant.network.RestaurantApi
import com.example.nthrestaurant.network.model.TaiKhoanEntity
import com.example.nthrestaurant.network.model.Token
import com.example.nthrestaurant.viewmodel.BepViewModel
import com.example.nthrestaurant.viewmodel.PhaCheViewModel
import com.example.nthrestaurant.viewmodel.PhucVuViewModel
import kotlinx.coroutines.runBlocking

class DangNhapFragment : Fragment() {
    private var _binding: FragmentDangNhapBinding? = null
    private val binding get() = _binding!!

    private val vmPhucVu: PhucVuViewModel by activityViewModels()

    private val vmBep: BepViewModel by activityViewModels()

    private val vmPhaChe: PhaCheViewModel by activityViewModels()

    private var token = Token("", "", "", "")

    companion object {
        const val ADMIN: String = "ADMIN"
        const val PHUCVU: String = "PHUCVU"
        const val BOPHANBEP: String = "BOPHANBEP"
        const val BOPHANPHACHE: String = "BOPHANPHACHE"
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentDangNhapBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        binding.apply {
            btnDangNhap.setOnClickListener {
                btnDangNhap.isClickable = false
                pbLogin.visibility = View.VISIBLE
                val maTK = etTenDangNhap.text.toString().trim()
                val matKhau = etMatKhau.text.toString().trim()
                if (maTK == "" || matKhau == "") {
                    dialogThatBai( requireActivity(), "Tên đăng nhập và mật khẩu không được để trống!")
                }
                else{
                    runBlocking {
                        try {
                            token = RestaurantApi.retrofitService.dangNhap(TaiKhoanEntity(maTK, matKhau))
                        } catch (e: Exception) {
                            Log.e("Fragment đăng nhập", e.message.toString())
                        }
                    }

                    when (token.roles) {
                        PHUCVU -> {
                            vmPhucVu.thietLapToken(token.token)
                            val action = DangNhapFragmentDirections.actionDangNhapFragmentToTrangChuFragment()
                            view.findNavController().navigate(action)
                        }
                        BOPHANBEP -> {
                            vmPhucVu.thietLapToken(token.token)
                            //DO SOMETHING
                        }
                        BOPHANPHACHE -> {
                            vmPhucVu.thietLapToken(token.token)
                            //DO SOMETHING
                        }
                        else -> {
                            dialogThatBai( requireActivity(), "Tên đăng nhập và mật khẩu không đúng!")
                        }
                    }
                    btnDangNhap.isClickable = true
                    pbLogin.visibility = View.GONE
                }
            }
        }
    }
}