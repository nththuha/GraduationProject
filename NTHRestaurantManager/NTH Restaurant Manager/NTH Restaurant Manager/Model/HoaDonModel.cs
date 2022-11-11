﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTH_Restaurant_Manager.Model
{
    class HoaDonModel
    {
        public String maHD { get; set; }
        public String ngay { get; set; }
        public String masothue { get; set; }
        public String hotenkh { get; set; }
        public List<PhieuDatModel> phieudatList { get; set; }
        public int idnv { get; set; }
    }
}
