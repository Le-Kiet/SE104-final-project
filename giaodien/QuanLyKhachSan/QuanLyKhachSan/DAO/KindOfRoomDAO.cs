
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
    public class KindOfRoomDAO
    {
        private static KindOfRoomDAO instance;

        public static KindOfRoomDAO Instance
        {
            get
            {
                if (instance == null) instance = new KindOfRoomDAO(); return KindOfRoomDAO.instance;
            }
            private set
            {
                KindOfRoomDAO.instance = value;
            }
        }
        public static int KindofRoomWidth = 100;
        public static int KindofRoomHeight = 100;
        private KindOfRoomDAO() { }
        public List<KindOfRoom> LoadKindList()
        {
            List<KindOfRoom> kindofroomList = new List<KindOfRoom>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LOAIPHONG");
            foreach (DataRow item in data.Rows)
            {
                KindOfRoom kindofroom = new KindOfRoom(item);

                kindofroomList.Add(kindofroom);

            }


            return kindofroomList;
        }

        public bool InsertKind(string maloaiphong, string tenloaiphong, int dongia)
        {
            string q = string.Format("INSERT dbo.LOAIPHONG (MaLoaiPhong, TenLoaiPhong, DonGia) VALUES (N'{0}',N'{1}',{2})", maloaiphong, tenloaiphong, dongia);
            int result = DataProvider.Instance.ExecutenonQuery(q);
            return result > 0;
        }
        public bool UpdateKind(string maloaiphong, string tenloaiphong, int dongia)
        {
            string q = string.Format("UPDATE dbo.LOAIPHONG SET MaLoaiPhong = N'{0}',  TenLoaiPhong = N'{1}', DonGia = '{2}' where MaLoaiPhong = N'{3}'", maloaiphong, tenloaiphong, dongia, maloaiphong);
            int result = DataProvider.Instance.ExecutenonQuery(q);
            return result > 0;
        }
        public bool DeleteKind(string maloaiphong)
        {
            string q = string.Format("Delete dbo.LOAIPHONG Where MaLoaiPhong = N'{0}' ", maloaiphong);
            int result = DataProvider.Instance.ExecutenonQuery(q);
            return result > 0;
        }

    }
}
