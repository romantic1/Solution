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
            this.components = new System.ComponentModel.Container();
            this.danhmuc = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DanhMucPanel = new System.Windows.Forms.Panel();
            this.SearchDM = new System.Windows.Forms.Button();
            this.monan = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tendanhm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.madanhm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.giamona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ghichu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tenmona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mamona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RefeshDM = new System.Windows.Forms.Button();
            this.SearchMA = new System.Windows.Forms.Button();
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.OffDanhMuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combodanh = new System.Windows.Forms.ComboBox();
            this.qLQUANANDataSet = new AppQuanLyQuanAn.QLQUANANDataSet();
            this.qLQUANANDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ten_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMucPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HeaderPanelDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLQUANANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQUANANDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // danhmuc
            // 
            this.danhmuc.BackColor = System.Drawing.SystemColors.Window;
            this.danhmuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.danhmuc.FormattingEnabled = true;
            this.danhmuc.ItemHeight = 16;
            this.danhmuc.Location = new System.Drawing.Point(8, 57);
            this.danhmuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(239, 512);
            this.danhmuc.TabIndex = 2;
            this.danhmuc.SelectedIndexChanged += new System.EventHandler(this.danhmuc_SelectedIndexChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(144, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 24);
            this.textBox1.TabIndex = 3;
            // 
            // DanhMucPanel
            // 
            this.DanhMucPanel.Controls.Add(this.danhmuc);
            this.DanhMucPanel.Controls.Add(this.SearchDM);
            this.DanhMucPanel.Controls.Add(this.textBox1);
            this.DanhMucPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DanhMucPanel.Location = new System.Drawing.Point(0, 38);
            this.DanhMucPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DanhMucPanel.Name = "DanhMucPanel";
            this.DanhMucPanel.Size = new System.Drawing.Size(253, 574);
            this.DanhMucPanel.TabIndex = 5;
            // 
            // SearchDM
            // 
            this.SearchDM.FlatAppearance.BorderSize = 0;
            this.SearchDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchDM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchDM.Image = global::AppQuanLyQuanAn.Properties.Resources.Search;
            this.SearchDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchDM.Location = new System.Drawing.Point(8, 20);
            this.SearchDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchDM.Name = "SearchDM";
            this.SearchDM.Size = new System.Drawing.Size(128, 33);
            this.SearchDM.TabIndex = 4;
            this.SearchDM.Text = "Danh Mục";
            this.SearchDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchDM.UseVisualStyleBackColor = true;
            // 
            // monan
            // 
            this.monan.AutoGenerateColumns = false;
            this.monan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_MA,
            this.Gia_MA,
            this.GhiChu1});
            this.monan.DataSource = this.qLQUANANDataSetBindingSource;
            this.monan.Location = new System.Drawing.Point(255, 303);
            this.monan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monan.Name = "monan";
            this.monan.Size = new System.Drawing.Size(788, 304);
            this.monan.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox7.Location = new System.Drawing.Point(809, 272);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(232, 24);
            this.textBox7.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tendanhm);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.madanhm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(255, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 250);
            this.panel1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Image = global::AppQuanLyQuanAn.Properties.Resources.Delete;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(35, 188);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 46);
            this.button3.TabIndex = 19;
            this.button3.Text = "Xóa danh mục";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Image = global::AppQuanLyQuanAn.Properties.Resources.Update;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(35, 135);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 46);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cập Nhật Danh Mục";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::AppQuanLyQuanAn.Properties.Resources.Add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(35, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thêm Danh Mục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tendanhm
            // 
            this.tendanhm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tendanhm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tendanhm.Location = new System.Drawing.Point(160, 53);
            this.tendanhm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tendanhm.Name = "tendanhm";
            this.tendanhm.Size = new System.Drawing.Size(127, 22);
            this.tendanhm.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên Danh Mục:";
            // 
            // madanhm
            // 
            this.madanhm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.madanhm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.madanhm.Location = new System.Drawing.Point(160, 16);
            this.madanhm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.madanhm.Name = "madanhm";
            this.madanhm.ReadOnly = true;
            this.madanhm.Size = new System.Drawing.Size(127, 22);
            this.madanhm.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Danh Mục:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.combodanh);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.giamona);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ghichu);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.tenmona);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.mamona);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(569, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 213);
            this.panel2.TabIndex = 16;
            // 
            // giamona
            // 
            this.giamona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giamona.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.giamona.Location = new System.Drawing.Point(129, 95);
            this.giamona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.giamona.Name = "giamona";
            this.giamona.Size = new System.Drawing.Size(127, 22);
            this.giamona.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(75, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Giá:";
            // 
            // ghichu
            // 
            this.ghichu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ghichu.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ghichu.Location = new System.Drawing.Point(129, 133);
            this.ghichu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(127, 22);
            this.ghichu.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(37, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ghi chú:";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Image = global::AppQuanLyQuanAn.Properties.Resources.Delete;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(264, 130);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 46);
            this.button4.TabIndex = 26;
            this.button4.Text = "Xóa món ăn";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.Image = global::AppQuanLyQuanAn.Properties.Resources.Update;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(264, 78);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 46);
            this.button5.TabIndex = 25;
            this.button5.Text = "Cập Nhật Món Ăn";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.Image = global::AppQuanLyQuanAn.Properties.Resources.Add;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(264, 25);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 46);
            this.button6.TabIndex = 24;
            this.button6.Text = "Thêm Món Ăn";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // tenmona
            // 
            this.tenmona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenmona.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenmona.Location = new System.Drawing.Point(129, 58);
            this.tenmona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenmona.Name = "tenmona";
            this.tenmona.Size = new System.Drawing.Size(127, 22);
            this.tenmona.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên Món Ăn:";
            // 
            // mamona
            // 
            this.mamona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mamona.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mamona.Location = new System.Drawing.Point(129, 21);
            this.mamona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mamona.Name = "mamona";
            this.mamona.ReadOnly = true;
            this.mamona.Size = new System.Drawing.Size(127, 22);
            this.mamona.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mã Món Ăn:";
            // 
            // RefeshDM
            // 
            this.RefeshDM.FlatAppearance.BorderSize = 0;
            this.RefeshDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefeshDM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RefeshDM.Image = global::AppQuanLyQuanAn.Properties.Resources.refesh;
            this.RefeshDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefeshDM.Location = new System.Drawing.Point(569, 266);
            this.RefeshDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefeshDM.Name = "RefeshDM";
            this.RefeshDM.Size = new System.Drawing.Size(112, 33);
            this.RefeshDM.TabIndex = 14;
            this.RefeshDM.Text = "Refesh";
            this.RefeshDM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefeshDM.UseVisualStyleBackColor = true;
            // 
            // SearchMA
            // 
            this.SearchMA.FlatAppearance.BorderSize = 0;
            this.SearchMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchMA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchMA.Image = global::AppQuanLyQuanAn.Properties.Resources.Search;
            this.SearchMA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchMA.Location = new System.Drawing.Point(689, 266);
            this.SearchMA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchMA.Name = "SearchMA";
            this.SearchMA.Size = new System.Drawing.Size(112, 33);
            this.SearchMA.TabIndex = 6;
            this.SearchMA.Text = "Món Ăn";
            this.SearchMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchMA.UseVisualStyleBackColor = true;
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanelDM.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.HeaderPanelDM.Controls.Add(this.OffDanhMuc);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(1047, 38);
            this.HeaderPanelDM.TabIndex = 0;
            // 
            // OffDanhMuc
            // 
            this.OffDanhMuc.BackColor = System.Drawing.Color.Transparent;
            this.OffDanhMuc.FlatAppearance.BorderSize = 0;
            this.OffDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffDanhMuc.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.OffDanhMuc.Location = new System.Drawing.Point(997, -2);
            this.OffDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OffDanhMuc.Name = "OffDanhMuc";
            this.OffDanhMuc.Size = new System.Drawing.Size(49, 44);
            this.OffDanhMuc.TabIndex = 1;
            this.OffDanhMuc.UseVisualStyleBackColor = false;
            this.OffDanhMuc.Click += new System.EventHandler(this.OffDanhMuc_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::AppQuanLyQuanAn.Properties.Resources.Chung12;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Mục Món Ăn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(28, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Danh mục:";
            // 
            // combodanh
            // 
            this.combodanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combodanh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.combodanh.FormattingEnabled = true;
            this.combodanh.Location = new System.Drawing.Point(129, 171);
            this.combodanh.Margin = new System.Windows.Forms.Padding(4);
            this.combodanh.Name = "combodanh";
            this.combodanh.Size = new System.Drawing.Size(125, 26);
            this.combodanh.TabIndex = 32;
            // 
            // qLQUANANDataSet
            // 
            this.qLQUANANDataSet.DataSetName = "QLQUANANDataSet";
            this.qLQUANANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLQUANANDataSetBindingSource
            // 
            this.qLQUANANDataSetBindingSource.DataSource = this.qLQUANANDataSet;
            this.qLQUANANDataSetBindingSource.Position = 0;
            // 
            // Ten_MA
            // 
            this.Ten_MA.DataPropertyName = "Ten_MA";
            this.Ten_MA.HeaderText = "Tên Món Ăn";
            this.Ten_MA.Name = "Ten_MA";
            // 
            // Gia_MA
            // 
            this.Gia_MA.DataPropertyName = "Gia_MA";
            this.Gia_MA.HeaderText = "Giá Món Ăn";
            this.Gia_MA.Name = "Gia_MA";
            // 
            // GhiChu1
            // 
            this.GhiChu1.DataPropertyName = "GhiChu";
            this.GhiChu1.HeaderText = "Ghi Chú";
            this.GhiChu1.Name = "GhiChu1";
            // 
            // DanhMucMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1047, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RefeshDM);
            this.Controls.Add(this.SearchMA);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.monan);
            this.Controls.Add(this.DanhMucPanel);
            this.Controls.Add(this.HeaderPanelDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DanhMucMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhMucMonAn";
            this.DanhMucPanel.ResumeLayout(false);
            this.DanhMucPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HeaderPanelDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLQUANANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQUANANDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OffDanhMuc;
        private System.Windows.Forms.ListBox danhmuc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchDM;
        private System.Windows.Forms.Panel DanhMucPanel;
        private System.Windows.Forms.DataGridView monan;
        private System.Windows.Forms.Button SearchMA;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button RefeshDM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tendanhm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox madanhm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox giamona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ghichu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tenmona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mamona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combodanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu1;
        private System.Windows.Forms.BindingSource qLQUANANDataSetBindingSource;
        private QLQUANANDataSet qLQUANANDataSet;
    }
}