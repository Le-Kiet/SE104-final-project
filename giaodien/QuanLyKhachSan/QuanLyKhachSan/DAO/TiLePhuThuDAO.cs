using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class TiLePhuThuDAO
    {
        private static TiLePhuThuDAO instance;

        public static TiLePhuThuDAO Instance
        {
            get
            {
                if (instance == null) instance = new TiLePhuThuDAO(); return TiLePhuThuDAO.instance;
            }
            private set
            {
                TiLePhuThuDAO.instance = value;
            }
        }
        public static int RoomWidth = 100;
        public static int RoomHeight = 100;
        private TiLePhuThuDAO() { }
        public List<TiLePhuThu> LoadTiLePhuThuList()
        {
            List<TiLePhuThu> tilephuthuList = new List<TiLePhuThu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TILEPHUTHU");
            foreach (DataRow item in data.Rows)
            {
                TiLePhuThu tilephuthu = new TiLePhuThu(item);
                tilephuthuList.Add(tilephuthu);

            }

            return tilephuthuList;
        }
        public bool InsertTiLePhuThu(int khachthubaonhieu, float tile)
        {
            string query = string.Format("INSERT dbo.TILEPHUTHU ( KhachThuBaoNhieu, TiLePhuThu) VALUES ({0},{1}.0/100)", khachthubaonhieu, tile);
            int result = DataProvider.Instance.ExecutenonQuery(query);

            return result > 0;
        }

        public bool UpdateTiLePhuThu(int khachthubaonhieu, float tile)
        {
            string query = string.Format("UPDATE dbo.TILEPHUTHU SET TiLePhuThu = {0}.0/100 WHERE KhachThuBaoNhieu={1}", tile, khachthubaonhieu);
            int result = DataProvider.Instance.ExecutenonQuery(query);
            return result > 0;
        }

    }
}
