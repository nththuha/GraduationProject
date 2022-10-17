package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.databinding.FragmentThongTinCaNhanBinding
import com.example.nthrestaurant.dialogDangXuat
import com.example.nthrestaurant.dialogDoiMatKhau
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class ThongTinCaNhanFragment : Fragment() {
    private var _binding: FragmentThongTinCaNhanBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

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
            nhanVien = viewModel.nhanVien.value

            when(viewModel.nhanVien.value?.tenBP){
                "PHUCVU" -> tvBoPhan.text = "NHÂN VIÊN PHỤC VỤ"
                "BOPHANBEP" -> tvBoPhan.text = "NHÂN VIÊN BỘ PHẬN BẾP"
                "BOPHANPHACHE" -> tvBoPhan.text = "NHÂN VIÊN BỘ PHẬN PHA CHẾ"
            }

            btnDoiMatKhau.setOnClickListener{
                dialogDoiMatKhau(requireActivity(), view, viewModel)
            }

            btnDangXuat.setOnClickListener {
                dialogDangXuat(requireActivity(), view)
            }
        }
    }


    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}