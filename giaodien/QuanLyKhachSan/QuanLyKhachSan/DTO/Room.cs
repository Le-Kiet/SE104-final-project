using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Room
    {
        public Room (int maphong, string tenphong, string maloaiphong)
        {
            this.Maphong = maphong;
            this.Tenphong = tenphong;
            this.Maloaiphong = maloaiphong;
            this.Tinhtrangphong = tinhtrangphong;
        }
        public Room(DataRow row)
        {
            this.Maphong = (int)row["maphong"];
            this.Tenphong = row["tenphong"].ToString();
            this.Maloaiphong = row["maloaiphong"].ToString();
            this.Tinhtrangphong = row["tinhtrangphong"].ToString();
        }

        private int maphong;
        private string tenphong;
        private string maloaiphong;
        private string tinhtrangphong;

        public int Maphong
        {
            get {return maphong;}
            set {maphong = value;}
        }
        public string Tenphong
        {
            get { return tenphong; }
            set { tenphong = value; }
        }
        public string Maloaiphong
        {
            get { return maloaiphong; }
            set { maloaiphong = value; }
        }

        public string Tinhtrangphong
        {
            get
            {
                return tinhtrangphong;
            }

            set
            {
                tinhtrangphong = value;
            }
        }
    }
}
