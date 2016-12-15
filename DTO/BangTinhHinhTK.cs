using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class BangTinhHinhTK
    {
        public DateTime ngay_BD { get; set; }
        public DateTime ngay_KT { get; set; }
        public DataTable chi_tiet { get; set; }
    }
}
