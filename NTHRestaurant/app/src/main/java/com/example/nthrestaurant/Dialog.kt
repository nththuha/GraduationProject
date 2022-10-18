package com.example.nthrestaurant

import android.app.Dialog
import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.view.Gravity
import android.view.View
import android.view.Window
import android.view.WindowManager
import android.widget.*
import androidx.fragment.app.FragmentActivity
import androidx.navigation.findNavController
import com.example.nthrestaurant.network.model.ChiTietDatMonEntity
import com.example.nthrestaurant.network.model.MonAnEntity
import com.example.nthrestaurant.network.model.TaiKhoanEntity
import com.example.nthrestaurant.view.bep.TrangChuBepFragmentDirections
import com.example.nthrestaurant.view.phache.TrangChuPhaCheFragmentDirections
import com.example.nthrestaurant.view.phucvu.TrangChuPhucVuFragmentDirections
import com.example.nthrestaurant.viewmodel.BepViewModel
import com.example.nthrestaurant.viewmodel.PhaCheViewModel
import com.example.nthrestaurant.viewmodel.PhucVuViewModel

fun dialogThanhCong(fm: FragmentActivity, thongBao: String) {
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

    dialog.findViewById<TextView>(R.id.tvThongBao_TC).text = thongBao
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
            fm.showToast("Hủy món thành công!")
        }
        else {
            fm.showToast("Hủy món thất bại!")
        }
        dialog.dismiss()
    }

    dialog.findViewById<Button>(R.id.btnCancel_HM).setOnClickListener{
        dialog.dismiss()
    }
    dialog.show()
}

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
        val chuThich = dialog.findViewById<TextView>(R.id.etChuThich_DM).text.trim().toString()
        val soLuong = tvSoLuong.text.toString().toInt();
        val trangThai = "Vừa đặt món"
        val gia = viewModel.monAn.value?.gia
        val maMA = viewModel.monAn.value?.maMA
        val idPD = viewModel.phieuDat.value?.idPD
        val ctDatMon = ChiTietDatMonEntity(chuThich, gia!! * soLuong, 0, "", -5, idPD!!, "", "", maMA!!, soLuong, "", "", "", trangThai)
        if(viewModel.themCTDatMon(ctDatMon)){
            fm.showToast("Đặt món thành công!")
        }
        else {
            fm.showToast("Đặt món thất bại!")
        }
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogChinhSuaDatMon(fm: FragmentActivity, ctdm: ChiTietDatMonEntity, viewModel: PhucVuViewModel) {
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
        dialog.findViewById<TextView>(R.id.etChuThich_DM).text = ctdm.chuThich
    }

    val tvSoLuong = dialog.findViewById<TextView>(R.id.tvSoLuong)
    tvSoLuong.text = ctdm.soLuong.toString()
    if(ctdm.soLuong > 1) dialog.findViewById<ImageView>(R.id.ivTru).setImageResource(R.drawable.ic_tru_available)

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
        val chuThich =  dialog.findViewById<TextView>(R.id.etChuThich_DM).text.trim()
        val soLuong = tvSoLuong.text.toString().toInt();
        val trangThai = ctdm.trangThai
        val maMA = ctdm.maMA
        val idPD = viewModel.phieuDat.value?.idPD
        val ctDatMon = ChiTietDatMonEntity(chuThich.toString(), ctdm.giaTungMon * soLuong, 0, "", ctdm.idCTDM, idPD!!, "", "", maMA, soLuong, "", "", "", trangThai)
        if(viewModel.suaCTDM(ctDatMon)){
            fm.showToast("Cập nhật thành công!")
        }
        else{
            fm.showToast("Cập nhật thất bại!")
        }
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogDoiMatKhau(fm: FragmentActivity, vmPhucVu: PhucVuViewModel, vmBep: BepViewModel, vmPhaChe: PhaCheViewModel) {
    val dialog = Dialog(fm)
    dialog.requestWindowFeature(Window.FEATURE_NO_TITLE)
    dialog.setContentView(R.layout.dialog_doi_mat_khau)

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

    dialog.findViewById<Button>(R.id.btnDoiMatKhau_MK).setOnClickListener {
        val tvMatKhauMoi = dialog.findViewById<EditText>(R.id.etMatKhauMoi)
        val tvXacNhanMK = dialog.findViewById<EditText>(R.id.etMatKhauMoi_XM)
        if(tvMatKhauMoi.text.toString() != tvXacNhanMK.text.toString()){
            fm.showToast("Mật khẩu không khớp!")
        }
        else{
            if(vmPhucVu.nhanVien.value != null){
                val taiKhoan = TaiKhoanEntity(vmPhucVu.maTK, tvMatKhauMoi.text.toString(), vmPhucVu.nhanVien.value?.idNV!!)
                if(vmPhucVu.suaTaiKhoan(taiKhoan)){
                    fm.showToast("Đổi mật khẩu thành công!")
                }
                else {
                    fm.showToast("Đổi mật khẩu thất bại!")
                }
                dialog.dismiss()
            }
            else if(vmBep.nhanVien.value != null){
                val taiKhoan = TaiKhoanEntity(vmBep.maTK, tvMatKhauMoi.text.toString(), vmBep.nhanVien.value?.idNV!!)
                if(vmBep.suaTaiKhoan(taiKhoan)){
                    fm.showToast("Đổi mật khẩu thành công!")
                }
                else {
                    fm.showToast("Đổi mật khẩu thất bại!")
                }
                dialog.dismiss()
            }
            else{
                val taiKhoan = TaiKhoanEntity(vmPhaChe.maTK, tvMatKhauMoi.text.toString(), vmPhaChe.nhanVien.value?.idNV!!)
                if(vmPhaChe.suaTaiKhoan(taiKhoan)){
                    fm.showToast("Đổi mật khẩu thành công!")
                }
                else {
                    fm.showToast("Đổi mật khẩu thất bại!")
                }
                dialog.dismiss()
            }
        }
    }
    dialog.findViewById<Button>(R.id.btnCancel_MK).setOnClickListener {
        dialog.dismiss()
    }
    dialog.show()
}

fun dialogDangXuat(fm: FragmentActivity, view: View, vmPhucVu: PhucVuViewModel, vmBep: BepViewModel, vmPhaChe: PhaCheViewModel) {
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
        if(vmPhucVu.nhanVien.value != null){
            vmPhucVu.resetNhanVien()
            vmBep.resetNhanVien()
            vmPhaChe.resetNhanVien()
            val action = TrangChuPhucVuFragmentDirections.actionTrangChuFragmentToDangNhapFragment()
            view.findNavController().navigate(action)
        }
        else if(vmBep.nhanVien.value != null){
            vmPhucVu.resetNhanVien()
            vmBep.resetNhanVien()
            vmPhaChe.resetNhanVien()
            val action = TrangChuBepFragmentDirections.actionTrangChuBepFragmentToDangNhapFragment()
            view.findNavController().navigate(action)
        }
        else{
            vmPhucVu.resetNhanVien()
            vmBep.resetNhanVien()
            vmPhaChe.resetNhanVien()
            val action = TrangChuPhaCheFragmentDirections.actionTrangChuPhaCheFragmentToDangNhapFragment()
            view.findNavController().navigate(action)
        }
    }
    dialog.findViewById<Button>(R.id.btnCancel).setOnClickListener {
        dialog.dismiss()
    }
    dialog.show()
}