namespace AppQuanLyQuanAn
{
    partial class BaoCaoThongKe
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
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sảnPhẩmHếtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmChưaNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_XuatDanhMucHienTai = new System.Windows.Forms.Button();
            this.btn_XuatTatCaDanhMuc = new System.Windows.Forms.Button();
            this.Time_ThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.sảnPhẩmBánChạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngThuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.từngChiNhánhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_SanPhamBanChay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ChiNhanhBanChay = new System.Windows.Forms.DataGridView();
            this.HeaderPanelDM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPhamBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiNhanhBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanelDM.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.HeaderPanelDM.Controls.Add(this.button1);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(1054, 31);
            this.HeaderPanelDM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::AppQuanLyQuanAn.Properties.Resources.Chung12;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-3, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo Cáo-Thống Kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.button1.Location = new System.Drawing.Point(1017, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_ChiNhanhBanChay);
            this.panel1.Controls.Add(this.dgv_SanPhamBanChay);
            this.panel1.Controls.Add(this.Time_ThoiGian);
            this.panel1.Controls.Add(this.btn_XuatTatCaDanhMuc);
            this.panel1.Controls.Add(this.btn_XuatDanhMucHienTai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 435);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmHếtHàngToolStripMenuItem,
            this.sảnPhẩmChưaNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sảnPhẩmHếtHàngToolStripMenuItem
            // 
            this.sảnPhẩmHếtHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmBánChạyToolStripMenuItem,
            this.sảnPhẩmTồnKhoToolStripMenuItem});
            this.sảnPhẩmHếtHàngToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sảnPhẩmHếtHàngToolStripMenuItem.Name = "sảnPhẩmHếtHàngToolStripMenuItem";
            this.sảnPhẩmHếtHàngToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sảnPhẩmHếtHàngToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // sảnPhẩmChưaNhậpToolStripMenuItem
            // 
            this.sảnPhẩmChưaNhậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngThuNhậpToolStripMenuItem,
            this.từngChiNhánhToolStripMenuItem});
            this.sảnPhẩmChưaNhậpToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sảnPhẩmChưaNhậpToolStripMenuItem.Name = "sảnPhẩmChưaNhậpToolStripMenuItem";
            this.sảnPhẩmChưaNhậpToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.sảnPhẩmChưaNhậpToolStripMenuItem.Text = "Thu Nhâp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời Gian";
            // 
            // btn_XuatDanhMucHienTai
            // 
            this.btn_XuatDanhMucHienTai.Location = new System.Drawing.Point(725, 44);
            this.btn_XuatDanhMucHienTai.Name = "btn_XuatDanhMucHienTai";
            this.btn_XuatDanhMucHienTai.Size = new System.Drawing.Size(120, 23);
            this.btn_XuatDanhMucHienTai.TabIndex = 8;
            this.btn_XuatDanhMucHienTai.Text = "Xuất Danh Mục Hiện Tại";
            this.btn_XuatDanhMucHienTai.UseVisualStyleBackColor = true;
            this.btn_XuatDanhMucHienTai.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_XuatTatCaDanhMuc
            // 
            this.btn_XuatTatCaDanhMuc.Location = new System.Drawing.Point(908, 43);
            this.btn_XuatTatCaDanhMuc.Name = "btn_XuatTatCaDanhMuc";
            this.btn_XuatTatCaDanhMuc.Size = new System.Drawing.Size(134, 23);
            this.btn_XuatTatCaDanhMuc.TabIndex = 8;
            this.btn_XuatTatCaDanhMuc.Text = "Xuất Tất Cả Danh Mục";
            this.btn_XuatTatCaDanhMuc.UseVisualStyleBackColor = true;
            // 
            // Time_ThoiGian
            // 
            this.Time_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Time_ThoiGian.Location = new System.Drawing.Point(98, 43);
            this.Time_ThoiGian.Name = "Time_ThoiGian";
            this.Time_ThoiGian.Size = new System.Drawing.Size(200, 20);
            this.Time_ThoiGian.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sản Phẩm Bán Chạy";
            // 
            // sảnPhẩmBánChạyToolStripMenuItem
            // 
            this.sảnPhẩmBánChạyToolStripMenuItem.Name = "sảnPhẩmBánChạyToolStripMenuItem";
            this.sảnPhẩmBánChạyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sảnPhẩmBánChạyToolStripMenuItem.Text = "Sản Phẩm Bán Chạy";
            // 
            // sảnPhẩmTồnKhoToolStripMenuItem
            // 
            this.sảnPhẩmTồnKhoToolStripMenuItem.Name = "sảnPhẩmTồnKhoToolStripMenuItem";
            this.sảnPhẩmTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sảnPhẩmTồnKhoToolStripMenuItem.Text = "Sản Phẩm Tồn Kho";
            // 
            // tổngThuNhậpToolStripMenuItem
            // 
            this.tổngThuNhậpToolStripMenuItem.Name = "tổngThuNhậpToolStripMenuItem";
            this.tổngThuNhậpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tổngThuNhậpToolStripMenuItem.Text = "Tổng Thu Nhập";
            // 
            // từngChiNhánhToolStripMenuItem
            // 
            this.từngChiNhánhToolStripMenuItem.Name = "từngChiNhánhToolStripMenuItem";
            this.từngChiNhánhToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.từngChiNhánhToolStripMenuItem.Text = "Từng Chi Nhánh";
            // 
            // dgv_SanPhamBanChay
            // 
            this.dgv_SanPhamBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPhamBanChay.Location = new System.Drawing.Point(0, 80);
            this.dgv_SanPhamBanChay.Name = "dgv_SanPhamBanChay";
            this.dgv_SanPhamBanChay.Size = new System.Drawing.Size(1054, 150);
            this.dgv_SanPhamBanChay.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chi Nhánh Bán Chạy";
            // 
            // dgv_ChiNhanhBanChay
            // 
            this.dgv_ChiNhanhBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ChiNhanhBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiNhanhBanChay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ChiNhanhBanChay.Location = new System.Drawing.Point(0, 285);
            this.dgv_ChiNhanhBanChay.Name = "dgv_ChiNhanhBanChay";
            this.dgv_ChiNhanhBanChay.Size = new System.Drawing.Size(1054, 150);
            this.dgv_ChiNhanhBanChay.TabIndex = 11;
            // 
            // BaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HeaderPanelDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCaoThongKe";
            this.Load += new System.EventHandler(this.BaoCaoThongKe_Load);
            this.HeaderPanelDM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPhamBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiNhanhBanChay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmHếtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmChưaNhậpToolStripMenuItem;
        private System.Windows.Forms.Button btn_XuatTatCaDanhMuc;
        private System.Windows.Forms.Button btn_XuatDanhMucHienTai;
        private System.Windows.Forms.DateTimePicker Time_ThoiGian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_ChiNhanhBanChay;
        private System.Windows.Forms.DataGridView dgv_SanPhamBanChay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmBánChạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmTồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngThuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem từngChiNhánhToolStripMenuItem;
    }
}