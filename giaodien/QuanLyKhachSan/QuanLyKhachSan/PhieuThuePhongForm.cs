using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.DAO;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class PhieuThuePhongForm : Form
    {
        public PhieuThuePhongForm()
        {

            InitializeComponent();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PhieuThuePhong_Load(int maphong)
        {
            //// TODO: This line of code loads data into the 'quanLyKhachSanDataSet.DANHMUCPHONG' table. You can move, or remove it, as needed.
            //this.dANHMUCPHONGTableAdapter.Fill(this.quanLyKhachSanDataSet.DANHMUCPHONG);
            //// TODO: This line of code loads data into the 'quanLyKhachSanDataSet.TILEPHUTHU' table. You can move, or remove it, as needed.
            //this.tILEPHUTHUTableAdapter.Fill(this.quanLyKhachSanDataSet.TILEPHUTHU);
            //// TODO: This line of code loads data into the 'quanLyKhachSanDataSet.LOAIKHACHHANG' table. You can move, or remove it, as needed.
            //this.lOAIKHACHHANGTableAdapter.Fill(this.quanLyKhachSanDataSet.LOAIKHACHHANG);
            //loaiKhach1.DropDownStyle = ComboBoxStyle.DropDownList;
            //loaiKhach2.DropDownStyle = ComboBoxStyle.DropDownList;
            //loaiKhach3.DropDownStyle = ComboBoxStyle.DropDownList;            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int maPhong = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            float donGia = RoomDAO.Instance.GetDonGiaTheoPhong(maPhong);
            String Phong = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tenPhong.Text = Phong.ToString();
            giaPhong.Text = donGia.ToString();
        }
        private void themKhach_Click(object sender, EventArgs e)
        {

            if (khach3.Visible)
            {
                MessageBox.Show("Chỉ được tối đa 3 khách trong 1 phòng.", "Cảnh báo", MessageBoxButtons.OK);
            }
            if (khach2.Visible == false)
            {
                soKhach.SelectedValue = "2";
                khach2.Visible = true;
            }
            else
            {
                soKhach.SelectedValue = "3";
                khach3.Visible = true;
            }
        }

        private void xoaKhach_Click(object sender, EventArgs e)
        {
            if (khach3.Visible)
            {
                khach3.Visible = false;
                soKhach.SelectedValue = "2";
            }
            else
            {
                khach2.Visible = false;
                soKhach.SelectedValue = "1";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void doiPhong_Click(object sender, EventArgs e)
        {
            TableManager f = new TableManager();
            this.Hide();
            f.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void quanLyKhachSanDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void insertCTPhieuThue(System.Windows.Forms.ComboBox box, System.Windows.Forms.TextBox cmnd, System.Windows.Forms.TextBox name, System.Windows.Forms.TextBox diaChi)
        {
            string maLoai = box.SelectedValue.ToString();
            string cm = cmnd.Text.ToString();
            string tenKhach = name.Text.ToString();
            string dc = diaChi.Text.ToString();
            CT_PhieuThuePhong ct_phieu = new CT_PhieuThuePhong(maLoai, cm, tenKhach, dc);
            Boolean KtrCT = CT_PhieuThuePhongDAO.Instance.CreateCT_PhieuThuePhong(ct_phieu);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tinhTrang = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int maPhong = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                float donGia = RoomDAO.Instance.GetDonGiaTheoPhong(maPhong);
                String tenPhong = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                if (tinhTrang == "Trống")
                {
                    int khach;
                    if (soKhach.SelectedValue.ToString() == "1")
                    {
                        khach = 1;
                    }
                    else if (soKhach.SelectedValue.ToString() == "2")
                    {
                        khach = 2;
                    }
                    else khach = 3;
                    string ngay = ngayThuePhong.Value.ToString("yyyy-MM-dd");
                    PhieuThuePhong phieuThuePhong = new PhieuThuePhong(maPhong, donGia, khach, ngay);
                    Boolean ktr = PhieuThuePhongDAO.Instance.CreatePhieuThuePhong(phieuThuePhong);
                    insertCTPhieuThue(loaiKhach1, cmnd1, name1, diaChi1);
                    if (khach == 2)
                    {
                        insertCTPhieuThue(loaiKhach2, cmnd2, name2, diaChi2);
                    }
                    if (khach == 3)
                    {
                        insertCTPhieuThue(loaiKhach2, cmnd2, name2, diaChi2);
                        insertCTPhieuThue(loaiKhach3, cmnd3, name3, diaChi3);
                    }
                    RoomDAO.Instance.CapNhatTinhTrangPhong(maPhong, "Có Người");
                    MessageBox.Show("Đã lập phiếu thuê phòng.", "Thông báo", MessageBoxButtons.OK);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Phòng đã có người đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void input_cmnd(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void input_name(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void name2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void cmnd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
        private void name3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
        private void cmnd3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            int maPhong = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            float donGia = RoomDAO.Instance.GetDonGiaTheoPhong(maPhong);
            String Phong = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tenPhong.Text = Phong.ToString();
            giaPhong.Text = donGia.ToString();
        }

        private void PhieuThuePhongForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.LOAIKHACHHANG' table. You can move, or remove it, as needed.
            //this.lOAIKHACHHANGTableAdapter.Fill(this.quanLyKhachSanDataSet.LOAIKHACHHANG);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.TILEPHUTHU' table. You can move, or remove it, as needed.
            //this.tILEPHUTHUTableAdapter.Fill(this.quanLyKhachSanDataSet.TILEPHUTHU);
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.DANHMUCPHONG' table. You can move, or remove it, as needed.
            //this.dANHMUCPHONGTableAdapter.Fill(this.quanLyKhachSanDataSet.DANHMUCPHONG);

        }
    }
}
