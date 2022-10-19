package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemNuocDatBinding
import com.example.nthrestaurant.network.model.ChiTietDatMonEntity

class ChiTietNuocDatAdapter(private val clickListener: (ChiTietDatMonEntity, Int) -> Unit) :
    ListAdapter<ChiTietDatMonEntity, ChiTietNuocDatAdapter.ChiTietDatMonEntityViewHolder>(
        DiffCallback
    ) {
    class ChiTietDatMonEntityViewHolder(private var binding: ItemNuocDatBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(ctDM: ChiTietDatMonEntity) {
            binding.apply {
                ctdm = ctDM
                if (ctDM.chuThich != null) tvChuThichMD.text = ctDM.chuThich
                if (ctDM.trangThai == "Đang làm") {
                    btnDangLam.setBackgroundResource(R.drawable.btn_huy)
                    btnDangLam.isEnabled = false
                } else {
                    btnDangLam.setBackgroundResource(R.drawable.btn_dangnhap)
                    btnDangLam.isEnabled = true
                }
                executePendingBindings()
            }
        }
    }

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): ChiTietDatMonEntityViewHolder {
        return ChiTietDatMonEntityViewHolder(
            ItemNuocDatBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: ChiTietDatMonEntityViewHolder, position: Int) {
        val ctDM = getItem(position)

        holder.itemView.findViewById<Button>(R.id.btnDangLam).setOnClickListener {
            clickListener(ctDM, 1)
        }
        holder.itemView.findViewById<Button>(R.id.btnChoPhucVu).setOnClickListener {
            clickListener(ctDM, 2)
        }
        holder.itemView.findViewById<Button>(R.id.btnHuyMonDat).setOnClickListener {
            clickListener(ctDM, 3)
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