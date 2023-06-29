
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class KindGuestDAO
    {
        private static KindGuestDAO instance;

        public static KindGuestDAO Instance
        {
            get
            {
                if (instance == null) instance = new KindGuestDAO(); return KindGuestDAO.instance;
            }
            private set
            {
                KindGuestDAO.instance = value;
            }
        }
        public static int KindguestWidth = 100;
        public static int KindguestHeight = 100;
        private KindGuestDAO() { }
        public List<KindGuest> LoadKindGuestList()
        {
            List<KindGuest> kindguestList = new List<KindGuest>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LOAIKHACHHANG");
            foreach (DataRow item in data.Rows)
            {
                KindGuest kindguest = new KindGuest(item);

                kindguestList.Add(kindguest);

            }
            return kindguestList;
        }
        public bool InsertKindGuest(string maloaikhach, string tenloaikhach, float hesophuthu)
        {
            string q = string.Format("INSERT dbo.LOAIKHACHHANG (MaLoaiKhach, TenLoaiKhach, HeSoPhuThu) VALUES (N'{0}',N'{1}',{2})", maloaikhach, tenloaikhach, hesophuthu);
            int result = DataProvider.Instance.ExecutenonQuery(q);
            return result > 0;
        }
        public bool UpdateKindGuest(string maloaikhach, string tenloaikhach, float hesophuthu)
        {
            string q = string.Format("UPDATE dbo.LOAIKHACHHANG SET MaLoaiKhach = N'{0}',  TenLoaiKhach = N'{1}', HeSoPhuThu = '{2}' where MaLoaiKhach = N'{3}'", maloaikhach, tenloaikhach, hesophuthu, maloaikhach);
            int result = DataProvider.Instance.ExecutenonQuery(q);
            return result > 0;
        }
        public bool DeleteKindGuest(string maloaikhach)
        {
            string q = string.Format("Delete dbo.LOAIKHACHHANG Where MaLoaiKhach = N'{0}' ", maloaikhach);
            int result = DataProvider.Instance.ExecutenonQuery(q);
            return result > 0;
        }
    }
}
