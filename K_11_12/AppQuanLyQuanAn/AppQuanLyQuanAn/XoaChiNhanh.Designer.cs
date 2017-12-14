namespace AppQuanLyQuanAn
{
    partial class XoaChiNhanh
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
            this.cbb_MaChiNhanh = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_XoaChiNhanh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OffChiNhanh = new System.Windows.Forms.Button();
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.OffThaoTacCNQL = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.HeaderPanelDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_MaChiNhanh
            // 
            this.cbb_MaChiNhanh.FormattingEnabled = true;
            this.cbb_MaChiNhanh.Location = new System.Drawing.Point(182, 79);
            this.cbb_MaChiNhanh.Name = "cbb_MaChiNhanh";
            this.cbb_MaChiNhanh.Size = new System.Drawing.Size(202, 21);
            this.cbb_MaChiNhanh.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.Controls.Add(this.cbb_MaChiNhanh);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_XoaChiNhanh);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 259);
            this.panel2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 50;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_XoaChiNhanh
            // 
            this.btn_XoaChiNhanh.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_XoaChiNhanh.FlatAppearance.BorderSize = 0;
            this.btn_XoaChiNhanh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaChiNhanh.Image = global::AppQuanLyQuanAn.Properties.Resources.XoaThaoTac;
            this.btn_XoaChiNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaChiNhanh.Location = new System.Drawing.Point(182, 140);
            this.btn_XoaChiNhanh.Name = "btn_XoaChiNhanh";
            this.btn_XoaChiNhanh.Size = new System.Drawing.Size(139, 37);
            this.btn_XoaChiNhanh.TabIndex = 64;
            this.btn_XoaChiNhanh.Text = "Xóa chi nhánh";
            this.btn_XoaChiNhanh.UseVisualStyleBackColor = false;
            this.btn_XoaChiNhanh.Click += new System.EventHandler(this.btn_XoaChiNhanh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(51, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên Chi Nhánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Thông Tin";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xóa Chi Nhánh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OffChiNhanh
            // 
            this.OffChiNhanh.BackColor = System.Drawing.Color.Transparent;
            this.OffChiNhanh.FlatAppearance.BorderSize = 0;
            this.OffChiNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffChiNhanh.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.OffChiNhanh.Location = new System.Drawing.Point(417, -3);
            this.OffChiNhanh.Name = "OffChiNhanh";
            this.OffChiNhanh.Size = new System.Drawing.Size(37, 36);
            this.OffChiNhanh.TabIndex = 19;
            this.OffChiNhanh.UseVisualStyleBackColor = false;
            this.OffChiNhanh.Click += new System.EventHandler(this.OffChiNhanh_Click);
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.HeaderPanelDM.Controls.Add(this.OffChiNhanh);
            this.HeaderPanelDM.Controls.Add(this.OffThaoTacCNQL);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(457, 31);
            this.HeaderPanelDM.TabIndex = 17;
            // 
            // OffThaoTacCNQL
            // 
            this.OffThaoTacCNQL.BackColor = System.Drawing.Color.Transparent;
            this.OffThaoTacCNQL.FlatAppearance.BorderSize = 0;
            this.OffThaoTacCNQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffThaoTacCNQL.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.OffThaoTacCNQL.Location = new System.Drawing.Point(694, -2);
            this.OffThaoTacCNQL.Name = "OffThaoTacCNQL";
            this.OffThaoTacCNQL.Size = new System.Drawing.Size(37, 36);
            this.OffThaoTacCNQL.TabIndex = 1;
            this.OffThaoTacCNQL.UseVisualStyleBackColor = false;
            // 
            // XoaChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeaderPanelDM);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XoaChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaChiNhanh";
            this.Load += new System.EventHandler(this.XoaChiNhanh_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HeaderPanelDM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_MaChiNhanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_XoaChiNhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OffChiNhanh;
        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Button OffThaoTacCNQL;


    }
}