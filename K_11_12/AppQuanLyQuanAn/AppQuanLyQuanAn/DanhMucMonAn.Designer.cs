namespace AppQuanLyQuanAn
{
    partial class DanhMucMonAn
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
            this.lbDanhMucMonAn = new System.Windows.Forms.ListBox();
            this.txtTimKiemDM = new System.Windows.Forms.TextBox();
            this.DanhMucPanel = new System.Windows.Forms.Panel();
            this.btnTimKiemDM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnCapNhatDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.txtTimKiemMA = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaMA = new System.Windows.Forms.Button();
            this.btnCapNhatMA = new System.Windows.Forms.Button();
            this.btnThemMA = new System.Windows.Forms.Button();
            this.txtTenMA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetManHinh = new System.Windows.Forms.Button();
            this.btnTimKiemMA = new System.Windows.Forms.Button();
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.OffDanhMuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DanhMucPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).BeginInit();
            this.panel2.SuspendLayout();
            this.HeaderPanelDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDanhMucMonAn
            // 
            this.lbDanhMucMonAn.BackColor = System.Drawing.SystemColors.Window;
            this.lbDanhMucMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDanhMucMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDanhMucMonAn.FormattingEnabled = true;
            this.lbDanhMucMonAn.Location = new System.Drawing.Point(0, 0);
            this.lbDanhMucMonAn.Name = "lbDanhMucMonAn";
            this.lbDanhMucMonAn.Size = new System.Drawing.Size(239, 221);
            this.lbDanhMucMonAn.TabIndex = 2;
            // 
            // txtTimKiemDM
            // 
            this.txtTimKiemDM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemDM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemDM.Location = new System.Drawing.Point(102, 232);
            this.txtTimKiemDM.Name = "txtTimKiemDM";
            this.txtTimKiemDM.Size = new System.Drawing.Size(134, 19);
            this.txtTimKiemDM.TabIndex = 3;
            // 
            // DanhMucPanel
            // 
            this.DanhMucPanel.Controls.Add(this.lbDanhMucMonAn);
            this.DanhMucPanel.Controls.Add(this.btnTimKiemDM);
            this.DanhMucPanel.Controls.Add(this.txtTimKiemDM);
            this.DanhMucPanel.Controls.Add(this.panel1);
            this.DanhMucPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DanhMucPanel.Location = new System.Drawing.Point(0, 31);
            this.DanhMucPanel.Name = "DanhMucPanel";
            this.DanhMucPanel.Size = new System.Drawing.Size(239, 466);
            this.DanhMucPanel.TabIndex = 5;
            // 
            // btnTimKiemDM
            // 
            this.btnTimKiemDM.FlatAppearance.BorderSize = 0;
            this.btnTimKiemDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemDM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemDM.Image = global::AppQuanLyQuanAn.Properties.Resources.Search;
            this.btnTimKiemDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemDM.Location = new System.Drawing.Point(3, 229);
            this.btnTimKiemDM.Name = "btnTimKiemDM";
            this.btnTimKiemDM.Size = new System.Drawing.Size(96, 27);
            this.btnTimKiemDM.TabIndex = 4;
            this.btnTimKiemDM.Text = "Danh Mục";
            this.btnTimKiemDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemDM.UseVisualStyleBackColor = true;
            this.btnTimKiemDM.Click += new System.EventHandler(this.btnTimKiemDM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.btnXoaDM);
            this.panel1.Controls.Add(this.btnCapNhatDM);
            this.panel1.Controls.Add(this.btnThemDM);
            this.panel1.Controls.Add(this.txtTenDM);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaDM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 203);
            this.panel1.TabIndex = 15;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.FlatAppearance.BorderSize = 0;
            this.btnXoaDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaDM.Image = global::AppQuanLyQuanAn.Properties.Resources.Delete;
            this.btnXoaDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDM.Location = new System.Drawing.Point(26, 153);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(156, 37);
            this.btnXoaDM.TabIndex = 19;
            this.btnXoaDM.Text = "Xóa danh mục";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnCapNhatDM
            // 
            this.btnCapNhatDM.FlatAppearance.BorderSize = 0;
            this.btnCapNhatDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatDM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatDM.Image = global::AppQuanLyQuanAn.Properties.Resources.Update;
            this.btnCapNhatDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatDM.Location = new System.Drawing.Point(26, 110);
            this.btnCapNhatDM.Name = "btnCapNhatDM";
            this.btnCapNhatDM.Size = new System.Drawing.Size(189, 37);
            this.btnCapNhatDM.TabIndex = 18;
            this.btnCapNhatDM.Text = "Cập Nhật Danh Mục";
            this.btnCapNhatDM.UseVisualStyleBackColor = true;
            this.btnCapNhatDM.Click += new System.EventHandler(this.btnCapNhatDM_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.FlatAppearance.BorderSize = 0;
            this.btnThemDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDM.Image = global::AppQuanLyQuanAn.Properties.Resources.Add;
            this.btnThemDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDM.Location = new System.Drawing.Point(26, 69);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(156, 37);
            this.btnThemDM.TabIndex = 17;
            this.btnThemDM.Text = "Thêm Danh Mục";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // txtTenDM
            // 
            this.txtTenDM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDM.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDM.Location = new System.Drawing.Point(120, 43);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(95, 18);
            this.txtTenDM.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên Danh Mục:";
            // 
            // txtMaDM
            // 
            this.txtMaDM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaDM.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaDM.Location = new System.Drawing.Point(120, 13);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(95, 18);
            this.txtMaDM.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(23, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Danh Mục:";
            // 
            // dgvDanhSachMonAn
            // 
            this.dgvDanhSachMonAn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhSachMonAn.Location = new System.Drawing.Point(239, 31);
            this.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn";
            this.dgvDanhSachMonAn.Size = new System.Drawing.Size(487, 221);
            this.dgvDanhSachMonAn.TabIndex = 9;
            this.dgvDanhSachMonAn.Click += new System.EventHandler(this.dgvDanhSachMonAn_Click);
            // 
            // txtTimKiemMA
            // 
            this.txtTimKiemMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemMA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemMA.Location = new System.Drawing.Point(336, 264);
            this.txtTimKiemMA.Name = "txtTimKiemMA";
            this.txtTimKiemMA.Size = new System.Drawing.Size(206, 19);
            this.txtTimKiemMA.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.cbDanhMuc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnXoaMA);
            this.panel2.Controls.Add(this.btnCapNhatMA);
            this.panel2.Controls.Add(this.btnThemMA);
            this.panel2.Controls.Add(this.txtTenMA);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaMA);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(239, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 203);
            this.panel2.TabIndex = 16;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDanhMuc.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Items.AddRange(new object[] {
            "Món Chay",
            "Món Lẩu",
            "Cơm",
            "Phở"});
            this.cbDanhMuc.Location = new System.Drawing.Point(97, 133);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(206, 22);
            this.cbDanhMuc.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(21, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Danh mục:";
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGia.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(97, 94);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(206, 18);
            this.txtGia.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(56, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Giá:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGhiChu.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(97, 173);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(206, 18);
            this.txtGhiChu.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(28, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú:";
            // 
            // btnXoaMA
            // 
            this.btnXoaMA.FlatAppearance.BorderSize = 0;
            this.btnXoaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaMA.Image = global::AppQuanLyQuanAn.Properties.Resources.Delete;
            this.btnXoaMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaMA.Location = new System.Drawing.Point(317, 134);
            this.btnXoaMA.Name = "btnXoaMA";
            this.btnXoaMA.Size = new System.Drawing.Size(125, 37);
            this.btnXoaMA.TabIndex = 26;
            this.btnXoaMA.Text = "Xóa món ăn";
            this.btnXoaMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMA.UseVisualStyleBackColor = true;
            this.btnXoaMA.Click += new System.EventHandler(this.btnXoaMA_Click);
            // 
            // btnCapNhatMA
            // 
            this.btnCapNhatMA.FlatAppearance.BorderSize = 0;
            this.btnCapNhatMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatMA.Image = global::AppQuanLyQuanAn.Properties.Resources.Update;
            this.btnCapNhatMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatMA.Location = new System.Drawing.Point(317, 79);
            this.btnCapNhatMA.Name = "btnCapNhatMA";
            this.btnCapNhatMA.Size = new System.Drawing.Size(158, 37);
            this.btnCapNhatMA.TabIndex = 25;
            this.btnCapNhatMA.Text = "Cập Nhật Món Ăn";
            this.btnCapNhatMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatMA.UseVisualStyleBackColor = true;
            this.btnCapNhatMA.Click += new System.EventHandler(this.btnCapNhatMA_Click);
            // 
            // btnThemMA
            // 
            this.btnThemMA.FlatAppearance.BorderSize = 0;
            this.btnThemMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMA.Image = global::AppQuanLyQuanAn.Properties.Resources.Add;
            this.btnThemMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMA.Location = new System.Drawing.Point(317, 22);
            this.btnThemMA.Name = "btnThemMA";
            this.btnThemMA.Size = new System.Drawing.Size(158, 37);
            this.btnThemMA.TabIndex = 24;
            this.btnThemMA.Text = "Thêm Món Ăn";
            this.btnThemMA.UseVisualStyleBackColor = true;
            this.btnThemMA.Click += new System.EventHandler(this.btnThemMA_Click);
            // 
            // txtTenMA
            // 
            this.txtTenMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenMA.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMA.Location = new System.Drawing.Point(97, 54);
            this.txtTenMA.Name = "txtTenMA";
            this.txtTenMA.Size = new System.Drawing.Size(206, 18);
            this.txtTenMA.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Món Ăn:";
            // 
            // txtMaMA
            // 
            this.txtMaMA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaMA.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMA.Location = new System.Drawing.Point(97, 17);
            this.txtMaMA.Name = "txtMaMA";
            this.txtMaMA.Size = new System.Drawing.Size(206, 18);
            this.txtMaMA.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã Món Ăn:";
            // 
            // btnResetManHinh
            // 
            this.btnResetManHinh.FlatAppearance.BorderSize = 0;
            this.btnResetManHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetManHinh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnResetManHinh.Image = global::AppQuanLyQuanAn.Properties.Resources.refesh;
            this.btnResetManHinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetManHinh.Location = new System.Drawing.Point(556, 258);
            this.btnResetManHinh.Name = "btnResetManHinh";
            this.btnResetManHinh.Size = new System.Drawing.Size(91, 27);
            this.btnResetManHinh.TabIndex = 14;
            this.btnResetManHinh.Text = "Refesh";
            this.btnResetManHinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetManHinh.UseVisualStyleBackColor = true;
            this.btnResetManHinh.Click += new System.EventHandler(this.btnResetManHinh_Click);
            // 
            // btnTimKiemMA
            // 
            this.btnTimKiemMA.FlatAppearance.BorderSize = 0;
            this.btnTimKiemMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiemMA.Image = global::AppQuanLyQuanAn.Properties.Resources.Search;
            this.btnTimKiemMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemMA.Location = new System.Drawing.Point(246, 260);
            this.btnTimKiemMA.Name = "btnTimKiemMA";
            this.btnTimKiemMA.Size = new System.Drawing.Size(84, 27);
            this.btnTimKiemMA.TabIndex = 6;
            this.btnTimKiemMA.Text = "Món Ăn";
            this.btnTimKiemMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemMA.UseVisualStyleBackColor = true;
            this.btnTimKiemMA.Click += new System.EventHandler(this.btnTimKiemMA_Click);
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanelDM.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.HeaderPanelDM.Controls.Add(this.btnThoat);
            this.HeaderPanelDM.Controls.Add(this.OffDanhMuc);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(726, 31);
            this.HeaderPanelDM.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.btnThoat.Location = new System.Drawing.Point(648, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // OffDanhMuc
            // 
            this.OffDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.OffDanhMuc.FlatAppearance.BorderSize = 0;
            this.OffDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffDanhMuc.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.OffDanhMuc.Location = new System.Drawing.Point(748, -2);
            this.OffDanhMuc.Name = "OffDanhMuc";
            this.OffDanhMuc.Size = new System.Drawing.Size(37, 36);
            this.OffDanhMuc.TabIndex = 1;
            this.OffDanhMuc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::AppQuanLyQuanAn.Properties.Resources.Chung12;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Mục Món Ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DanhMucMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(726, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnResetManHinh);
            this.Controls.Add(this.dgvDanhSachMonAn);
            this.Controls.Add(this.btnTimKiemMA);
            this.Controls.Add(this.txtTimKiemMA);
            this.Controls.Add(this.DanhMucPanel);
            this.Controls.Add(this.HeaderPanelDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhMucMonAn";
            this.Load += new System.EventHandler(this.DanhMucMonAn_Load);
            this.DanhMucPanel.ResumeLayout(false);
            this.DanhMucPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HeaderPanelDM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OffDanhMuc;
        private System.Windows.Forms.ListBox lbDanhMucMonAn;
        private System.Windows.Forms.TextBox txtTimKiemDM;
        private System.Windows.Forms.Button btnTimKiemDM;
        private System.Windows.Forms.Panel DanhMucPanel;
        private System.Windows.Forms.DataGridView dgvDanhSachMonAn;
        private System.Windows.Forms.Button btnTimKiemMA;
        private System.Windows.Forms.TextBox txtTimKiemMA;
        private System.Windows.Forms.Button btnResetManHinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnCapNhatDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoaMA;
        private System.Windows.Forms.Button btnCapNhatMA;
        private System.Windows.Forms.Button btnThemMA;
        private System.Windows.Forms.TextBox txtTenMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
    }
}