package com.example.nthrestaurant.view.bep

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.viewpager2.widget.ViewPager2
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.FragmentTrangChuBepBinding
import com.example.nthrestaurant.databinding.FragmentTrangChuPhucVuBinding
import com.example.nthrestaurant.view.ThongTinCaNhanFragment
import com.example.nthrestaurant.view.adapter.ViewPagerAdapter
import com.example.nthrestaurant.view.phucvu.QLMonFragment
import com.example.nthrestaurant.view.phucvu.QLPhieuDatFragment

class TrangChuBepFragment : Fragment() {
    private var _binding: FragmentTrangChuBepBinding? = null
    private val binding get() = _binding!!

    private lateinit var viewPager: ViewPager2
    private lateinit var viewPagerAdapter: ViewPagerAdapter

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentTrangChuBepBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)
        setUpViewPager()

        binding.apply {
            ivChucNang.setImageResource(R.drawable.ic_home_50_click_true)
            ivChucNang.setOnClickListener {
                viewPager.currentItem = 0
                ivChucNang.setImageResource(R.drawable.ic_home_50_click_true)
                ivTTCaNhan.setImageResource(R.drawable.ic_person_50)
            }
            ivTTCaNhan.setOnClickListener {
                viewPager.currentItem = 3
                ivChucNang.setImageResource(R.drawable.ic_home_50)
                ivTTCaNhan.setImageResource(R.drawable.ic_person_50_click_true)
            }
        }
    }

    private fun setUpViewPager() {
        viewPager = binding.vpTrangChu
        val listFragment =
            arrayListOf(QLMonDatFragment(), ThongTinCaNhanFragment())
        viewPagerAdapter = ViewPagerAdapter(
            listFragment,
            requireActivity().supportFragmentManager,
            lifecycle
        )
        viewPager.adapter = viewPagerAdapter
        viewPager.isUserInputEnabled = false
    }

    override fun onDestroy() {
        super.onDestroy()
        _binding = null
    }
}