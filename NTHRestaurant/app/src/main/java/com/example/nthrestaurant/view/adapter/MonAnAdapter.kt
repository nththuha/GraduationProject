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
            binding.apply {
                if (monAn.trangThai == "Hết món" || monAn.gia == 0) {
                    clMonAn.isEnabled = false
                    clMonAn.setBackgroundResource(R.drawable.background_white_monan_unavailable)
                    ivSold.visibility = View.VISIBLE
                }
                tvGia.text = monAn.gia.doiIntThanhTien()
                if(monAn.chuThich != null) tvChuThich.text = "Chú thích: " + monAn.chuThich
                monan = monAn
                executePendingBindings()
            }
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
