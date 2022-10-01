package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.Button
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.R
import com.example.nthrestaurant.databinding.ItemChiTietDatMonBinding
import com.example.nthrestaurant.doiIntThanhTien
import com.example.nthrestaurant.network.model.ChiTietDatMonEntity

class ChiTietDatMonAdapter(private val clickListener: (ChiTietDatMonEntity, Int) -> Unit) : ListAdapter<ChiTietDatMonEntity, ChiTietDatMonAdapter.ChiTietDatMonEntityViewHolder>(DiffCallback) {
    class ChiTietDatMonEntityViewHolder(private var binding: ItemChiTietDatMonBinding) :
        RecyclerView.ViewHolder(binding.root) {
        fun bind(ctDM: ChiTietDatMonEntity) {
            binding.apply {
                ctdm = ctDM
                tvGia.text = ctDM.gia.doiIntThanhTien()
                if(ctDM.trangThai != "Vừa đặt món" && ctDM.tenLMA != "Đồ uống đóng chai"){
                    btnCapNhat.setBackgroundResource(R.drawable.btn_huy)
                    btnCapNhat.isEnabled = false
                    btnHuyMon.setBackgroundResource(R.drawable.btn_huy)
                    btnHuyMon.isEnabled = false
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
            ItemChiTietDatMonBinding.inflate(
                LayoutInflater.from(parent.context), parent, false
            )
        )
    }

    override fun onBindViewHolder(holder: ChiTietDatMonEntityViewHolder, position: Int) {
        val ctDM = getItem(position)

        holder.itemView.findViewById<Button>(R.id.btnCapNhat).setOnClickListener {
            clickListener(ctDM, 1)
        }
        holder.itemView.findViewById<Button>(R.id.btnHuyMon).setOnClickListener {
            clickListener(ctDM, 2)
        }

        holder.bind(ctDM)
    }

    companion object DiffCallback : DiffUtil.ItemCallback<ChiTietDatMonEntity>() {
        override fun areItemsTheSame(oldItem: ChiTietDatMonEntity, newItem: ChiTietDatMonEntity): Boolean {
            return oldItem.idCTDM == newItem.idCTDM
        }

        override fun areContentsTheSame(oldItem: ChiTietDatMonEntity, newItem: ChiTietDatMonEntity): Boolean {
            return oldItem == newItem
        }
    }
}