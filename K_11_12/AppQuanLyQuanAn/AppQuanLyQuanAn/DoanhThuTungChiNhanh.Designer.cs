namespace AppQuanLyQuanAn
{
    partial class DoanhThuTungChiNhanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoanhThuTungChiNhanh));
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DoanhThu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_TenChiNhanh = new System.Windows.Forms.ComboBox();
            this.dgv_DoanhThuTungChiNhanh = new System.Windows.Forms.DataGridView();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.HeaderPanelDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThuTungChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanelDM.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.HeaderPanelDM.Controls.Add(this.btn_Min);
            this.HeaderPanelDM.Controls.Add(this.btn_Max);
            this.HeaderPanelDM.Controls.Add(this.button1);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(1045, 31);
            this.HeaderPanelDM.TabIndex = 4;
            // 
            // btn_Min
            // 
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.Image")));
            this.btn_Min.Location = new System.Drawing.Point(905, -1);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(36, 32);
            this.btn_Min.TabIndex = 71;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.FlatAppearance.BorderSize = 0;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.Image")));
            this.btn_Max.Location = new System.Drawing.Point(959, -1);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(41, 32);
            this.btn_Max.TabIndex = 70;
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.button1.Location = new System.Drawing.Point(1008, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::AppQuanLyQuanAn.Properties.Resources.Chung12;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doanh Thu Từng Chi Nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng Tiền:";
            // 
            // btn_DoanhThu
            // 
            this.btn_DoanhThu.BackColor = System.Drawing.Color.Crimson;
            this.btn_DoanhThu.Location = new System.Drawing.Point(385, 500);
            this.btn_DoanhThu.Name = "btn_DoanhThu";
            this.btn_DoanhThu.Size = new System.Drawing.Size(89, 36);
            this.btn_DoanhThu.TabIndex = 7;
            this.btn_DoanhThu.Text = "Doanh Thu";
            this.btn_DoanhThu.UseVisualStyleBackColor = false;
            this.btn_DoanhThu.Click += new System.EventHandler(this.btn_DoanhThu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Chi Nhánh:";
            // 
            // cbb_TenChiNhanh
            // 
            this.cbb_TenChiNhanh.FormattingEnabled = true;
            this.cbb_TenChiNhanh.Location = new System.Drawing.Point(131, 56);
            this.cbb_TenChiNhanh.Name = "cbb_TenChiNhanh";
            this.cbb_TenChiNhanh.Size = new System.Drawing.Size(165, 21);
            this.cbb_TenChiNhanh.TabIndex = 9;
            // 
            // dgv_DoanhThuTungChiNhanh
            // 
            this.dgv_DoanhThuTungChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoanhThuTungChiNhanh.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_DoanhThuTungChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThuTungChiNhanh.Location = new System.Drawing.Point(0, 104);
            this.dgv_DoanhThuTungChiNhanh.Name = "dgv_DoanhThuTungChiNhanh";
            this.dgv_DoanhThuTungChiNhanh.Size = new System.Drawing.Size(1045, 377);
            this.dgv_DoanhThuTungChiNhanh.TabIndex = 10;
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.FlatAppearance.BorderSize = 0;
            this.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refesh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Refesh.Image = global::AppQuanLyQuanAn.Properties.Resources.refesh;
            this.btn_Refesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refesh.Location = new System.Drawing.Point(949, 56);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(84, 27);
            this.btn_Refesh.TabIndex = 27;
            this.btn_Refesh.Text = "Refesh";
            this.btn_Refesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refesh.UseVisualStyleBackColor = true;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(101, 507);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(165, 26);
            this.txt_TongTien.TabIndex = 6;
            // 
            // DoanhThuTungChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1045, 545);
            this.Controls.Add(this.btn_Refesh);
            this.Controls.Add(this.dgv_DoanhThuTungChiNhanh);
            this.Controls.Add(this.cbb_TenChiNhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_DoanhThu);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeaderPanelDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThuTungChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoanhThuTungChiNhanh";
            this.Load += new System.EventHandler(this.DoanhThuTungChiNhanh_Load);
            this.HeaderPanelDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThuTungChiNhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_TenChiNhanh;
        private System.Windows.Forms.DataGridView dgv_DoanhThuTungChiNhanh;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Max;
    }
}