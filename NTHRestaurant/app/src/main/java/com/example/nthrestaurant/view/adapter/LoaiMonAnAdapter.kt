package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemLoaiMonAnBinding
import com.example.nthrestaurant.network.model.LoaiMonAnEntity

class LoaiMonAnAdapter(private val clickListener: (LoaiMonAnEntity) -> Unit) :
    ListAdapter<LoaiMonAnEntity, LoaiMonAnAdapter.LoaiMonAnEntityViewHolder>(DiffCallback) {

    var row: Int = -1

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): LoaiMonAnEntityViewHolder {
        val viewHolder = LoaiMonAnEntityViewHolder(
            ItemLoaiMonAnBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            row = position
            notifyDataSetChanged()
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: LoaiMonAnEntityViewHolder, position: Int) {
        val loaiMonAn = getItem(position)
        holder.bind(loaiMonAn, position, row)
    }

    class LoaiMonAnEntityViewHolder(private var binding: ItemLoaiMonAnBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(loaiMonAn: LoaiMonAnEntity, position: Int, row: Int) {
            binding.apply {
                loaimonan = loaiMonAn
                if (position == row) {
                    clLoaiMonAn.setBackgroundResource(R.drawable.background_white_loaimonan_click_true)
                } else {
                    clLoaiMonAn.setBackgroundResource(R.drawable.background_white_loaimonan)
                }
                executePendingBindings()
            }
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