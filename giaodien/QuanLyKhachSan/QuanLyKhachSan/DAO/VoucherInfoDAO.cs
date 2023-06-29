using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class VoucherInfoDAO
    {
        private static VoucherInfoDAO instance;

        public static VoucherInfoDAO Instance
        {
            get
            {
                if (instance == null)
                instance = new VoucherInfoDAO();
                return VoucherInfoDAO.instance;
            }

            private set
            {
                VoucherInfoDAO.instance = value;
            }
        }
        private VoucherInfoDAO()
        {

        }
        public List<VoucherInfo> GetListVoucherInfo(int maphieuthuephong)
        {
            List<VoucherInfo> listVoucherInfo = new List<VoucherInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from CT_PHIEUTHUEPHONG where MaPhieuThuePhong = "+maphieuthuephong);
            foreach (DataRow item in data.Rows)
            {
                VoucherInfo info = new VoucherInfo(item);
                listVoucherInfo.Add(info);
            }
            return listVoucherInfo;
        }
    }
}
