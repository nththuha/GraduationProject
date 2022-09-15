package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.example.nthrestaurant.databinding.FragmentQLPhongBinding

class QLPhongFragment : Fragment() {
    private var _binding: FragmentQLPhongBinding? = null
    private val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLPhongBinding.inflate(inflater, container, false)
        return binding.root
    }

}