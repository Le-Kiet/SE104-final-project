using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class PhieuThuePhongDAO
    {
        private static PhieuThuePhongDAO instance;

        public static PhieuThuePhongDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuePhongDAO(); return PhieuThuePhongDAO.instance;
            }
            private set
            {
                PhieuThuePhongDAO.instance = value;
            }
        }
        private PhieuThuePhongDAO() { }
        public bool CreatePhieuThuePhong(PhieuThuePhong phieuThuePhong)
        {
            string getMaxIdQuery = "SELECT MAX(MaPhieuThuePhong) FROM PHIEUTHUEPHONG";
            int maxId = DataProvider.Instance.ExecuteScalarInt(getMaxIdQuery); // Hàm ExecuteScalar lấy giá trị duy nhất từ câu truy vấn SELECT
            int newId = maxId + 1;
            string query = "INSERT INTO PHIEUTHUEPHONG (MaPhieuThuePhong, MaPhong, DonGiaThue1Ngay, SoKhachTrongPhong, NgayBatDauThue) " +
                           "VALUES ( @maPhieuThuePhong , @maPhong , @donGiaThue , @soKhachTrongPhong , @ngayBatDauThue )";

            object[] parameters = new object[]
            {
                newId,
                phieuThuePhong.MaPhong,
                phieuThuePhong.DonGiaThue1Ngay,
                phieuThuePhong.SoKhachTrongPhong,
                phieuThuePhong.NgayBatDauThue
            };

            bool result = DataProvider.Instance.ExecuteInsert(query, parameters);

            return result;
        }


    }
}
