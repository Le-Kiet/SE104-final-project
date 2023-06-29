using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DAO
{
    public class RoomTypeDAO
    {
        private static RoomTypeDAO instance;

        public static RoomTypeDAO Instance
        {
            get
            {
                if (instance == null) instance = new RoomTypeDAO();
                return RoomTypeDAO.instance;
            }
            private set
            {
                RoomTypeDAO.instance = value;
            }
        }
        private RoomTypeDAO() { }
        public string GetdonGia(int maPhong)
        {
            string query = "SELECT lp.DonGia FROM LOAIPHONG lp JOIN DANHMUCPHONG p ON lp.MaLoaiPhong = p.MaLoaiPhong WHERE p.MaPhong = " + maPhong;


            string donGia = DataProvider.Instance.ExecuteScalar(query);
            if (donGia != null) return donGia;

            return null;
        }

    }
}
