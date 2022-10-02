package com.example.nthrestaurant.view

import android.os.Bundle
import android.util.Log
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.FragmentChiTietDatMonBinding
import com.example.nthrestaurant.databinding.FragmentDatChoBinding
import com.example.nthrestaurant.dialogChinhSuaDatMon
import com.example.nthrestaurant.dialogHuyChiTietDatMon
import com.example.nthrestaurant.showToast
import com.example.nthrestaurant.view.adapter.ChiTietDatMonAdapter
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class ChiTietDatMonFragment : Fragment() {
    private var _binding: FragmentChiTietDatMonBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

    private var adapter: ChiTietDatMonAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentChiTietDatMonBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = ChiTietDatMonAdapter { it, num ->
            when(num){
                1 -> { //Cập nhật thông tin món ăn
                    dialogChinhSuaDatMon(requireActivity(), it)
                }
                2 -> { //Hủy món ăn đã đặt
                    dialogHuyChiTietDatMon(requireActivity(), it, viewModel)
                    loadDSCTDM()
                }
            }
        }
        loadDSCTDM()
        binding.rvChiTietDatMon.adapter = adapter
        binding.srChiTietDatMon.setOnRefreshListener {
            loadDSCTDM()
            binding.srChiTietDatMon.isRefreshing = false
        }
    }

    fun loadDSCTDM() {
        viewModel.layDSDatMonTheoPD().observe(viewLifecycleOwner) { dsCTDM ->
            adapter?.submitList(dsCTDM)
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}