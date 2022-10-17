package com.example.nthrestaurant

import android.app.Dialog
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.view.Gravity
import android.view.View
import android.view.Window
import android.view.WindowManager
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
import androidx.fragment.app.FragmentActivity
import androidx.navigation.findNavController
import com.example.nthrestaurant.network.model.ChiTietDatMonEntity
import com.example.nthrestaurant.network.model.MonAnEntity
import com.example.nthrestaurant.view.TrangChuFragmentDirections
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

fun dialogDatMon(fm: FragmentActivity, monAn: MonAnEntity, viewModel: PhucVuViewModel) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_dat_mon)

    val window: Window? = dialog.window
    window?.setLayout(
        WindowManager.LayoutParams.MATCH_PARENT,
        WindowManager.LayoutParams.WRAP_CONTENT
    )
    window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

    val windowAttributes: WindowManager.LayoutParams = window!!.attributes
    windowAttributes.gravity = Gravity.BOTTOM
    window.attributes = windowAttributes

    dialog.setCancelable(true)
    dialog.findViewById<TextView>(R.id.tvTenMA).text = monAn.tenMA
    dialog.findViewById<TextView>(R.id.tvGia).text = monAn.gia.doiIntThanhTien()
    if(monAn.chuThich != null){
        dialog.findViewById<TextView>(R.id.tvMoTa).text = "Mô tả: " + monAn.chuThich
    }

    val tvSoLuong = dialog.findViewById<TextView>(R.id.tvSoLuong)

    dialog.findViewById<ImageView>(R.id.ivCong).setOnClickListener {
        val sl = tvSoLuong.text.toString().toInt() + 1
        if(sl > 1) dialog.findViewById<ImageView>(R.id.ivTru).setImageResource(R.drawable.ic_tru_available)
        tvSoLuong.text = sl.toString()
    }

    dialog.findViewById<ImageView>(R.id.ivTru).setOnClickListener {
        var sl = tvSoLuong.text.toString().toInt()
        if(sl > 1){
            sl -= 1
            tvSoLuong.text = sl.toString()
            if(sl == 1){
                dialog.findViewById<ImageView>(R.id.ivTru).setImageResource(R.drawable.ic_tru_unavailable)
            }
        }
    }

    dialog.findViewById<Button>(R.id.btnXacNhan_DM).setOnClickListener {
        val chuThich =  dialog.findViewById<TextView>(R.id.etChuThich).text.trim()
        val soLuong = tvSoLuong.text.toString().toInt();
        val trangThai = "Vừa đặt món"
        val gia = viewModel.monAn.value?.gia
        val maMA = viewModel.monAn.value?.maMA
        val idPD = viewModel.phieuDat.value?.idPD
        val ctDatMon = ChiTietDatMonEntity(chuThich.toString(), gia!!, 0, "", -5, idPD!!, "", "", maMA!!, soLuong, "", "", "", trangThai)
        if(viewModel.themCTDatMon(ctDatMon)){
            Toast.makeText(fm, "Đặt món thành công!", Toast.LENGTH_SHORT).show()
        }
        else Toast.makeText(fm, "Đặt món thất bại!", Toast.LENGTH_SHORT).show()
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogThanhCong(fm: FragmentActivity) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_thong_bao_thanh_cong)

    val window: Window? = dialog.window
    window?.setLayout(
        WindowManager.LayoutParams.MATCH_PARENT,
        WindowManager.LayoutParams.WRAP_CONTENT
    )
    window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

    val windowAttributes: WindowManager.LayoutParams = window!!.attributes
    windowAttributes.gravity = Gravity.CENTER
    window.attributes = windowAttributes

    dialog.setCancelable(false)

    dialog.findViewById<Button>(R.id.btnXacNhan_TC).setOnClickListener {
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogThatBai(fm: FragmentActivity, thongBao: String) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_thong_bao_that_bai)

    val window: Window? = dialog.window
    window?.setLayout(
        WindowManager.LayoutParams.MATCH_PARENT,
        WindowManager.LayoutParams.WRAP_CONTENT
    )
    window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

    val windowAttributes: WindowManager.LayoutParams = window!!.attributes
    windowAttributes.gravity = Gravity.CENTER
    window.attributes = windowAttributes

    dialog.setCancelable(false)

    dialog.findViewById<TextView>(R.id.tvThongBao_TB).text = thongBao
    dialog.findViewById<Button>(R.id.btnXacNhan_TB).setOnClickListener {
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogHuyChiTietDatMon(fm: FragmentActivity, ctdm: ChiTietDatMonEntity, viewModel: PhucVuViewModel) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_huy_mon_dat)

    val window: Window? = dialog.window
    window?.setLayout(
        WindowManager.LayoutParams.MATCH_PARENT,
        WindowManager.LayoutParams.WRAP_CONTENT
    )
    window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

    val windowAttributes: WindowManager.LayoutParams = window!!.attributes
    windowAttributes.gravity = Gravity.CENTER
    window.attributes = windowAttributes

    dialog.setCancelable(false)

    dialog.findViewById<TextView>(R.id.tvCauHoi_HM).text = "Bạn có muốn xóa món " + ctdm.tenMA + "?"
    dialog.findViewById<Button>(R.id.btnXacNhan_HM).setOnClickListener{
        if(viewModel.xoaCTDM(ctdm.idCTDM)) {
            Toast.makeText(fm, "Xóa thành công!", Toast.LENGTH_SHORT).show()
        }
        else Toast.makeText(fm, "Xóa thất bại!", Toast.LENGTH_SHORT).show()
        dialog.dismiss()
    }

    dialog.findViewById<Button>(R.id.btnCancel_HM).setOnClickListener{
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogChinhSuaDatMon(fm: FragmentActivity, ctdm: ChiTietDatMonEntity) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_dat_mon)

    val window: Window? = dialog.window
    window?.setLayout(
        WindowManager.LayoutParams.MATCH_PARENT,
        WindowManager.LayoutParams.WRAP_CONTENT
    )
    window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

    val windowAttributes: WindowManager.LayoutParams = window!!.attributes
    windowAttributes.gravity = Gravity.BOTTOM
    window.attributes = windowAttributes

    dialog.setCancelable(true)
    dialog.findViewById<TextView>(R.id.tvTenMA).text = ctdm.tenMA
    dialog.findViewById<TextView>(R.id.tvGia).text = ctdm.gia.doiIntThanhTien()
    if(ctdm.chuThich != null) {
        dialog.findViewById<TextView>(R.id.tvMoTa).text = "Mô tả: " + ctdm.chuThich
    }
    dialog.show()
}

fun dialogDangXuat(fm: FragmentActivity, view: View) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_dang_xuat)

    val window: Window? = dialog.window
    window?.setLayout(
        WindowManager.LayoutParams.MATCH_PARENT,
        WindowManager.LayoutParams.WRAP_CONTENT
    )
    window?.setBackgroundDrawable(ColorDrawable(Color.TRANSPARENT))

    val windowAttributes: WindowManager.LayoutParams = window!!.attributes
    windowAttributes.gravity = Gravity.CENTER
    window.attributes = windowAttributes

    dialog.setCancelable(false)

    dialog.findViewById<Button>(R.id.btnDangXuat).setOnClickListener {
        dialog.dismiss()
        val action = TrangChuFragmentDirections.actionTrangChuFragmentToDangNhapFragment()
        view.findNavController().navigate(action)
    }
    dialog.findViewById<Button>(R.id.btnCancel).setOnClickListener {
        dialog.dismiss()
    }
    dialog.show()
}