package com.example.nthrestaurant.view

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.activityViewModels
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.FragmentChiTietDatMonBinding
import com.example.nthrestaurant.databinding.FragmentDatChoBinding
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

class ChiTietDatMonFragment : Fragment() {
    private var _binding: FragmentChiTietDatMonBinding? = null
    private val binding get() = _binding!!

    private val viewModel: PhucVuViewModel by activityViewModels()

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentChiTietDatMonBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}