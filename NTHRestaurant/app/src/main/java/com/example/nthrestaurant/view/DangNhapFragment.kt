package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.navigation.findNavController
import com.example.nthrestaurant.databinding.FragmentDangNhapBinding

class DangNhapFragment : Fragment() {
    private var _binding: FragmentDangNhapBinding? = null
    private val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentDangNhapBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        binding.btnDangNhap.setOnClickListener {
            val action = DangNhapFragmentDirections.actionDangNhapFragmentToTrangChuFragment()
            view.findNavController().navigate(action)
        }
    }
}