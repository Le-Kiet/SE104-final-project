using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO()
        {

        }

        public void InsertBillInfo(int MaPhieu, int Mahd, int soNgay, float SoTien)
        {
            string query = string.Format("insert CT_HOADON(MaPhieuThuePhong, MaHoaDon, SoNgayThue, SoTienPhaiTra) values ({0}, {1},{2}, {3})", new object[] { MaPhieu, Mahd, soNgay, SoTien });
            DataProvider.Instance.ExecutenonQuery(query);
        }

    }

}
