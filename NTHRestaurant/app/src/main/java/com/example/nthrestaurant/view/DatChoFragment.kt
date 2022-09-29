package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentDatChoBinding
import com.example.nthrestaurant.view.adapter.BanAdapter
import com.example.nthrestaurant.view.adapter.PhongAdapter
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

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
        }

        adapterB = BanAdapter {
            viewModel.thietLapBan(it)

            //THÊM PHIẾU ĐẶT VÀ THÊM CHI TIẾT ĐẶT BÀN

            Toast.makeText(context, "Successfully", Toast.LENGTH_SHORT).show()
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