package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemMonAnBinding
import com.example.nthrestaurant.doiIntThanhTien
import com.example.nthrestaurant.network.model.MonAnEntity

class MonAnAdapter(private val clickListener: (MonAnEntity) -> Unit) : ListAdapter<MonAnEntity, MonAnAdapter.MonAnEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MonAnEntityViewHolder {
        val viewHolder = MonAnEntityViewHolder(
            ItemMonAnBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: MonAnEntityViewHolder, position: Int) {
        val monAn = getItem(position)
        holder.bind(monAn)
    }

    class MonAnEntityViewHolder(private var binding: ItemMonAnBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(monAn: MonAnEntity) {
            if (monAn.trangThai == "Hết hàng" || monAn.gia == 0) {
                binding.clMonAn.isEnabled = false
                binding.clMonAn.setBackgroundResource(R.drawable.background_white_monan_unavailable)
                binding.ivSold.visibility = View.VISIBLE
            }
            val money = monAn.gia.doiIntThanhTien()
            binding.tvGia.text = money
            if(monAn.chuThich != null) binding.tvChuThich.text = "Chú thích: " + monAn.chuThich
            binding.monan = monAn
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<MonAnEntity>() {
        override fun areItemsTheSame(oldItem: MonAnEntity, newItem: MonAnEntity): Boolean {
            return oldItem.maMA == newItem.maMA
        }

        override fun areContentsTheSame(oldItem: MonAnEntity, newItem: MonAnEntity): Boolean {
            return oldItem == newItem
        }
    }
}
