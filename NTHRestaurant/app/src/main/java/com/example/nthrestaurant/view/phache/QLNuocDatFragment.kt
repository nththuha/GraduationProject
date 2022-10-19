package com.example.nthrestaurant.view.phache

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.databinding.FragmentQLNuocDatBinding
import com.example.nthrestaurant.showToast
import com.example.nthrestaurant.view.adapter.ChiTietNuocDatAdapter
import com.example.nthrestaurant.viewmodel.PhaCheViewModel

class QLNuocDatFragment : Fragment() {
    private var _binding: FragmentQLNuocDatBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhaCheViewModel by activityViewModels()

    private var adapter: ChiTietNuocDatAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLNuocDatBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = ChiTietNuocDatAdapter { it, num ->
            when(num){
                1 -> { //Đang làm
                    if(viewModel.suaTrangThaiDangLam(it)){
                        showToast("Chuyển trạng thái đang được làm")
                        loadDSCTDMBep()
                    }
                    else{
                        showToast("Chuyển trạng thái thất bại!")
                    }
                }
                2 -> { //Chờ phục vụ
                    if(viewModel.suaTrangThaiChoPhucVu(it)){
                        showToast("Chuyển trạng thái chờ được phục vụ")
                        loadDSCTDMBep()
                    }
                    else{
                        showToast("Chuyển trạng thái thất bại!")
                    }
                }
                3 -> { //Hủy món

                }
            }
        }
        loadDSCTDMBep()
        binding.apply {
            rvNuocDat.adapter = adapter
            srNuocDat.setOnRefreshListener {
                loadDSCTDMBep()
                srNuocDat.isRefreshing = false
            }
        }
    }

    private fun loadDSCTDMBep() {
        viewModel.layDSDatMonNuocUong().observe(viewLifecycleOwner) { dsCTDM ->
            adapter?.submitList(dsCTDM)
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}