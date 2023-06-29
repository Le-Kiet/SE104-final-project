using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class CT_PhieuThuePhong
    {
        private int maPhieuThuePhong;
        private string maLoaiKhach;
        private string cmnd;
        private string tenKhachHang;
        private string diaChi;

        public CT_PhieuThuePhong(string loaiKhach, string cm, string tenKhach, string diaChi)
        {
            this.maLoaiKhach = loaiKhach;
            this.cmnd = cm;
            this.tenKhachHang = tenKhach;
            this.diaChi = diaChi;
        }
        public CT_PhieuThuePhong(DataRow row)
        {
            this.MaPhieuThuePhong = (int)row["maPhieuThuePhong"];
            this.MaLoaiKhach = row["maLoaiKhach"].ToString();
            this.CMND = row["cmnd"].ToString();
            this.TenKhachHang = row["tenKhachHang"].ToString();
            this.DiaChi = row["diaChi"].ToString();
        }

        public int MaPhieuThuePhong { get { return this.maPhieuThuePhong; } set { this.maPhieuThuePhong = value; } }
        public string MaLoaiKhach { get { return this.maLoaiKhach; } set { this.maLoaiKhach = value; } }
        public string CMND { get { return this.cmnd; } set { this.cmnd = value; } }
        public string TenKhachHang { get { return this.tenKhachHang; } set { this.tenKhachHang = value; } }
        public string DiaChi { get { return this.diaChi; } set { this.diaChi = value; } }
    }
}
