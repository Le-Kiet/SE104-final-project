using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class RoomType
    {
        private string maLoaiPhong;
        private string tenLoaiPhong;
        private int donGia;
        public RoomType(string maLoaiPhong, string tenLoaiPhong, int donGia)
        {
            this.MaLoaiPhong = maLoaiPhong;
            this.TenLoaiPhong = tenLoaiPhong;
            this.DonGia = donGia;

        }
        public RoomType(DataRow row)
        {
            this.MaLoaiPhong = row["maLoaiPhong"].ToString();
            this.TenLoaiPhong = row["tenLoaiPhong"].ToString();
            this.DonGia = (int)row["donGia"];
        }

        public string MaLoaiPhong { get { return this.maLoaiPhong; } set { this.maLoaiPhong = value; } }
        public string TenLoaiPhong { get { return this.tenLoaiPhong; } set { this.tenLoaiPhong = value; } }
        public int DonGia { get { return this.donGia; } set { this.donGia = value; } }
    }
}
