using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public int ma_NV { get; set; }
        public string ho_ten { get; set; }
        public string so_cmnd { get; set; }
        public string dia_chi { get; set; }
        public string Email { get; set; }
        public int ma_loai_NV { get; set; }
        public string ten_loai_nv { get; set; }
        public string mat_khau { get; set; }
        public int tinh_trang { get; set; }
    }
}
