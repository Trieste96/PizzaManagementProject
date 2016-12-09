using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DTO
{
    public class PhieuKiemKho
    {
        public int ma_phieu { get; set; }
        public int ma_nv { get; set; }
        public DateTime ngay_gio { get; set; }
        public int ma_loai_phieu { get; set; }
        public string ten_loai_phieu { get; set; }
        public DataTable chi_tiet_phieu { get; set; }
    }
}
