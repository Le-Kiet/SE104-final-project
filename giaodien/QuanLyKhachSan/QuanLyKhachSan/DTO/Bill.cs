using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Bill
    {
        public Bill(int maHoaDon, int maPhong, string tenKhachHangThanhToan, string diaChi, float triGia, DateTime? ngayThanhToan)
        {
            this.MaHoaDon = maHoaDon;
            this.MaPhong = maPhong;
            this.TenKhachHangThanhToan = tenKhachHangThanhToan;
            this.DiaChi = diaChi;
            this.TriGia = triGia;
            this.NgayThanhToan = ngayThanhToan;
        }
        public Bill(DataRow row)
        {
            this.MaHoaDon = (int)row["maHoaDon"];
            this.MaPhong = (int)row["maPhong"];
            this.TenKhachHangThanhToan = row["tenKhachHangThanhToan"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.TriGia = (float)Convert.ToDouble(row["triGia"].ToString());
            this.NgayThanhToan = (DateTime?)row["ngayThanhToan"];
        }

        private DateTime? ngayThanhToan;
        public DateTime? NgayThanhToan
        {
            get { return ngayThanhToan; }
            set { ngayThanhToan = value; }
        }
        private int maPhong;
        public int MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }

        private int maHoaDon;
        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private string tenKhachHangThanhToan;
        public string TenKhachHangThanhToan
        {
            get { return tenKhachHangThanhToan; }
            set { tenKhachHangThanhToan = value; }
        }

        private string diaChi;
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private float triGia;
        public float TriGia
        {
            get { return triGia; }
            set { triGia = value; }
        }
    }
}