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
        StoreCheckDAO dao = new StoreCheckDAO();
        public DSphieuKiemKho getStoreCheckReportList(DSphieuKiemKho ds_pkk)
        {

            if (ds_pkk.loai_phieu == "Tất cả")
            {
                return dao.getAllReportList(ds_pkk);
            }
            else
            {
                return dao.getSpecificReportList(ds_pkk);
            }
        }
        public PhieuKiemKho getCheckReportDetail(PhieuKiemKho pkk)
        {
            return dao.getCheckReportDetail(pkk);
        }

        public int createNewStoreReport(PhieuKiemKho phieu_moi)
        {
            return dao.createNewStoreReport(phieu_moi);
        }

        public int deleteReport(PhieuKiemKho pkk)
        {
            return dao.deleteReport(pkk);
        }
    }
}
