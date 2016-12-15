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
        public DSphieuKiemKho getReportList(DSphieuKiemKho ds)
        {
            //Lấy DS phiếu
            return dao.getReportList(ds);
        }

        public PhieuThongKe getCheckReportDetail(PhieuThongKe pkk)
        {
            //Xem chi tiết phiếu thống kê
            return dao.getCheckReportDetail(pkk);
        }

        public int createNewStoreReport(PhieuThongKe phieu_moi)
        {
            //Tạo phiếu thống kê đầu/cuối ngày
            return dao.createStoreCheckReport(phieu_moi);
        }
        public int createImportReport(PhieuThongKe phieu_moi)
        {
            //Tạo phiếu nhập kho
            return dao.createImportReport(phieu_moi);
        }

        public int deleteReport(PhieuThongKe pkk)
        {
            return dao.deleteReport(pkk);
        }

        public void changeReportDetail(PhieuThongKe pkk)
        {
            //Sửa chi tiết phiếu TK
            try
            {
                dao.changeReportDetail(pkk);
            }
            catch (FormatException)
            {
                throw;
            }
        }

        public BangTinhHinhTK storeStatistics(BangTinhHinhTK bang)
        {
            return dao.storeStatistics(bang);
        }
    }
}
