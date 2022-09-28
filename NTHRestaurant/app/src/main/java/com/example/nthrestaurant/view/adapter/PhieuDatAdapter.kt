package com.example.nthrestaurant.view.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.ListAdapter
import androidx.recyclerview.widget.RecyclerView
import com.example.nthrestaurant.databinding.ItemPhieuDatBinding
import com.example.nthrestaurant.network.model.PhieuDatEntity

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
        val ticketReservation = getItem(position)

//        holder.itemView.findViewById<Button>(R.id.btnOrder).setOnClickListener {
//            val action =
//                TicketReservationFragmentDirections.actionTicketReservationFragmentToOrderFragment()
//            holder.itemView.findNavController().navigate(action)
//            clickListener(ticketReservation)
//        }
//
//        holder.itemView.findViewById<Button>(R.id.btnDetail).setOnClickListener {
//            val action =
//                TicketReservationFragmentDirections.actionTicketReservationFragmentToDetailFragment()
//            holder.itemView.findNavController().navigate(action)
//            clickListener(ticketReservation)
//        }

        holder.bind(ticketReservation)
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