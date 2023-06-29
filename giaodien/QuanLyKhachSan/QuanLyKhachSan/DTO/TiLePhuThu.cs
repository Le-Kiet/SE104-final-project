using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class TiLePhuThu
    {
        public TiLePhuThu(int khachthubaonhieu, float tile)
        {
            this.khachthubaonhieu = khachthubaonhieu;
            this.tile = tile;
        }
        public TiLePhuThu(DataRow row)
        {
            this.KhachThuBaoNhieu = (int)row["KhachThuBaoNhieu"];
            this.TiLe = (float.Parse(row["TiLePhuThu"].ToString()));
        }

        private int khachthubaonhieu;
        private float tile;

        public int KhachThuBaoNhieu
        {
            get { return khachthubaonhieu; }
            set { khachthubaonhieu = value; }
        }
        public float TiLe
        {
            get { return tile; }
            set { tile = value; }
        }
    }
}
