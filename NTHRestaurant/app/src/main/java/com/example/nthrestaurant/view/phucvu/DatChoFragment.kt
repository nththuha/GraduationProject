package com.example.nthrestaurant.view.phucvu

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentDatChoBinding
import com.example.nthrestaurant.network.model.PhieuDatEntity
import com.example.nthrestaurant.showToast
import com.example.nthrestaurant.view.adapter.BanAdapter
import com.example.nthrestaurant.view.adapter.PhongAdapter
import com.example.nthrestaurant.viewmodel.PhucVuViewModel
import java.text.SimpleDateFormat
import java.util.*

class DatChoFragment : Fragment() {
    private var _binding: FragmentDatChoBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

    private var adapterP: PhongAdapter? = null
    private var adapterB: BanAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentDatChoBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        adapterP = PhongAdapter {
            viewModel.thietLapPhong(it)
            loadDSBan()
            binding.rvBan.adapter = adapterB
        }
        loadDSPhong()
        binding.apply {
            rvPhong.adapter = adapterP
            srPhong.setOnRefreshListener {
                loadDSPhong()
                srPhong.isRefreshing = false
            }
            rvBan.adapter = adapterB
            srBan.setOnRefreshListener {
                loadDSBan()
                srBan.isRefreshing = false
            }

            ivBack.setOnClickListener {
                val action = DatChoFragmentDirections.actionDatChoFragmentToTrangChuFragment()
                view.findNavController().navigate(action)
            }
        }

        adapterB = BanAdapter {
            viewModel.thietLapBan(it)

            val idnv = viewModel.nhanVien.value?.idNV
            val maBan = viewModel.ban.value?.maBan
            val maPhong = viewModel.phong.value?.maPhong
            val sdf = SimpleDateFormat("yyyy-MM-dd")
            val ngay = sdf.format(Date())

            val phieuDat = PhieuDatEntity(null, null, -5, -5, idnv!!, maBan!!, maPhong!!, ngay, null, null)

            viewModel.themPhieuDat(phieuDat)
            showToast("Đặt bàn thành công")
            val action = DatChoFragmentDirections.actionDatChoFragmentToDatMonFragment()
            view.findNavController().navigate(action)

        }
    }

    private fun loadDSPhong() {
        viewModel.layDSPhong().observe(viewLifecycleOwner) { dsPhong ->
            dsPhong.let {
                adapterP?.submitList(dsPhong)
            }
        }
    }

    private fun loadDSBan() {
        viewModel.layDSBanTheoPhong().observe(viewLifecycleOwner) { dsBan ->
            dsBan.let {
                adapterB?.submitList(dsBan)
            }
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}