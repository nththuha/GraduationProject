package com.example.nthrestaurant.view.bep

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentQLMonDatBinding
import com.example.nthrestaurant.dialogChinhSuaDatMon
import com.example.nthrestaurant.dialogHuyChiTietDatMon
import com.example.nthrestaurant.view.adapter.ChiTietDatMonAdapter
import com.example.nthrestaurant.view.adapter.ChiTietMonDatAdapter
import com.example.nthrestaurant.view.phucvu.ChiTietDatMonFragmentDirections
import com.example.nthrestaurant.viewmodel.BepViewModel
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

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
            when(num){
                1 -> {

                }
                2 -> {

                }
                3 -> {

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