package com.example.nthrestaurant.view

import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.Fragment
import androidx.viewpager2.widget.ViewPager2
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.FragmentTrangChuBinding
import com.example.nthrestaurant.view.adapter.ViewPagerAdapter

class TrangChuFragment : Fragment() {
    private var _binding: FragmentTrangChuBinding? = null
    private val binding get() = _binding!!

    private lateinit var viewPager: ViewPager2
    private lateinit var viewPagerAdapter: ViewPagerAdapter

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        _binding = FragmentTrangChuBinding.inflate(inflater, container, false)
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
                ivQLMon.setImageResource(R.drawable.ic_fastfood_50)
                ivTTCaNhan.setImageResource(R.drawable.ic_person_50)
            }
            ivQLMon.setOnClickListener {
                viewPager.currentItem = 1
                ivChucNang.setImageResource(R.drawable.ic_home_50)
                ivQLMon.setImageResource(R.drawable.ic_fastfood_50_click_true)
                ivTTCaNhan.setImageResource(R.drawable.ic_person_50)
            }
            ivTTCaNhan.setOnClickListener {
                viewPager.currentItem = 3
                ivChucNang.setImageResource(R.drawable.ic_home_50)
                ivQLMon.setImageResource(R.drawable.ic_fastfood_50)
                ivTTCaNhan.setImageResource(R.drawable.ic_person_50_click_true)
            }
        }
    }

    private fun setUpViewPager() {
        viewPager = binding.vpTrangChu
        val listFragment =
            arrayListOf(QLPhieuDatFragment(), QLMonFragment(), ThongTinCaNhanFragment())
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