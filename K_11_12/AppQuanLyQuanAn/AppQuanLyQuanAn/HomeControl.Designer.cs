namespace AppQuanLyQuanAn
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dangNhapControl1 = new AppQuanLyQuanAn.DangNhapControl();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(673, 11);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dangNhapControl1
            // 
            this.dangNhapControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dangNhapControl1.Location = new System.Drawing.Point(34, 118);
            this.dangNhapControl1.Name = "dangNhapControl1";
            this.dangNhapControl1.Size = new System.Drawing.Size(636, 281);
            this.dangNhapControl1.TabIndex = 2;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dangNhapControl1);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(988, 524);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DangNhapControl dangNhapControl1;
    }
}
