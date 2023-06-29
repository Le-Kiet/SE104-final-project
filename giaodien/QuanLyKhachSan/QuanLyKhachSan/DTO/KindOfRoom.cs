using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class KindOfRoom
    {
        private string maloaiphong;

        public string MaLoaiPhong
        { get { return maloaiphong; } set { maloaiphong = value; } }

        private string tenloaiphong;

        public string TenLoaiPhong { get { return tenloaiphong; } set { tenloaiphong = value; } }

        private int dongia;
        public int DonGia { get { return dongia; } set { dongia = value; } }

        public KindOfRoom(string maloaiphong, string tenloaiphong, int dongia)
        {
            this.MaLoaiPhong = maloaiphong;
            this.TenLoaiPhong = tenloaiphong;
            this.DonGia = dongia;
        }
        public KindOfRoom(DataRow row)
        {

            this.MaLoaiPhong = row["maloaiphong"].ToString();


            this.TenLoaiPhong = row["tenloaiphong"].ToString();
            this.DonGia = (int)row["dongia"];

        }
    }
}
