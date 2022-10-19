package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemBanBinding
import com.example.nthrestaurant.network.model.BanEntity

class BanAdapter(private val clickListener: (BanEntity) -> Unit) :
    ListAdapter<BanEntity, BanAdapter.BanEntityViewHolder>(DiffCallback) {
    class BanEntityViewHolder(private var binding: ItemBanBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(ban: BanEntity) {
            binding.apply {
                binding.ban = ban
                if (ban.trangThai == "Hết chỗ") {
                    clBan.setBackgroundResource(R.drawable.background_room_unavailable)
                    clBan.isEnabled = false;
                } else {
                    clBan.setBackgroundResource(R.drawable.background_room)
                    clBan.isEnabled = true;
                }
                executePendingBindings()
            }
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): BanEntityViewHolder {
        val viewHolder = BanEntityViewHolder(
            ItemBanBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
        viewHolder.itemView.setOnClickListener {
            val position = viewHolder.adapterPosition
            clickListener(getItem(position))
        }
        return viewHolder
    }

    override fun onBindViewHolder(holder: BanEntityViewHolder, position: Int) {
        val ban = getItem(position)
        holder.bind(ban)
    }

    companion object DiffCallback : DiffUtil.ItemCallback<BanEntity>() {
        override fun areItemsTheSame(oldItem: BanEntity, newItem: BanEntity): Boolean {
            return oldItem.maBan == newItem.maBan
        }

        override fun areContentsTheSame(oldItem: BanEntity, newItem: BanEntity): Boolean {
            return oldItem == newItem
        }
    }
}