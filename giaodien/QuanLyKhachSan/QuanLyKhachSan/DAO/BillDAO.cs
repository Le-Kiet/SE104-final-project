
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillDAO();
                return BillDAO.instance;
            }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public int GetUncheckBillIDByRoomID(int maPhong)
        {
            string query = "SELECT * FROM HOADON WHERE MaPhong = " + maPhong;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.MaHoaDon;
            }
            return -1;
        }

        public void CheckOut(int mahoadon, float total)
        {
            string query = "UPDATE HOADON SET NgayThanhToan = GETDATE() , TriGia = " + total + " where MaHoaDon = " + mahoadon + "UPDATE PHIEUTHUEPHONG SET TinhTrangPhieuThuePhong = N'Đã Thanh Toán' WHERE MaHoaDon = " + mahoadon;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public void InsertBill(int mahoadon, string tenkhachhangthanhtoan, string diachi, float trigia)
        {
            string querry = string.Format("insert HOADON(MaHoaDon, TenKhachHangThanhToan, DiaChi, TriGia) values ({0}, N'{1}', N'{2}', {3})", mahoadon, tenkhachhangthanhtoan, diachi, trigia);
            DataProvider.Instance.ExecutenonQuery(querry);
        }
    }
}
