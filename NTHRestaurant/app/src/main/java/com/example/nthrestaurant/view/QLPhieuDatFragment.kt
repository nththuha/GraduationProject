package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.example.nthrestaurant.databinding.FragmentQLPhieuDatBinding
import com.example.nthrestaurant.dialogDangXuat
import com.example.nthrestaurant.dialogThatBai

class QLPhieuDatFragment : Fragment() {
    private var _binding: FragmentQLPhieuDatBinding ? = null
    private val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLPhieuDatBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        //dialogDangXuat(requireActivity())
    }
}