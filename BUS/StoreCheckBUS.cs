using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class StoreCheckBUS
    {
        public DSphieuKiemKho getStoreCheckReportList(DSphieuKiemKho phieu_kk)
        {
            StoreCheckDAO dao = new StoreCheckDAO();
            if (phieu_kk.loai_phieu == "Tất cả")
            {
                return dao.getAllReportList(phieu_kk);
            }
            else
            {
                return dao.getSpecificReportList(phieu_kk);
            }

        }
    }
}
