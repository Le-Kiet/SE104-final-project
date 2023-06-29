namespace QuanLyKhachSan
{
    partial class PhieuThuePhongForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dANHMUCPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet = new QuanLyKhachSan.QuanLyKhachSanDataSet();
            this.soKhach = new System.Windows.Forms.ComboBox();
            this.tILEPHUTHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giaPhong = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tenPhong = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ngayThuePhong = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.xoaKhach = new System.Windows.Forms.Button();
            this.themKhach = new System.Windows.Forms.Button();
            this.khach3 = new System.Windows.Forms.Panel();
            this.diaChi3 = new System.Windows.Forms.TextBox();
            this.loaiKhach3 = new System.Windows.Forms.ComboBox();
            this.cmnd3 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.khach2 = new System.Windows.Forms.Panel();
            this.diaChi2 = new System.Windows.Forms.TextBox();
            this.loaiKhach2 = new System.Windows.Forms.ComboBox();
            this.cmnd2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.khach1 = new System.Windows.Forms.Panel();
            this.diaChi1 = new System.Windows.Forms.TextBox();
            this.loaiKhach1 = new System.Windows.Forms.ComboBox();
            this.cmnd1 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doiPhong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dANHMUCPHONGTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters.DANHMUCPHONGTableAdapter();
            this.tILEPHUTHUTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters.TILEPHUTHUTableAdapter();
            this.lOAIKHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIKHACHHANGTableAdapter = new QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters.LOAIKHACHHANGTableAdapter();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tILEPHUTHUBindingSource)).BeginInit();
            this.khach3.SuspendLayout();
            this.khach2.SuspendLayout();
            this.khach1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.maLoaiPhongDataGridViewTextBoxColumn,
            this.tinhTrangPhongDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dANHMUCPHONGBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 489);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 185);
            this.dataGridView1.TabIndex = 34;
            // 
            // dANHMUCPHONGBindingSource
            // 
            this.dANHMUCPHONGBindingSource.DataMember = "DANHMUCPHONG";
            this.dANHMUCPHONGBindingSource.DataSource = this.quanLyKhachSanDataSetBindingSource;
            // 
            // quanLyKhachSanDataSetBindingSource
            // 
            this.quanLyKhachSanDataSetBindingSource.DataSource = this.quanLyKhachSanDataSet;
            this.quanLyKhachSanDataSetBindingSource.Position = 0;
            // 
            // quanLyKhachSanDataSet
            // 
            this.quanLyKhachSanDataSet.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soKhach
            // 
            this.soKhach.DataSource = this.tILEPHUTHUBindingSource;
            this.soKhach.DisplayMember = "KhachThuBaoNhieu";
            this.soKhach.Enabled = false;
            this.soKhach.FormattingEnabled = true;
            this.soKhach.Location = new System.Drawing.Point(771, 441);
            this.soKhach.Margin = new System.Windows.Forms.Padding(4);
            this.soKhach.Name = "soKhach";
            this.soKhach.Size = new System.Drawing.Size(160, 24);
            this.soKhach.TabIndex = 33;
            this.soKhach.ValueMember = "TiLePhuThu";
            // 
            // tILEPHUTHUBindingSource
            // 
            this.tILEPHUTHUBindingSource.DataMember = "TILEPHUTHU";
            this.tILEPHUTHUBindingSource.DataSource = this.quanLyKhachSanDataSetBindingSource;
            // 
            // giaPhong
            // 
            this.giaPhong.AutoSize = true;
            this.giaPhong.Location = new System.Drawing.Point(394, 445);
            this.giaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.Size = new System.Drawing.Size(0, 17);
            this.giaPhong.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(275, 445);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Đơn Giá Phòng:";
            // 
            // tenPhong
            // 
            this.tenPhong.AutoSize = true;
            this.tenPhong.Location = new System.Drawing.Point(125, 445);
            this.tenPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.Size = new System.Drawing.Size(0, 17);
            this.tenPhong.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 445);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tên Phòng:";
            // 
            // ngayThuePhong
            // 
            this.ngayThuePhong.CustomFormat = "yyyy-MM-dd";
            this.ngayThuePhong.Location = new System.Drawing.Point(657, 8);
            this.ngayThuePhong.Margin = new System.Windows.Forms.Padding(4);
            this.ngayThuePhong.Name = "ngayThuePhong";
            this.ngayThuePhong.Size = new System.Drawing.Size(275, 22);
            this.ngayThuePhong.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(519, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ngày Thuê Phòng:";
            // 
            // xoaKhach
            // 
            this.xoaKhach.Location = new System.Drawing.Point(195, 4);
            this.xoaKhach.Margin = new System.Windows.Forms.Padding(4);
            this.xoaKhach.Name = "xoaKhach";
            this.xoaKhach.Size = new System.Drawing.Size(165, 28);
            this.xoaKhach.TabIndex = 26;
            this.xoaKhach.Text = "Xóa Khách";
            this.xoaKhach.UseVisualStyleBackColor = true;
            // 
            // themKhach
            // 
            this.themKhach.Location = new System.Drawing.Point(31, 4);
            this.themKhach.Margin = new System.Windows.Forms.Padding(4);
            this.themKhach.Name = "themKhach";
            this.themKhach.Size = new System.Drawing.Size(156, 28);
            this.themKhach.TabIndex = 25;
            this.themKhach.Text = "Thêm Khách";
            this.themKhach.UseVisualStyleBackColor = true;
            // 
            // khach3
            // 
            this.khach3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khach3.Controls.Add(this.diaChi3);
            this.khach3.Controls.Add(this.loaiKhach3);
            this.khach3.Controls.Add(this.cmnd3);
            this.khach3.Controls.Add(this.name3);
            this.khach3.Controls.Add(this.label9);
            this.khach3.Controls.Add(this.label10);
            this.khach3.Controls.Add(this.label11);
            this.khach3.Controls.Add(this.label12);
            this.khach3.Location = new System.Drawing.Point(30, 302);
            this.khach3.Margin = new System.Windows.Forms.Padding(4);
            this.khach3.Name = "khach3";
            this.khach3.Size = new System.Drawing.Size(902, 114);
            this.khach3.TabIndex = 24;
            this.khach3.Visible = false;
            // 
            // diaChi3
            // 
            this.diaChi3.Location = new System.Drawing.Point(96, 68);
            this.diaChi3.Margin = new System.Windows.Forms.Padding(4);
            this.diaChi3.Name = "diaChi3";
            this.diaChi3.Size = new System.Drawing.Size(780, 22);
            this.diaChi3.TabIndex = 7;
            // 
            // loaiKhach3
            // 
            this.loaiKhach3.FormattingEnabled = true;
            this.loaiKhach3.Items.AddRange(new object[] {
            "Khách ngoại quốc",
            "Khách nội quốc"});
            this.loaiKhach3.Location = new System.Drawing.Point(757, 21);
            this.loaiKhach3.Margin = new System.Windows.Forms.Padding(4);
            this.loaiKhach3.Name = "loaiKhach3";
            this.loaiKhach3.Size = new System.Drawing.Size(119, 24);
            this.loaiKhach3.TabIndex = 6;
            // 
            // cmnd3
            // 
            this.cmnd3.Location = new System.Drawing.Point(444, 22);
            this.cmnd3.Margin = new System.Windows.Forms.Padding(4);
            this.cmnd3.Name = "cmnd3";
            this.cmnd3.Size = new System.Drawing.Size(199, 22);
            this.cmnd3.TabIndex = 5;
            // 
            // name3
            // 
            this.name3.Location = new System.Drawing.Point(97, 22);
            this.name3.Margin = new System.Windows.Forms.Padding(4);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(256, 22);
            this.name3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Loại Khách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Địa Chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "CMND:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Họ Tên:";
            // 
            // khach2
            // 
            this.khach2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khach2.Controls.Add(this.diaChi2);
            this.khach2.Controls.Add(this.loaiKhach2);
            this.khach2.Controls.Add(this.cmnd2);
            this.khach2.Controls.Add(this.name2);
            this.khach2.Controls.Add(this.label5);
            this.khach2.Controls.Add(this.label6);
            this.khach2.Controls.Add(this.label7);
            this.khach2.Controls.Add(this.label8);
            this.khach2.Location = new System.Drawing.Point(30, 180);
            this.khach2.Margin = new System.Windows.Forms.Padding(4);
            this.khach2.Name = "khach2";
            this.khach2.Size = new System.Drawing.Size(902, 114);
            this.khach2.TabIndex = 23;
            this.khach2.Visible = false;
            // 
            // diaChi2
            // 
            this.diaChi2.Location = new System.Drawing.Point(96, 68);
            this.diaChi2.Margin = new System.Windows.Forms.Padding(4);
            this.diaChi2.Name = "diaChi2";
            this.diaChi2.Size = new System.Drawing.Size(780, 22);
            this.diaChi2.TabIndex = 7;
            // 
            // loaiKhach2
            // 
            this.loaiKhach2.FormattingEnabled = true;
            this.loaiKhach2.Items.AddRange(new object[] {
            "Khách ngoại quốc",
            "Khách nội quốc"});
            this.loaiKhach2.Location = new System.Drawing.Point(757, 21);
            this.loaiKhach2.Margin = new System.Windows.Forms.Padding(4);
            this.loaiKhach2.Name = "loaiKhach2";
            this.loaiKhach2.Size = new System.Drawing.Size(119, 24);
            this.loaiKhach2.TabIndex = 6;
            // 
            // cmnd2
            // 
            this.cmnd2.Location = new System.Drawing.Point(444, 22);
            this.cmnd2.Margin = new System.Windows.Forms.Padding(4);
            this.cmnd2.Name = "cmnd2";
            this.cmnd2.Size = new System.Drawing.Size(199, 22);
            this.cmnd2.TabIndex = 5;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(97, 22);
            this.name2.Margin = new System.Windows.Forms.Padding(4);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(256, 22);
            this.name2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại Khách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "CMND:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Họ Tên:";
            // 
            // khach1
            // 
            this.khach1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.khach1.Controls.Add(this.diaChi1);
            this.khach1.Controls.Add(this.loaiKhach1);
            this.khach1.Controls.Add(this.cmnd1);
            this.khach1.Controls.Add(this.name1);
            this.khach1.Controls.Add(this.label4);
            this.khach1.Controls.Add(this.label3);
            this.khach1.Controls.Add(this.label2);
            this.khach1.Controls.Add(this.label1);
            this.khach1.Location = new System.Drawing.Point(30, 58);
            this.khach1.Margin = new System.Windows.Forms.Padding(4);
            this.khach1.Name = "khach1";
            this.khach1.Size = new System.Drawing.Size(902, 114);
            this.khach1.TabIndex = 22;
            // 
            // diaChi1
            // 
            this.diaChi1.Location = new System.Drawing.Point(96, 68);
            this.diaChi1.Margin = new System.Windows.Forms.Padding(4);
            this.diaChi1.Name = "diaChi1";
            this.diaChi1.Size = new System.Drawing.Size(780, 22);
            this.diaChi1.TabIndex = 7;
            // 
            // loaiKhach1
            // 
            this.loaiKhach1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOAIKHACHHANGBindingSource, "TenLoaiKhach", true));
            this.loaiKhach1.DataSource = this.lOAIKHACHHANGBindingSource;
            this.loaiKhach1.DisplayMember = "TenLoaiKhach";
            this.loaiKhach1.FormattingEnabled = true;
            this.loaiKhach1.Location = new System.Drawing.Point(757, 21);
            this.loaiKhach1.Margin = new System.Windows.Forms.Padding(4);
            this.loaiKhach1.Name = "loaiKhach1";
            this.loaiKhach1.Size = new System.Drawing.Size(119, 24);
            this.loaiKhach1.TabIndex = 6;
            this.loaiKhach1.Tag = "";
            this.loaiKhach1.ValueMember = "TenLoaiKhach";
            // 
            // cmnd1
            // 
            this.cmnd1.Location = new System.Drawing.Point(444, 22);
            this.cmnd1.Margin = new System.Windows.Forms.Padding(4);
            this.cmnd1.Name = "cmnd1";
            this.cmnd1.Size = new System.Drawing.Size(199, 22);
            this.cmnd1.TabIndex = 5;
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(97, 22);
            this.name1.Margin = new System.Windows.Forms.Padding(4);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(256, 22);
            this.name1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CMND:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // doiPhong
            // 
            this.doiPhong.Location = new System.Drawing.Point(42, 704);
            this.doiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.doiPhong.Name = "doiPhong";
            this.doiPhong.Size = new System.Drawing.Size(171, 28);
            this.doiPhong.TabIndex = 36;
            this.doiPhong.Text = "Đổi phòng";
            this.doiPhong.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 704);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "Lập Phiếu Thuê";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dANHMUCPHONGTableAdapter
            // 
            this.dANHMUCPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // tILEPHUTHUTableAdapter
            // 
            this.tILEPHUTHUTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIKHACHHANGBindingSource
            // 
            this.lOAIKHACHHANGBindingSource.DataMember = "LOAIKHACHHANG";
            this.lOAIKHACHHANGBindingSource.DataSource = this.quanLyKhachSanDataSet;
            // 
            // lOAIKHACHHANGTableAdapter
            // 
            this.lOAIKHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "MaPhong";
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            // 
            // maLoaiPhongDataGridViewTextBoxColumn
            // 
            this.maLoaiPhongDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.HeaderText = "MaLoaiPhong";
            this.maLoaiPhongDataGridViewTextBoxColumn.Name = "maLoaiPhongDataGridViewTextBoxColumn";
            // 
            // tinhTrangPhongDataGridViewTextBoxColumn
            // 
            this.tinhTrangPhongDataGridViewTextBoxColumn.DataPropertyName = "TinhTrangPhong";
            this.tinhTrangPhongDataGridViewTextBoxColumn.HeaderText = "TinhTrangPhong";
            this.tinhTrangPhongDataGridViewTextBoxColumn.Name = "tinhTrangPhongDataGridViewTextBoxColumn";
            // 
            // PhieuThuePhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 761);
            this.Controls.Add(this.doiPhong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.soKhach);
            this.Controls.Add(this.giaPhong);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tenPhong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ngayThuePhong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.xoaKhach);
            this.Controls.Add(this.themKhach);
            this.Controls.Add(this.khach3);
            this.Controls.Add(this.khach2);
            this.Controls.Add(this.khach1);
            this.Name = "PhieuThuePhongForm";
            this.Text = "PhieuThuePhongForm";
            this.Load += new System.EventHandler(this.PhieuThuePhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tILEPHUTHUBindingSource)).EndInit();
            this.khach3.ResumeLayout(false);
            this.khach3.PerformLayout();
            this.khach2.ResumeLayout(false);
            this.khach2.PerformLayout();
            this.khach1.ResumeLayout(false);
            this.khach1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox soKhach;
        private System.Windows.Forms.Label giaPhong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tenPhong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker ngayThuePhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button xoaKhach;
        private System.Windows.Forms.Button themKhach;
        private System.Windows.Forms.Panel khach3;
        private System.Windows.Forms.TextBox diaChi3;
        private System.Windows.Forms.ComboBox loaiKhach3;
        private System.Windows.Forms.TextBox cmnd3;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel khach2;
        private System.Windows.Forms.TextBox diaChi2;
        private System.Windows.Forms.ComboBox loaiKhach2;
        private System.Windows.Forms.TextBox cmnd2;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel khach1;
        private System.Windows.Forms.TextBox diaChi1;
        private System.Windows.Forms.ComboBox loaiKhach1;
        private System.Windows.Forms.TextBox cmnd1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doiPhong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource quanLyKhachSanDataSetBindingSource;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet;
        private System.Windows.Forms.BindingSource dANHMUCPHONGBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.DANHMUCPHONGTableAdapter dANHMUCPHONGTableAdapter;
        private System.Windows.Forms.BindingSource tILEPHUTHUBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.TILEPHUTHUTableAdapter tILEPHUTHUTableAdapter;
        private System.Windows.Forms.BindingSource lOAIKHACHHANGBindingSource;
        private QuanLyKhachSanDataSetTableAdapters.LOAIKHACHHANGTableAdapter lOAIKHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangPhongDataGridViewTextBoxColumn;
    }
}