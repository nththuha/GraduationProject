package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemChiTietDatMonChoPhucVuBinding
import com.example.nthrestaurant.network.model.ChiTietDatMonEntity

class ChiTietDatMonChuaPhucVuAdapter(private val clickListener: (ChiTietDatMonEntity) -> Unit) :
    ListAdapter<ChiTietDatMonEntity, ChiTietDatMonChuaPhucVuAdapter.ChiTietDatMonEntityViewHolder>(
        DiffCallback
    ) {

    class ChiTietDatMonEntityViewHolder(private var binding: ItemChiTietDatMonChoPhucVuBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(ctDM: ChiTietDatMonEntity) {
            binding.apply {
                ctdm = ctDM
                executePendingBindings()
            }
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): ChiTietDatMonEntityViewHolder {
        return ChiTietDatMonEntityViewHolder(
            ItemChiTietDatMonChoPhucVuBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: ChiTietDatMonEntityViewHolder, position: Int) {
        val ctDM = getItem(position)
        holder.itemView.findViewById<Button>(R.id.btnChuyenTrangThai).setOnClickListener {
            clickListener(ctDM)
        }
        holder.bind(ctDM)
    }

    companion object DiffCallback : DiffUtil.ItemCallback<ChiTietDatMonEntity>() {
        override fun areItemsTheSame(
            oldItem: ChiTietDatMonEntity,
            newItem: ChiTietDatMonEntity
        ): Boolean {
            return oldItem.idCTDM == newItem.idCTDM
        }

        override fun areContentsTheSame(
            oldItem: ChiTietDatMonEntity,
            newItem: ChiTietDatMonEntity
        ): Boolean {
            return oldItem == newItem
        }
    }
}