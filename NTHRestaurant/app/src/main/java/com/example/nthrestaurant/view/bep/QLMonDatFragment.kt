package com.example.nthrestaurant.view.bep

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.databinding.FragmentQLMonDatBinding
import com.example.nthrestaurant.dialogHuyChiTietDatMonBPC
import com.example.nthrestaurant.showToast
import com.example.nthrestaurant.view.adapter.ChiTietMonDatAdapter
import com.example.nthrestaurant.viewmodel.BepViewModel
import com.example.nthrestaurant.viewmodel.PhaCheViewModel
import kotlinx.coroutines.Job
import kotlinx.coroutines.MainScope
import kotlinx.coroutines.delay
import kotlinx.coroutines.launch

class QLMonDatFragment : Fragment() {
    private var _binding: FragmentQLMonDatBinding? = null
    private val binding get() = _binding!!

    private val viewModel: BepViewModel by activityViewModels()

    private var adapter: ChiTietMonDatAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLMonDatBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapter = ChiTietMonDatAdapter { it, num ->
            when (num) {
                1 -> { //Đang làm
                    if (viewModel.suaTrangThaiDangLam(it)) {
                        showToast("Chuyển trạng thái đang được làm")
                        loadDSCTDMBep()
                    } else {
                        showToast("Chuyển trạng thái thất bại!")
                    }
                }
                2 -> { //Chờ phục vụ
                    if (viewModel.suaTrangThaiChoPhucVu(it)) {
                        showToast("Chuyển trạng thái chờ được phục vụ")
                        loadDSCTDMBep()
                    } else {
                        showToast("Chuyển trạng thái thất bại!")
                    }
                }
                3 -> { //Hủy món
                    dialogHuyChiTietDatMonBPC(requireActivity(), it, viewModel, PhaCheViewModel())
                }
            }
        }
        loadDSCTDMBep()
        binding.apply {
            rvMonDat.adapter = adapter
            srMonDat.setOnRefreshListener {
                loadDSCTDMBep()
                srMonDat.isRefreshing = false
            }
        }
        val scope = MainScope() // could also use an other scope such as viewModelScope if available
        var job: Job? = null
        job = scope.launch {
            while(true) {
                loadDSCTDMBep() // the function that should be ran every second
                delay(5000)
            }
        }
    }

    private fun loadDSCTDMBep() {
        viewModel.layDSDatMonMonAn().observe(viewLifecycleOwner) { dsCTDM ->
            adapter?.submitList(dsCTDM)
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}