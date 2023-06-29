using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Voucher
    {
        private int maphieuthuephong;
        private DateTime? ngaybatdauthue;
        private int maphong;
        private float dongiathue1ngay;
        private int sokhachtrongphong;
        public Voucher (int maphieuthuephong,DateTime? ngaybatdauthue,int maphong, float dongiathue1ngay,int sokhachtrongphong)
        {
            this.Maphieuthuephong = maphieuthuephong;
            this.Ngaybatdauthue = ngaybatdauthue;
            this.Maphong = maphong;
            this.Dongiathue1ngay = dongiathue1ngay;
            this.Sokhachtrongphong = sokhachtrongphong;
        }
        public Voucher(DataRow row)
        {
            this.Maphieuthuephong = (int)row["maphieuthuephong"];
            this.Ngaybatdauthue = (DateTime?)row["ngaybatdauthue"];
            this.Maphong = (int)row["maphong"];
            this.Dongiathue1ngay = (float)Convert.ToDouble(row["dongiathue1ngay"]);
            this.Sokhachtrongphong = (int)row["sokhachtrongphong"];
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

        public DateTime? Ngaybatdauthue
        {
            get
            {
                return ngaybatdauthue;
            }

            set
            {
                ngaybatdauthue = value;
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

        public float Dongiathue1ngay
        {
            get
            {
                return dongiathue1ngay;
            }

            set
            {
                dongiathue1ngay = value;
            }
        }

        public int Sokhachtrongphong
        {
            get
            {
                return sokhachtrongphong;
            }

            set
            {
                sokhachtrongphong = value;
            }
        }
    }
}
