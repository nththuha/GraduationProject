package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemPhongBinding
import com.example.nthrestaurant.network.model.PhongEntity

class PhongAdapter(private val clickListener: (PhongEntity) -> Unit) : ListAdapter<PhongEntity, PhongAdapter.PhongEntityViewHolder>(DiffCallback) {

    class PhongEntityViewHolder(private var binding: ItemPhongBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(phong: PhongEntity) {
            binding.apply {
                binding.phong = phong
                if(phong.trangThai == "Hết chỗ"){
                    clPhong.setBackgroundResource(R.drawable.background_room_unavailable)
                    clPhong.isEnabled = false;
                }

                executePendingBindings()
            }
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): PhongEntityViewHolder {
        val viewHolder = PhongEntityViewHolder(
            ItemPhongBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: PhongEntityViewHolder, position: Int) {
        val phong = getItem(position)
        holder.bind(phong)
    }

    companion object DiffCallback : DiffUtil.ItemCallback<PhongEntity>() {
        override fun areItemsTheSame(oldItem: PhongEntity, newItem: PhongEntity): Boolean {
            return oldItem.maPhong == newItem.maPhong
        }

        override fun areContentsTheSame(oldItem: PhongEntity, newItem: PhongEntity): Boolean {
            return oldItem == newItem
        }
    }
}