package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.example.nthrestaurant.databinding.FragmentThongTinCaNhanBinding

class ThongTinCaNhanFragment : Fragment() {
    private var _binding: FragmentThongTinCaNhanBinding? = null
    private val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentThongTinCaNhanBinding.inflate(inflater, container, false)
        return binding.root
    }
}