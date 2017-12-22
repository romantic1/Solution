namespace AppQuanLyQuanAn
{
    partial class BieuDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BieuDo));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HeaderPanelDM = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BieuDoKhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HeaderPanelDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanelDM
            // 
            this.HeaderPanelDM.BackColor = System.Drawing.SystemColors.Control;
            this.HeaderPanelDM.BackgroundImage = global::AppQuanLyQuanAn.Properties.Resources.HinhMay1;
            this.HeaderPanelDM.Controls.Add(this.button3);
            this.HeaderPanelDM.Controls.Add(this.button4);
            this.HeaderPanelDM.Controls.Add(this.button1);
            this.HeaderPanelDM.Controls.Add(this.label1);
            this.HeaderPanelDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanelDM.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanelDM.Name = "HeaderPanelDM";
            this.HeaderPanelDM.Size = new System.Drawing.Size(1045, 31);
            this.HeaderPanelDM.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(904, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(956, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 32);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AppQuanLyQuanAn.Properties.Resources.Off11;
            this.button1.Location = new System.Drawing.Point(1005, -1);
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
            this.label1.Location = new System.Drawing.Point(-3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biểu Đồ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BieuDoKhachHang
            // 
            chartArea1.Name = "ChartArea1";
            this.BieuDoKhachHang.ChartAreas.Add(chartArea1);
            this.BieuDoKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.BieuDoKhachHang.Legends.Add(legend1);
            this.BieuDoKhachHang.Location = new System.Drawing.Point(0, 31);
            this.BieuDoKhachHang.Name = "BieuDoKhachHang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BieuDoKhachHang.Series.Add(series1);
            this.BieuDoKhachHang.Size = new System.Drawing.Size(1045, 514);
            this.BieuDoKhachHang.TabIndex = 6;
            this.BieuDoKhachHang.Text = "chart1";
            // 
            // BieuDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 545);
            this.Controls.Add(this.BieuDoKhachHang);
            this.Controls.Add(this.HeaderPanelDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BieuDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BieuDo";
            this.Load += new System.EventHandler(this.BieuDo_Load);
            this.HeaderPanelDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDoKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanelDM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDoKhachHang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}