using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class VoucherInfo
    {
        public VoucherInfo(int maphieuthuephong, string maloaikhach, string cmnd, string tenkhachhang, string diachi)
        {
            this.Maphieuthuephong = maphieuthuephong;
            this.Maloaikhach = maloaikhach;
            this.Cmnd = cmnd;
            this.Tenkhachhang = tenkhachhang;
            this.Diachi = diachi;
            //this.Maphong = maphong;
        }
        private int maphong;
        private int maphieuthuephong;
        private string maloaikhach;
        private string cmnd;
        private string tenkhachhang;
        private string diachi;

        public VoucherInfo(DataRow row)
        {
            this.Maphieuthuephong = (int)row["maphieuthuephong"];
            this.Maloaikhach = row["maloaikhach"].ToString();
            this.Cmnd = row["cmnd"].ToString();
            this.Tenkhachhang = row["tenkhachhang"].ToString();
            this.Diachi = row["diachi"].ToString();
            //this.Maphong = (int)row["maphong"];
        }
        public int Maphieuthuephong
        {
            get
            {
                return maphieuthuephong;
            }

            set
            {
                maphieuthuephong = value;
            }
        }

        public string Maloaikhach
        {
            get
            {
                return maloaikhach;
            }

            set
            {
                maloaikhach = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Tenkhachhang
        {
            get
            {
                return tenkhachhang;
            }

            set
            {
                tenkhachhang = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public int Maphong
        {
            get
            {
                return maphong;
            }

            set
            {
                maphong = value;
            }
        }
    }
}
