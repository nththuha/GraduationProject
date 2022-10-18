package com.example.nthrestaurant.view.phucvu

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.fragment.app.activityViewModels
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentDatMonBinding
import com.example.nthrestaurant.dialogDatMon
import com.example.nthrestaurant.view.adapter.LoaiMonAnAdapter
import com.example.nthrestaurant.view.adapter.MonAnAdapter
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class DatMonFragment : Fragment() {
    private var _binding: FragmentDatMonBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

    private var adapterLMA: LoaiMonAnAdapter? = null
    private var adapterMA: MonAnAdapter? = null

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentDatMonBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        adapterLMA = LoaiMonAnAdapter{
            viewModel.thietLapLoaiMonAn(it)
            loadDSMonAn()
            binding.rvMonAn.adapter = adapterMA
        }
        loadDSLoaiMonAn()
        binding.apply {
            rvLoaiMonAn.adapter = adapterLMA
            rvMonAn.adapter = adapterMA

            srLoaiMonAn.setOnRefreshListener {
                loadDSLoaiMonAn()
                srLoaiMonAn.isRefreshing = false
            }
            srMonAn.setOnRefreshListener {
                loadDSMonAn()
                srMonAn.isRefreshing = false
            }

            ivBack.setOnClickListener {
                val action = DatMonFragmentDirections.actionDatMonFragmentToTrangChuFragment()
                view.findNavController().navigate(action)
            }
        }
        adapterMA = MonAnAdapter{
            viewModel.thietLapMonAn(it)
            dialogDatMon(requireActivity(), it, viewModel)
        }
    }

    private fun loadDSLoaiMonAn() {
        viewModel.layDSLoaiMonAn().observe(viewLifecycleOwner) { dsLMA ->
            dsLMA.let {
                adapterLMA?.submitList(dsLMA)
            }
        }
    }

    private fun loadDSMonAn() {
        viewModel.layDSMonAnTheoLoaiMonAn().observe(viewLifecycleOwner) { dsMA ->
            dsMA.let {
                adapterMA?.submitList(dsMA)
            }
        }
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}