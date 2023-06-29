using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class RoomRentVoucher : Form
    {
        public RoomRentVoucher()
        {
            InitializeComponent();
            loadRoomRentVoucher();
        }
        void loadRoomRentVoucher()
        {
            string query = "select MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue, (DATEDIFF ( DD ,  convert(date,NgayBatDauThue), convert(date,getdate())) +1) as SoNgayO , (DATEDIFF ( DD ,  convert(date,NgayBatDauThue), convert(date,getdate())) + 1) * DonGiaThue1Ngay as ThanhTien \r\nfrom PHIEUTHUEPHONG ";
            dgvRoomRentVoucher.DataSource = DataProvider.Instance.ExecuteQuery(query);
            DataGridViewCheckBoxColumn checkboxcol = new DataGridViewCheckBoxColumn();
            checkboxcol.Width = 50;
            checkboxcol.Name = "check1";
            checkboxcol.HeaderText = "checked";
            dgvRoomRentVoucher.Columns.Insert(0, checkboxcol);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewCheckBoxColumn checkboxcol = new DataGridViewCheckBoxColumn();
            checkboxcol.Width = 50;
            checkboxcol.Name = "check1";
            checkboxcol.HeaderText = "checked";
            dataGridView2.Columns.Insert(0, checkboxcol);
            dt.Columns.Add("MaPhieuThuePhong");
            dt.Columns.Add("MaPhong");
            dt.Columns.Add("DonGiaThue1Ngay");
            dt.Columns.Add("SoKhachTrongPhong");
            dt.Columns.Add("NgayBatDauThue");
            dt.Columns.Add("SoNgay");
            dt.Columns.Add("Thanh Tien");
            int total = 0;
            foreach (DataGridViewRow drv in dgvRoomRentVoucher.Rows)
            {
                bool isselect = Convert.ToBoolean(drv.Cells["check1"].Value);

                if (isselect)
                {
                    dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value, drv.Cells[5].Value, drv.Cells[6].Value, drv.Cells[7].Value);
                    total = total + Convert.ToInt32(drv.Cells[7].Value);
                }
                dataGridView2.DataSource = dt;
            }
            tbTotal.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mhdon = Convert.ToInt32(tbBill.Text);
            string tenkh = tbCustomer.Text;
            string DiaChi = tbAdress.Text;
            int TongTien = Convert.ToInt32(tbTotal.Text);
            BillDAO.Instance.InsertBill(mhdon, tenkh, DiaChi, TongTien);
            foreach (DataGridViewRow drv in dataGridView2.Rows)
            {
                bool isselect = Convert.ToBoolean(drv.Cells["check1"].Value);
                if (isselect)
                {
                    int maPhieuInt = Convert.ToInt32(drv.Cells[1].Value.ToString());
                    int maPhieu = Convert.ToInt32(maPhieuInt);
                    int soNgay = Convert.ToInt32(drv.Cells[6].Value.ToString());
                    float soTienTgPhieu = Convert.ToInt32(drv.Cells[7].Value.ToString());
                    BillInfoDAO.Instance.InsertBillInfo(maPhieuInt, mhdon, soNgay, soTienTgPhieu);
                }
            }
        }
    }
}
