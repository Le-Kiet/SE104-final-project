namespace QuanLyKhachSan
{
    partial class TraCuuPhg
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
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindRoom = new System.Windows.Forms.Button();
            this.tbTenLphg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvFindRoom = new System.Windows.Forms.DataGridView();
            this.tbTenPhg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFindRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Có người",
            "Trống"});
            this.cbTinhTrang.Location = new System.Drawing.Point(386, 55);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(121, 33);
            this.cbTinhTrang.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên phòng";
            // 
            // btnFindRoom
            // 
            this.btnFindRoom.Location = new System.Drawing.Point(748, 59);
            this.btnFindRoom.Name = "btnFindRoom";
            this.btnFindRoom.Size = new System.Drawing.Size(91, 30);
            this.btnFindRoom.TabIndex = 17;
            this.btnFindRoom.Text = "Tìm";
            this.btnFindRoom.UseVisualStyleBackColor = true;
            this.btnFindRoom.Click += new System.EventHandler(this.btnFindRoom_Click);
            // 
            // tbTenLphg
            // 
            this.tbTenLphg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenLphg.Location = new System.Drawing.Point(209, 58);
            this.tbTenLphg.Name = "tbTenLphg";
            this.tbTenLphg.Size = new System.Drawing.Size(166, 30);
            this.tbTenLphg.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvFindRoom);
            this.panel1.Location = new System.Drawing.Point(69, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 356);
            this.panel1.TabIndex = 16;
            // 
            // dtgvFindRoom
            // 
            this.dtgvFindRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFindRoom.Location = new System.Drawing.Point(0, -1);
            this.dtgvFindRoom.Name = "dtgvFindRoom";
            this.dtgvFindRoom.RowHeadersWidth = 51;
            this.dtgvFindRoom.RowTemplate.Height = 24;
            this.dtgvFindRoom.Size = new System.Drawing.Size(770, 374);
            this.dtgvFindRoom.TabIndex = 0;
            // 
            // tbTenPhg
            // 
            this.tbTenPhg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenPhg.Location = new System.Drawing.Point(69, 59);
            this.tbTenPhg.Name = "tbTenPhg";
            this.tbTenPhg.Size = new System.Drawing.Size(134, 30);
            this.tbTenPhg.TabIndex = 18;
            // 
            // TraCuuPhg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 489);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindRoom);
            this.Controls.Add(this.tbTenLphg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbTenPhg);
            this.Name = "TraCuuPhg";
            this.Text = "TraCuuPhong";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFindRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindRoom;
        private System.Windows.Forms.TextBox tbTenLphg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvFindRoom;
        private System.Windows.Forms.TextBox tbTenPhg;
    }
}