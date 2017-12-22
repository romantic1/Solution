namespace AppQuanLyQuanAn
{
    partial class TongDoanhThu_QuanLi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongDoanhThu_QuanLi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_DoanhThuTongChiNhanh = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThuTongChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.panel1.Controls.Add(this.btn_Min);
            this.panel1.Controls.Add(this.btn_Max);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 31);
            this.panel1.TabIndex = 28;
            // 
            // btn_Min
            // 
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.Image")));
            this.btn_Min.Location = new System.Drawing.Point(904, -3);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(36, 32);
            this.btn_Min.TabIndex = 117;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.FlatAppearance.BorderSize = 0;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Max.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.Image")));
            this.btn_Max.Location = new System.Drawing.Point(958, -3);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(41, 32);
            this.btn_Max.TabIndex = 116;
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.button2.Location = new System.Drawing.Point(1005, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Image = global::AppQuanLyQuanAn.Properties.Resources.Chung12;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng Doanh Thu Chi Nhánh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_DoanhThuTongChiNhanh
            // 
            this.dgv_DoanhThuTongChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoanhThuTongChiNhanh.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_DoanhThuTongChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThuTongChiNhanh.Location = new System.Drawing.Point(0, 96);
            this.dgv_DoanhThuTongChiNhanh.Name = "dgv_DoanhThuTongChiNhanh";
            this.dgv_DoanhThuTongChiNhanh.Size = new System.Drawing.Size(1045, 380);
            this.dgv_DoanhThuTongChiNhanh.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "VND";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(101, 509);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(165, 21);
            this.txt_TongTien.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tổng Tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Doanh Thu Tổng Của Chi Nhánh";
            // 
            // TongDoanhThu_QuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1045, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_DoanhThuTongChiNhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TongDoanhThu_QuanLi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TongThuNhap_QuanLi";
            this.Load += new System.EventHandler(this.TongThuNhap_QuanLi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThuTongChiNhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_DoanhThuTongChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Max;

    }
}