package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.databinding.ItemLoaiMonAnBinding
import com.example.nthrestaurant.network.model.LoaiMonAnEntity

class LoaiMonAnAdapter(private val clickListener: (LoaiMonAnEntity) -> Unit) :
    ListAdapter<LoaiMonAnEntity, LoaiMonAnAdapter.LoaiMonAnEntityViewHolder>(DiffCallback) {
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): LoaiMonAnEntityViewHolder {
        val viewHolder = LoaiMonAnEntityViewHolder(
            ItemLoaiMonAnBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: LoaiMonAnEntityViewHolder, position: Int) {
        val loaiMonAn = getItem(position)
        holder.bind(loaiMonAn)
    }

    class LoaiMonAnEntityViewHolder(private var binding: ItemLoaiMonAnBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(loaiMonAn: LoaiMonAnEntity) {
            binding.loaimonan = loaiMonAn
            binding.executePendingBindings()
        }
    }

    companion object DiffCallback : DiffUtil.ItemCallback<LoaiMonAnEntity>() {
        override fun areItemsTheSame(oldItem: LoaiMonAnEntity, newItem: LoaiMonAnEntity): Boolean {
            return oldItem.maLMA == newItem.maLMA
        }

        override fun areContentsTheSame(
            oldItem: LoaiMonAnEntity,
            newItem: LoaiMonAnEntity
        ): Boolean {
            return oldItem == newItem
        }
    }
}