﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class DSphieuKiemKho
    {
        public string loai_phieu { get; set; }
        public string phieu_1 { get; set; }
        public string phieu_2 { get; set; }
        public string phieu_3 { get; set; }
        public DataTable danh_sach_phieu { get; set; }

    }
}
