using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Model
{
    class PhieuDatTruocModel
    {
        public int idPDT { get; set; }
        public String ngayTao { get; set; }
        public String ngayDat { get; set; }
        public int gioDat { get; set; }
        public int gia { get; set; }
        public int giaSauThue { get; set; }
        public String trangThai { get; set; }
        public int idnv { get; set; }
        public String hoTenNV { get; set; }
        public int idkh { get; set; }
        public String hoTenKH { get; set; }
        public String sdt { get; set; }
    }
}
