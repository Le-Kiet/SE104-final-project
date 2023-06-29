using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class KindGuest
    {
        private string maloaikhach;

        public string MaLoaiKhach
        { get { return maloaikhach; } set { maloaikhach = value; } }

        private string tenloaikhach;

        public string TenLoaiKhach { get { return tenloaikhach; } set { tenloaikhach = value; } }

        private float hesophuthu;
        public float HeSoPhuThu { get { return hesophuthu; } set { hesophuthu = value; } }

        public KindGuest(string maloaikhach, string tenloaikhach, float hesophuthu)
        {
            this.MaLoaiKhach = maloaikhach;
            this.TenLoaiKhach = tenloaikhach;
            this.HeSoPhuThu = hesophuthu;
        }
        public KindGuest(DataRow row)
        {

            this.MaLoaiKhach = row["maloaikhach"].ToString();


            this.TenLoaiKhach = row["tenloaikhach"].ToString();
            this.HeSoPhuThu = (float)Convert.ToDouble(row["hesophuthu"]);

        }
    }
}
