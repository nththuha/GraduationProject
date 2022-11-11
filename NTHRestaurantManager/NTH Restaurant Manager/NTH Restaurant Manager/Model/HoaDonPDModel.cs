using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Model
{
    class HoaDonPDModel
    {
        public String maHD { get; set; }
        public String ngay { get; set; }
        public int trigia { get; set; }
        public int giaSauThue { get; set; }
        public String giaChu { get; set; }
        public String masothue { get; set; }
        public String hotenkh { get; set; }
        public List<CTDatMonModel> ctDatMonList { get; set; }
        public int idnv { get; set; }
        public String hoTenNV { get; set; }
    }
}
