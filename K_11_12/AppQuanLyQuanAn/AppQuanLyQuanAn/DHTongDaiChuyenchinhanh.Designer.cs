namespace AppQuanLyQuanAn
{
    partial class DHTongDaiChuyenchinhanh
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
            this.HienThiDanhSachDonHangTongDai = new System.Windows.Forms.DataGridView();
            this.madh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tencn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tragtha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khuyenmai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchTenChiNhanh = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.OffChiNhanh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btSearchMACNQL = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.cbxacnhan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HienThiDanhSachDonHangTongDai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.HeaderPanelDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // HienThiDanhSachDonHangTongDai
            // 
            this.HienThiDanhSachDonHangTongDai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HienThiDanhSachDonHangTongDai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HienThiDanhSachDonHangTongDai.BackgroundColor = System.Drawing.SystemColors.Window;
            this.HienThiDanhSachDonHangTongDai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HienThiDanhSachDonHangTongDai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madh,
            this.TenDH,
            this.SDTkh,
            this.DcKH,
            this.Tencn,
            this.Tragtha,
            this.Khuyenmai,
            this.Thoigian,
            this.Ttien});
            this.HienThiDanhSachDonHangTongDai.Location = new System.Drawing.Point(8, 74);
            this.HienThiDanhSachDonHangTongDai.Margin = new System.Windows.Forms.Padding(4);
            this.HienThiDanhSachDonHangTongDai.Name = "HienThiDanhSachDonHangTongDai";
            this.HienThiDanhSachDonHangTongDai.ReadOnly = true;
            this.HienThiDanhSachDonHangTongDai.Size = new System.Drawing.Size(1340, 424);
            this.HienThiDanhSachDonHangTongDai.TabIndex = 5;
            // 
            // madh
            // 
            this.madh.DataPropertyName = "Ma_DHTD";
            this.madh.HeaderText = "Mã ĐH";
            this.madh.Name = "madh";
            this.madh.ReadOnly = true;
            // 
            // TenDH
            // 
            this.TenDH.DataPropertyName = "Ten_DH";
            this.TenDH.HeaderText = "Tên Đơn Hàng";
            this.TenDH.Name = "TenDH";
            this.TenDH.ReadOnly = true;
            // 
            // SDTkh
            // 
            this.SDTkh.DataPropertyName = "sdtKH";
            this.SDTkh.HeaderText = "SDT Khách Hàng";
            this.SDTkh.Name = "SDTkh";
            this.SDTkh.ReadOnly = true;
            // 
            // DcKH
            // 
            this.DcKH.DataPropertyName = "dcKH";
            this.DcKH.HeaderText = "Địa Chỉ Khách Hàng";
            this.DcKH.Name = "DcKH";
            this.DcKH.ReadOnly = true;
            // 
            // Tencn
            // 
            this.Tencn.DataPropertyName = "Ten_CN";
            this.Tencn.HeaderText = "Tên Chi Nhánh";
            this.Tencn.Name = "Tencn";
            this.Tencn.ReadOnly = true;
            // 
            // Tragtha
            // 
            this.Tragtha.DataPropertyName = "TrangThai";
            this.Tragtha.HeaderText = "Trạng Thái";
            this.Tragtha.Name = "Tragtha";
            this.Tragtha.ReadOnly = true;
            // 
            // Khuyenmai
            // 
            this.Khuyenmai.DataPropertyName = "KhuyenMai";
            this.Khuyenmai.HeaderText = "Khuyến Mãi";
            this.Khuyenmai.Name = "Khuyenmai";
            this.Khuyenmai.ReadOnly = true;
            // 
            // Thoigian
            // 
            this.Thoigian.DataPropertyName = "ThoiGIan";
            this.Thoigian.HeaderText = "Thời Gian";
            this.Thoigian.Name = "Thoigian";
            this.Thoigian.ReadOnly = true;
            // 
            // Ttien
            // 
            this.Ttien.DataPropertyName = "TongTien";
            this.Ttien.HeaderText = "Tổng Tiền";
            this.Ttien.Name = "Ttien";
            this.Ttien.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-48, -39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 83;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-48, -39);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 82;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.SearchTenChiNhanh);
            this.groupBox1.Controls.Add(this.btSearchMACNQL);
            this.groupBox1.Controls.Add(this.HienThiDanhSachDonHangTongDai);
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1367, 506);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // SearchTenChiNhanh
            // 
            this.SearchTenChiNhanh.FormattingEnabled = true;
            this.SearchTenChiNhanh.Items.AddRange(new object[] {
            "Đã Xác Nhận",
            "Đã Chuyển Xuống Chi Nhánh",
            "Đang Giao",
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.SearchTenChiNhanh.Location = new System.Drawing.Point(267, 31);
            this.SearchTenChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTenChiNhanh.Name = "SearchTenChiNhanh";
            this.SearchTenChiNhanh.Size = new System.Drawing.Size(201, 24);
            this.SearchTenChiNhanh.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(396, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(580, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Danh Sách Đơn Hàng Tại Tổng Đài Chuyển xuống chi nhánh";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(863, 603);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(257, 50);
            this.btn_LamMoi.TabIndex = 84;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanelDM.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.HeaderPanelDM.Controls.Add(this.btn_Min);
            this.HeaderPanelDM.Controls.Add(this.btn_Max);
            this.HeaderPanelDM.Controls.Add(this.OffChiNhanh);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(1393, 38);
            this.HeaderPanelDM.TabIndex = 79;
            // 
            // btn_Min
            // 
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Location = new System.Drawing.Point(1196, 1);
            this.btn_Min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(48, 39);
            this.btn_Min.TabIndex = 86;
            this.btn_Min.UseVisualStyleBackColor = true;
            // 
            // btn_Max
            // 
            this.btn_Max.FlatAppearance.BorderSize = 0;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.Location = new System.Drawing.Point(1268, 1);
            this.btn_Max.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(55, 39);
            this.btn_Max.TabIndex = 85;
            this.btn_Max.UseVisualStyleBackColor = true;
            // 
            // OffChiNhanh
            // 
            this.OffChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.OffChiNhanh.FlatAppearance.BorderSize = 0;
            this.OffChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffChiNhanh.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.OffChiNhanh.Location = new System.Drawing.Point(1337, -2);
            this.OffChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.OffChiNhanh.Name = "OffChiNhanh";
            this.OffChiNhanh.Size = new System.Drawing.Size(49, 44);
            this.OffChiNhanh.TabIndex = 1;
            this.OffChiNhanh.UseVisualStyleBackColor = false;
            this.OffChiNhanh.Click += new System.EventHandler(this.OffChiNhanh_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::AppQuanLyQuanAn.Properties.Resources.Chung12;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xác Nhận Đơn Hàng Tổng Đài";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Search.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.Search2;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(500, 18);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 37);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btSearchMACNQL
            // 
            this.btSearchMACNQL.FlatAppearance.BorderSize = 0;
            this.btSearchMACNQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchMACNQL.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearchMACNQL.Image = global::AppQuanLyQuanAn.Properties.Resources.Search;
            this.btSearchMACNQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearchMACNQL.Location = new System.Drawing.Point(8, 23);
            this.btSearchMACNQL.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchMACNQL.Name = "btSearchMACNQL";
            this.btSearchMACNQL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSearchMACNQL.Size = new System.Drawing.Size(231, 36);
            this.btSearchMACNQL.TabIndex = 24;
            this.btSearchMACNQL.Text = "Tìm kiếm Trạng Thái";
            this.btSearchMACNQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearchMACNQL.UseVisualStyleBackColor = true;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xacnhan.Image = global::AppQuanLyQuanAn.Properties.Resources.Add;
            this.btn_xacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xacnhan.Location = new System.Drawing.Point(462, 603);
            this.btn_xacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(257, 50);
            this.btn_xacnhan.TabIndex = 1;
            this.btn_xacnhan.Text = "Xác Nhận Đơn Hàng";
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // cbxacnhan
            // 
            this.cbxacnhan.FormattingEnabled = true;
            this.cbxacnhan.Items.AddRange(new object[] {
            "Đã Chuyển Xuống Chi Nhánh",
            "Đang Giao",
            "Đã Thanh Toán"});
            this.cbxacnhan.Location = new System.Drawing.Point(222, 619);
            this.cbxacnhan.Margin = new System.Windows.Forms.Padding(4);
            this.cbxacnhan.Name = "cbxacnhan";
            this.cbxacnhan.Size = new System.Drawing.Size(201, 24);
            this.cbxacnhan.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 619);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "Trạng Thái";
            // 
            // DHTongDaiChuyenchinhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1393, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxacnhan);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.HeaderPanelDM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_xacnhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DHTongDaiChuyenchinhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonHangTongDai";
            this.Load += new System.EventHandler(this.DHTongDaiChuyenchinhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HienThiDanhSachDonHangTongDai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.HeaderPanelDM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Button OffChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSearchMACNQL;
        private System.Windows.Forms.DataGridView HienThiDanhSachDonHangTongDai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox SearchTenChiNhanh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn madh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tencn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tragtha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ttien;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.ComboBox cbxacnhan;
        private System.Windows.Forms.Label label2;

    }
}