package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import com.example.nthrestaurant.databinding.FragmentQLMonBinding

class QLMonFragment : Fragment() {
    private var _binding: FragmentQLMonBinding? = null
    private val binding get() = _binding!!

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentQLMonBinding.inflate(inflater, container, false)
        return binding.root
    }

}