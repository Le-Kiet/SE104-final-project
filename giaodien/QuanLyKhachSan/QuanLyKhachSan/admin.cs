using QuanLyKhachSan;
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
    public partial class admin : Form
    {

        BindingSource roomList = new BindingSource();
        BindingSource kindList = new BindingSource();
        BindingSource guestkindList = new BindingSource();
        public admin()
        {
            InitializeComponent();
            loadAccountlist();
            LoadListRoom();
            AddRoomBinding();
            LoadKindList();
            AddKindBinding();
            LoadKindGuest();
            AddKindGuestBinding();
            LoadDateTimePickerBill();
            LoadListBillByDate(dateTimePickerfromDate.Value, dateTimePickerToDate.Value);
            loadListTiLePhuThu();
            AddTiLePhuThuBinding();
        }
        void loadAccountlist()
        {           
            string query = "exec USP_GetListAccount @Username";

            //     select * from dbo.TAIKHOAN where @Username = Username       DataProvider provider = new Dataprovider();

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "Minh" });

        }
        void LoadListRoom()
        {
            dtgvRoom.DataSource = roomList;
            roomList.DataSource = RoomDAO.Instance.LoadRoomList();
        }
        void LoadKindList()
        {
            dtgvLoaiphong.DataSource = kindList;
            kindList.DataSource = KindOfRoomDAO.Instance.LoadKindList();
        }
        void LoadKindGuest()
        {
            dtgvKindGuest.DataSource = guestkindList;

            guestkindList.DataSource = KindGuestDAO.Instance.LoadKindGuestList();
        }
        void loadListTiLePhuThu()
        {
            dtgvTLPT.DataSource = TiLePhuThuDAO.Instance.LoadTiLePhuThuList();
        }
        void AddTiLePhuThuBinding()
        {
            tbKhachThu.DataBindings.Add(new Binding("Text", dtgvTLPT.DataSource, "KhachThuBaoNhieu", true, DataSourceUpdateMode.Never));
            tbTiLePhuThu.DataBindings.Add(new Binding("Text", dtgvTLPT.DataSource, "TiLe", true, DataSourceUpdateMode.Never));
        }
        void AddRoomBinding()
        {
            textBox1.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "MaPhong"));
            comboBoxStatus.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "TinhTrangPhong"));
            tbRoomName.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "TenPhong"));
            tbKindOfRoom.DataBindings.Add(new Binding("Text", dtgvRoom.DataSource, "MaLoaiPhong"));
        }
        void AddKindBinding()
        {
            tbMaloaiphong.DataBindings.Add(new Binding("Text", dtgvLoaiphong.DataSource, "MaLoaiPhong"));
            tbTenloaiphong.DataBindings.Add(new Binding("Text", dtgvLoaiphong.DataSource, "TenLoaiPhong"));
            tbDongia.DataBindings.Add(new Binding("Text", dtgvLoaiphong.DataSource, "DonGia"));
        }
        void AddKindGuestBinding()
        {
            tbMaloaikhach.DataBindings.Add(new Binding("Text", dtgvKindGuest.DataSource, "MaLoaiKhach"));
            tbTenloaikhach.DataBindings.Add(new Binding("Text", dtgvKindGuest.DataSource, "TenLoaiKhach"));
            tbHesophuthu.DataBindings.Add(new Binding("Text", dtgvKindGuest.DataSource, "HeSoPhuThu"));
        }

        private void tpRoom_Click(object sender, DataGridViewImageCell e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textBox1.Text = Convert.ToString(dtgvRoom.CurrentRow.Cells["MaPhong"].Value);
                tbKindOfRoom.Text = Convert.ToString(dtgvRoom.CurrentRow.Cells["MaLoaiPhong"].Value);
                tbRoomName.Text = Convert.ToString(dtgvRoom.CurrentRow.Cells["TenPhong"].Value);
                comboBoxStatus.Text = Convert.ToString(dtgvRoom.CurrentRow.Cells["TinhTrangPhong"].Value);
            }
        }
        private void tpKind_Click(object sendar, DataGridViewImageCell e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbMaloaiphong.Text = Convert.ToString(dtgvLoaiphong.CurrentRow.Cells["MaLoaiPhong"].Value);
                tbTenloaiphong.Text = Convert.ToString(dtgvLoaiphong.CurrentRow.Cells["TenPhong"].Value);
                tbDongia.Text = Convert.ToString(dtgvLoaiphong.CurrentRow.Cells["DonGia"].Value);
            }
        }
        private void tpKindGuest_Click(object sendar, DataGridViewImageCell e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbMaloaikhach.Text = Convert.ToString(dtgvKindGuest.CurrentRow.Cells["MaLoaiKhach"].Value);
                tbTenloaikhach.Text = Convert.ToString(dtgvKindGuest.CurrentRow.Cells["TenLoaiKhach"].Value);
                tbHesophuthu.Text = Convert.ToString(dtgvKindGuest.CurrentRow.Cells["HeSoPhuThu"].Value);
            }
        }
        // BTN ADD, UPDATE, DELETE ROOM
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int MaPhong = Convert.ToInt32(textBox1.Text);
            string TenPhong = tbRoomName.Text;
            string MaLoaiPhong = tbKindOfRoom.Text;
            string TinhTrangPhong = comboBoxStatus.Text;

            if (RoomDAO.Instance.InsertRoom(MaPhong, TenPhong, MaLoaiPhong, TinhTrangPhong))
            {
                MessageBox.Show("Thêm thành công");
                LoadListRoom();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            int MaPhong = Convert.ToInt32(textBox1.Text);
            string TenPhong = tbRoomName.Text;
            string MaLoaiPhong = tbKindOfRoom.Text;
            string TinhTrangPhong = comboBoxStatus.Text;

            if (RoomDAO.Instance.UpdateRoom(MaLoaiPhong, TinhTrangPhong, TenPhong, MaPhong))
            {
                MessageBox.Show("Sửa thành công");
                LoadListRoom();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            int MaPhong = Convert.ToInt32(textBox1.Text);


            if (RoomDAO.Instance.DeleteRoom(MaPhong))
            {
                MessageBox.Show("Xoá thành công");
                LoadListRoom();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }
        private void btInsertKind_Click(object sender, EventArgs e)
        {
            string TenLoaiPhong = tbTenloaiphong.Text;
            string MaLoaiPhong = tbMaloaiphong.Text;
            int DonGia = Convert.ToInt32(tbDongia.Text);

            if (KindOfRoomDAO.Instance.InsertKind(MaLoaiPhong, TenLoaiPhong, DonGia))
            {
                MessageBox.Show("Thêm thành công");
                LoadKindList();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void btUpdateKind_Click(object sender, EventArgs e)
        {
            string TenLoaiPhong = tbTenloaiphong.Text;
            string MaLoaiPhong = tbMaloaiphong.Text;
            int DonGia = Convert.ToInt32(tbDongia.Text);

            if (KindOfRoomDAO.Instance.UpdateKind(MaLoaiPhong, TenLoaiPhong, DonGia))
            {
                MessageBox.Show("Sửa thành công");
                LoadKindList();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        private void btDeleteKind_Click(object sender, EventArgs e)
        {
            string MaLoaiPhong = tbMaloaiphong.Text;


            if (KindOfRoomDAO.Instance.DeleteKind(MaLoaiPhong))
            {
                MessageBox.Show("Xoá thành công");
                //LoadKindList();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }
        private void btAddKindGuest_Click(object sender, EventArgs e)
        {
            string MaLoaiKhach = tbMaloaikhach.Text;
            string TenLoaiKhach = tbTenloaikhach.Text;
            float HeSoPhuThu = (float)Convert.ToDouble(tbHesophuthu.Text);

            if (KindGuestDAO.Instance.InsertKindGuest(MaLoaiKhach, TenLoaiKhach, HeSoPhuThu))
            {
                MessageBox.Show("Thêm thành công");
                LoadKindGuest();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        private void btUpdateKindGuest_Click(object sender, EventArgs e)
        {
            string MaLoaiKhach = tbMaloaikhach.Text;
            string TenLoaiKhach = tbTenloaikhach.Text;
            float HeSoPhuThu = (float)Convert.ToDouble(tbHesophuthu.Text);

            if (KindGuestDAO.Instance.UpdateKindGuest(MaLoaiKhach, TenLoaiKhach, HeSoPhuThu))
            {
                MessageBox.Show("Sửa thành công");
                LoadKindGuest();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        private void btDeleteKindGuest_Click(object sender, EventArgs e)
        {
            string MaLoaiKhach = tbMaloaikhach.Text;
            string TenLoaiKhach = tbTenloaikhach.Text;
            float HeSoPhuThu = (float)Convert.ToDouble(tbHesophuthu.Text);

            if (KindGuestDAO.Instance.DeleteKindGuest(MaLoaiKhach))
            {
                MessageBox.Show("Xoá thành công");
                LoadKindGuest();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickerfromDate.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerToDate.Value = dateTimePickerfromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

        }
        private void btnViewRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

        }
        private void tbRoomStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void tpRoom_Click(object sender, EventArgs e)
        {

        }

        private void btSerach_Click(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenloaiphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvLoaiphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbMaloaiphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtgvKindGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tpBill_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int khachhangthu = Convert.ToInt32(tbKhachThu.Text);
            float tile = (float)Convert.ToDouble(tbTiLePhuThu.Text);

            if (TiLePhuThuDAO.Instance.InsertTiLePhuThu(khachhangthu, tile))
            {
                MessageBox.Show("Them ti le phu thu thanh cong");
                loadListTiLePhuThu();
            }
            else
            {
                MessageBox.Show("Them ti le phu thu khong thanh cong");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int khachhangthu = Convert.ToInt32(tbKhachThu.Text);
            float tile = (float)Convert.ToDouble(tbTiLePhuThu.Text);


            if (TiLePhuThuDAO.Instance.UpdateTiLePhuThu(khachhangthu, tile))
            {
                MessageBox.Show("Sua ti le phu thu thanh cong");
                loadListTiLePhuThu();
            }
            else
            {
                MessageBox.Show("Sua ti le phu thu khong thanh cong");
            }
        }


        /*private class Dataprovider : DataProvider
        {
            public Dataprovider()
            {
            }
        }*/
    }
}
