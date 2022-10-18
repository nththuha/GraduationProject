package com.example.nthrestaurant.view.phucvu

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentQLPhieuDatBinding
import com.example.nthrestaurant.view.adapter.PhieuDatAdapter
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class QLPhieuDatFragment : Fragment() {
    private var _binding: FragmentQLPhieuDatBinding ? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

    private var adapter: PhieuDatAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLPhieuDatBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = PhieuDatAdapter {
            viewModel.thietLapPhieuDat(it)

        }
        loadDSPhieuDatKhongHoaDon()
        binding.apply {
            rvPhieuDat.adapter = adapter

            ivThem.setOnClickListener {
                val action = TrangChuPhucVuFragmentDirections.actionTrangChuFragmentToDatChoFragment()
                view.findNavController().navigate(action)
            }

            srPhieuDat.setOnRefreshListener {
                loadDSPhieuDatKhongHoaDon()
                srPhieuDat.isRefreshing = false
            }
        }
    }

    private fun loadDSPhieuDatKhongHoaDon() {
        viewModel.layDSPhieuDatChuaCoHoaDon().observe(viewLifecycleOwner) { dsPhieuDat ->
            dsPhieuDat.let {
                adapter?.submitList(it)
            }
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}