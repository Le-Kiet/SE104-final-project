using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class PhieuThuePhong
    {
        private int maPhieuThuePhong;
        private int maPhong;
        private float donGiaThue;
        private int soKhachTrongPhong;
        private string ngayBatDauThue;

        public PhieuThuePhong() { }
        public PhieuThuePhong(int phong, float donGia, int soKhach, string ngayBatDau)
        {
            this.maPhong = phong;
            this.donGiaThue = donGia;
            this.soKhachTrongPhong = soKhach;
            this.ngayBatDauThue = ngayBatDau;
        }
        public PhieuThuePhong(DataRow row)
        {
            this.MaPhieuThuePhong = (int)row["maPhieuThuePhong"];
            this.MaPhong = (int)row["maPhong"];
            this.DonGiaThue1Ngay = (float)row["donGiaThue"];
            this.SoKhachTrongPhong = (int)row["soKhachTrongPhong"];
            this.NgayBatDauThue = row["ngayBatDauThue"].ToString();
        }

        public int MaPhieuThuePhong { get { return this.maPhieuThuePhong; } set { this.maPhieuThuePhong = value; } }
        public int MaPhong { get { return this.maPhong; } set { this.maPhong = value; } }
        public float DonGiaThue1Ngay { get { return this.donGiaThue; } set { this.donGiaThue = value; } }
        public int SoKhachTrongPhong { get { return this.soKhachTrongPhong; } set { this.soKhachTrongPhong = value; } }
        public string NgayBatDauThue { get { return this.ngayBatDauThue; } set { this.ngayBatDauThue = value; } }
    }
}
