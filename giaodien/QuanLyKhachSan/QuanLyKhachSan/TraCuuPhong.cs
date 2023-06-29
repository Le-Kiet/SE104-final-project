using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class TraCuuPhg : Form
    {
        public TraCuuPhg()
        {
            InitializeComponent();
            LoadFindRoomList();
        }

        void LoadFindRoomList()
        {
            string query = "select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong";
            dtgvFindRoom.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        //private void tbTenPhg_TextChanged(object sender, EventArgs e)
        //{
        //    tbTenLphg.Text = "";
        //    cbTinhTrang.Text = "";
        //}

        //private void tbTenLphg_TextChanged(object sender, EventArgs e)
        //{
        //    tbTenPhg.Text = "";
        //    cbTinhTrang.Text = "";
        //}

        //private void tbTinhTrag_TextChanged(object sender, EventArgs e)
        //{
        //    tbTenPhg.Text = "";
        //    tbTenLphg.Text = "";
        //}

        private void btnFindRoom_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IBEFT826\\SQLEXPRESS;Initial Catalog=QLKS2;Integrated Security=True");
            DataTable dt = new DataTable();
            if (tbTenPhg.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong AND DANHMUCPHONG.TenPhong LIKE N'" + tbTenPhg.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (tbTenLphg.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong AND LOAIPHONG.TenLoaiPhong LIKE N'" + tbTenLphg.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (cbTinhTrang.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong AND DANHMUCPHONG.TinhTrangPhong LIKE N'" + cbTinhTrang.Text + "%'", con);
                sda.Fill(dt);
            }

            else if (tbTenPhg.Text.Length == 0 && tbTenLphg.Text.Length == 0 && cbTinhTrang.Text.Length == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong", con);
                sda.Fill(dt);
            }

            dtgvFindRoom.DataSource = dt;
        }

        private void btnFindRoom_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QLKS1;Integrated Security=True");
            DataTable dt = new DataTable();
            if (tbTenPhg.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong AND DANHMUCPHONG.TenPhong LIKE N'" + tbTenPhg.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (tbTenLphg.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong AND LOAIPHONG.TenLoaiPhong LIKE N'" + tbTenLphg.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (cbTinhTrang.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong AND DANHMUCPHONG.TinhTrangPhong LIKE N'" + cbTinhTrang.Text + "%'", con);
                sda.Fill(dt);
            }

            else if (tbTenPhg.Text.Length == 0 && tbTenLphg.Text.Length == 0 && cbTinhTrang.Text.Length == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select DANHMUCPHONG.TenPhong, LOAIPHONG.TenLoaiPhong,LOAIPHONG.DonGia, DANHMUCPHONG.TinhTrangPhong\r\nfrom DANHMUCPHONG, LOAIPHONG\r\nwhere DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong", con);
                sda.Fill(dt);
            }
            
            dtgvFindRoom.DataSource = dt;
        }
    }
}
