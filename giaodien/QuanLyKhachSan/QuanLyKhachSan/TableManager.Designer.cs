namespace QuanLyKhachSan
{
    partial class TableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhòngTrốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLoạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuThuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listVoucher1 = new System.Windows.Forms.ListView();
            this.clMaLoaiKhach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenKhachHang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSwitchRoom = new System.Windows.Forms.Button();
            this.cbSwitchRoomNew = new System.Windows.Forms.ComboBox();
            this.cbSwitchRoomOld = new System.Windows.Forms.ComboBox();
            this.traCứuPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcPhòngToolStripMenuItem,
            this.phiếuThuêPhòngToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.đặtPhòngToolStripMenuItem,
            this.traCứuPhòngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(916, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcPhòngToolStripMenuItem
            // 
            this.danhMụcPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhòngTrốngToolStripMenuItem,
            this.danhSáchLoạiPhòngToolStripMenuItem});
            this.danhMụcPhòngToolStripMenuItem.Name = "danhMụcPhòngToolStripMenuItem";
            this.danhMụcPhòngToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.danhMụcPhòngToolStripMenuItem.Text = "Danh mục phòng";
            // 
            // danhSáchPhòngTrốngToolStripMenuItem
            // 
            this.danhSáchPhòngTrốngToolStripMenuItem.Name = "danhSáchPhòngTrốngToolStripMenuItem";
            this.danhSáchPhòngTrốngToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.danhSáchPhòngTrốngToolStripMenuItem.Text = "Tổng quan";
            // 
            // danhSáchLoạiPhòngToolStripMenuItem
            // 
            this.danhSáchLoạiPhòngToolStripMenuItem.Name = "danhSáchLoạiPhòngToolStripMenuItem";
            this.danhSáchLoạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.danhSáchLoạiPhòngToolStripMenuItem.Text = "Danh sách loại phòng";
            this.danhSáchLoạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLoạiPhòngToolStripMenuItem_Click);
            // 
            // phiếuThuêPhòngToolStripMenuItem
            // 
            this.phiếuThuêPhòngToolStripMenuItem.Name = "phiếuThuêPhòngToolStripMenuItem";
            this.phiếuThuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.phiếuThuêPhòngToolStripMenuItem.Text = "Hóa đơn";
            this.phiếuThuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.phiếuThuêPhòngToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            this.đặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // flpTable
            // 
            this.flpTable.AllowDrop = true;
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 37);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(460, 507);
            this.flpTable.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listVoucher1);
            this.panel1.Location = new System.Drawing.Point(478, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 414);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết phiêu thuê phòng";
            // 
            // listVoucher1
            // 
            this.listVoucher1.BackColor = System.Drawing.Color.White;
            this.listVoucher1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaLoaiKhach,
            this.clCMND,
            this.clTenKhachHang,
            this.clDiaChi});
            this.listVoucher1.GridLines = true;
            this.listVoucher1.Location = new System.Drawing.Point(3, 51);
            this.listVoucher1.Name = "listVoucher1";
            this.listVoucher1.Size = new System.Drawing.Size(418, 359);
            this.listVoucher1.TabIndex = 0;
            this.listVoucher1.UseCompatibleStateImageBehavior = false;
            this.listVoucher1.View = System.Windows.Forms.View.Details;
            // 
            // clMaLoaiKhach
            // 
            this.clMaLoaiKhach.Text = "Mã loại khách";
            // 
            // clCMND
            // 
            this.clCMND.Text = "CMND";
            // 
            // clTenKhachHang
            // 
            this.clTenKhachHang.Text = "Tên khách hàng";
            this.clTenKhachHang.Width = 200;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Text = "Địa chỉ";
            this.clDiaChi.Width = 300;
            // 
            // btnSwitchRoom
            // 
            this.btnSwitchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchRoom.Location = new System.Drawing.Point(478, 457);
            this.btnSwitchRoom.Name = "btnSwitchRoom";
            this.btnSwitchRoom.Size = new System.Drawing.Size(247, 38);
            this.btnSwitchRoom.TabIndex = 57;
            this.btnSwitchRoom.Text = "Chuyển phòng";
            this.btnSwitchRoom.UseVisualStyleBackColor = true;
            this.btnSwitchRoom.Click += new System.EventHandler(this.btnSwitchRoom_Click);
            // 
            // cbSwitchRoomNew
            // 
            this.cbSwitchRoomNew.DropDownWidth = 169;
            this.cbSwitchRoomNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwitchRoomNew.FormattingEnabled = true;
            this.cbSwitchRoomNew.Location = new System.Drawing.Point(478, 504);
            this.cbSwitchRoomNew.Name = "cbSwitchRoomNew";
            this.cbSwitchRoomNew.Size = new System.Drawing.Size(118, 33);
            this.cbSwitchRoomNew.TabIndex = 58;
            // 
            // cbSwitchRoomOld
            // 
            this.cbSwitchRoomOld.DropDownWidth = 169;
            this.cbSwitchRoomOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwitchRoomOld.FormattingEnabled = true;
            this.cbSwitchRoomOld.Location = new System.Drawing.Point(607, 504);
            this.cbSwitchRoomOld.Name = "cbSwitchRoomOld";
            this.cbSwitchRoomOld.Size = new System.Drawing.Size(118, 33);
            this.cbSwitchRoomOld.TabIndex = 59;
            // 
            // traCứuPhòngToolStripMenuItem
            // 
            this.traCứuPhòngToolStripMenuItem.Name = "traCứuPhòngToolStripMenuItem";
            this.traCứuPhòngToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.traCứuPhòngToolStripMenuItem.Text = "Tra cứu phòng";
            this.traCứuPhòngToolStripMenuItem.Click += new System.EventHandler(this.traCứuPhòngToolStripMenuItem_Click);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 549);
            this.Controls.Add(this.cbSwitchRoomOld);
            this.Controls.Add(this.cbSwitchRoomNew);
            this.Controls.Add(this.btnSwitchRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý khách sạn";
            this.Load += new System.EventHandler(this.TableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngTrốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuThuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLoạiPhòngToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listVoucher1;
        private System.Windows.Forms.ColumnHeader clMaLoaiKhach;
        private System.Windows.Forms.ColumnHeader clCMND;
        private System.Windows.Forms.ColumnHeader clTenKhachHang;
        private System.Windows.Forms.ColumnHeader clDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSwitchRoom;
        private System.Windows.Forms.ComboBox cbSwitchRoomNew;
        private System.Windows.Forms.ComboBox cbSwitchRoomOld;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuPhòngToolStripMenuItem;
    }
}