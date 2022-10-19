package com.example.nthrestaurant.view.phucvu

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.databinding.FragmentQLMonBinding
import com.example.nthrestaurant.showToast
import com.example.nthrestaurant.view.adapter.ChiTietDatMonChuaPhucVuAdapter
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class QLMonFragment : Fragment() {
    private var _binding: FragmentQLMonBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

    private var adapter: ChiTietDatMonChuaPhucVuAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLMonBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = ChiTietDatMonChuaPhucVuAdapter {
            if (viewModel.suaTrangThaiDaPhucVu(it)) {
                showToast("Phục vụ món ăn thành công!")
                loadDSCTDM()
            } else showToast("Phục vụ món ăn thất bại!")
        }
        loadDSCTDM()
        binding.rvMonChoPV.adapter = adapter
        binding.srMonChoPV.setOnRefreshListener {
            loadDSCTDM()
            binding.srMonChoPV.isRefreshing = false
        }
    }

    private fun loadDSCTDM() {
        viewModel.layDSDatMonChuaPhucVu().observe(viewLifecycleOwner) { dsCTDM ->
            adapter?.submitList(dsCTDM)
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}