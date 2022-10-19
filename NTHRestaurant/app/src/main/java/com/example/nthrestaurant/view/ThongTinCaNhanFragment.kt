package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.FragmentThongTinCaNhanBinding
import com.example.nthrestaurant.dialogDangXuat
import com.example.nthrestaurant.dialogDoiMatKhau
import com.example.nthrestaurant.viewmodel.BepViewModel
import com.example.nthrestaurant.viewmodel.PhaCheViewModel
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class ThongTinCaNhanFragment : Fragment() {
    private var _binding: FragmentThongTinCaNhanBinding? = null
    private val binding get() = _binding!!

    private val vmPhucVu: PhucVuViewModel by activityViewModels()

    private val vmBep: BepViewModel by activityViewModels()

    private val vmPhaChe: PhaCheViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentThongTinCaNhanBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.apply {
            if (vmPhucVu.nhanVien.value != null) {
                nhanVien = vmPhucVu.nhanVien.value
                thietLapBoPhan(vmPhucVu.nhanVien.value?.tenBP.toString())
            } else if (vmBep.nhanVien.value != null) {
                nhanVien = vmBep.nhanVien.value
                thietLapBoPhan(vmBep.nhanVien.value?.tenBP.toString())
            } else {
                nhanVien = vmPhaChe.nhanVien.value
                thietLapBoPhan(vmPhaChe.nhanVien.value?.tenBP.toString())
            }

            btnDoiMatKhau.setOnClickListener {
                if (vmPhucVu.nhanVien.value != null) {
                    dialogDoiMatKhau(requireActivity(), vmPhucVu, vmBep, vmPhaChe)
                } else if (vmBep.nhanVien.value != null) {
                    dialogDoiMatKhau(requireActivity(), vmPhucVu, vmBep, vmPhaChe)
                } else {
                    dialogDoiMatKhau(requireActivity(), vmPhucVu, vmBep, vmPhaChe)
                }
            }

            btnDangXuat.setOnClickListener {
                dialogDangXuat(requireActivity(), view, vmPhucVu, vmBep, vmPhaChe)
            }
        }
    }

    private fun thietLapBoPhan(boPhan: String) {
        binding.apply {
            when (boPhan) {
                "PHUCVU" -> tvBoPhan.text = resources.getString(R.string.bophanphucvu)
                "BOPHANBEP" -> tvBoPhan.text = resources.getString(R.string.bophanbep)
                "BOPHANPHACHE" -> tvBoPhan.text = resources.getString(R.string.bophanphache)
            }
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}