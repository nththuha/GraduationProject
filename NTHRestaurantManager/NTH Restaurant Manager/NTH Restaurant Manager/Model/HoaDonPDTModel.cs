using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Model
{
    class HoaDonPDTModel
    {
        public String maHD { get; set; }
        public String ngay { get; set; }
        public int trigia { get; set; }
        public int giaSauThue { get; set; }
        public String masothue { get; set; }
        public String hotenkh { get; set; }
        public int idnv { get; set; }
        public String hoTenNV { get; set; }
        public List<CTDatMonTruocModel> ctDatMonTruocList { get; set; }
        public List<TienCocModel> tienCocList { get; set; }
        public int tongCoc { get; set; }
        public int giaConLai { get; set; }
        public String giaChu { get; set; }
    }
}
