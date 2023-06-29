using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class VoucherDAO
    {
        private static VoucherDAO instance;

        public static VoucherDAO Instance
        {
            get { if (instance == null) instance = new VoucherDAO(); return VoucherDAO.instance; }
            private set { VoucherDAO.instance = value; }
        }
        private VoucherDAO()
        {
        
        }
        public int GetUncheckVoucherByRoom(int maphong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PHIEUTHUEPHONG where MaPhong ="+ maphong);
            if (data.Rows.Count > 0)
            {
                Voucher voucher = new Voucher(data.Rows[0]);
                return voucher.Maphieuthuephong;
            }

            return -1;
        }
    }
}
