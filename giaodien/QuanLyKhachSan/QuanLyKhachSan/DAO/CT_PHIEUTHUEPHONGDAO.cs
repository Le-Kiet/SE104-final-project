using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class CT_PhieuThuePhongDAO
    {
        private static CT_PhieuThuePhongDAO instance;

        public static CT_PhieuThuePhongDAO Instance
        {
            get
            {
                if (instance == null) instance = new CT_PhieuThuePhongDAO(); return CT_PhieuThuePhongDAO.instance;
            }
            private set
            {
                CT_PhieuThuePhongDAO.instance = value;
            }
        }
        private CT_PhieuThuePhongDAO() { }
        public bool CreateCT_PhieuThuePhong(CT_PhieuThuePhong ct_phieuThuePhong)
        {
            string getMaxIdQuery = "SELECT MAX(MaPhieuThuePhong) FROM PHIEUTHUEPHONG";
            int maxId = DataProvider.Instance.ExecuteScalarInt(getMaxIdQuery); // Hàm ExecuteScalar lấy giá trị duy nhất từ câu truy vấn SELECT
            string query = "INSERT INTO CT_PHIEUTHUEPHONG ( MaPhieuThuePhong , MaLoaiKhach, CMND, TenKhachHang, DiaChi) VALUES ( @maPhieuThuePhong , @maLoaiKhach , @cmnd , @tenKhachHang , @diaChi )";

            object[] parameters = new object[]
            {
                maxId,
                ct_phieuThuePhong.MaLoaiKhach,
                ct_phieuThuePhong.CMND,
                ct_phieuThuePhong.TenKhachHang,
                ct_phieuThuePhong.DiaChi
            };

            Boolean result = DataProvider.Instance.ExecuteInsert(query, parameters);

            return result;
        }

    }
}