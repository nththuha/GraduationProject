package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.navigation.findNavController
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemPhieuDatBinding
import com.example.nthrestaurant.network.model.PhieuDatEntity
import com.example.nthrestaurant.view.TrangChuFragmentDirections

class PhieuDatAdapter(private val clickListener: (PhieuDatEntity) -> Unit) : ListAdapter<PhieuDatEntity, PhieuDatAdapter.PhieuDatEntityViewHolder>(DiffCallback) {

    class PhieuDatEntityViewHolder(private var binding: ItemPhieuDatBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(phieuDat: PhieuDatEntity) {
            binding.phieuDat = phieuDat
            binding.executePendingBindings()
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): PhieuDatEntityViewHolder {
        return PhieuDatEntityViewHolder(
            ItemPhieuDatBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: PhieuDatEntityViewHolder, position: Int) {
        val phieuDat = getItem(position)

        holder.itemView.findViewById<Button>(R.id.btnDatMon).setOnClickListener {
            val action =
                TrangChuFragmentDirections.actionTrangChuFragmentToDatMonFragment()
            holder.itemView.findNavController().navigate(action)
            clickListener(phieuDat)
        }

        holder.itemView.findViewById<Button>(R.id.btnChiTiet).setOnClickListener {
            val action = TrangChuFragmentDirections.actionTrangChuFragmentToChiTietDatMonFragment()
            holder.itemView.findNavController().navigate(action)
            clickListener(phieuDat)
        }

        holder.bind(phieuDat)
    }

    companion object DiffCallback : DiffUtil.ItemCallback<PhieuDatEntity>() {
        override fun areItemsTheSame(oldItem: PhieuDatEntity, newItem: PhieuDatEntity): Boolean {
            return oldItem.idPD == newItem.idPD
        }

        override fun areContentsTheSame(oldItem: PhieuDatEntity, newItem: PhieuDatEntity): Boolean {
            return oldItem == newItem
        }
    }
}