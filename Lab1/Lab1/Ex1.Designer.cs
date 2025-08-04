namespace Lab1
{
    partial class Ex1
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
            this.so1 = new System.Windows.Forms.Label();
            this.so2 = new System.Windows.Forms.Label();
            this.Tinhtoan = new System.Windows.Forms.Label();
            this.nhap_so_1 = new System.Windows.Forms.TextBox();
            this.nhap_so_2 = new System.Windows.Forms.TextBox();
            this.nhap_so_3 = new System.Windows.Forms.TextBox();
            this.tieude = new System.Windows.Forms.Label();
            this.phep_tru = new System.Windows.Forms.Button();
            this.phep_cong = new System.Windows.Forms.Button();
            this.phep_nhan = new System.Windows.Forms.Button();
            this.phep_chia = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // so1
            // 
            this.so1.AutoSize = true;
            this.so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.so1.Location = new System.Drawing.Point(85, 149);
            this.so1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.so1.Name = "so1";
            this.so1.Size = new System.Drawing.Size(100, 29);
            this.so1.TabIndex = 0;
            this.so1.Text = "Số thứ 1";
            // 
            // so2
            // 
            this.so2.AutoSize = true;
            this.so2.Location = new System.Drawing.Point(85, 234);
            this.so2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.so2.Name = "so2";
            this.so2.Size = new System.Drawing.Size(100, 29);
            this.so2.TabIndex = 1;
            this.so2.Text = "Số thứ 2";
            // 
            // Tinhtoan
            // 
            this.Tinhtoan.AutoSize = true;
            this.Tinhtoan.Location = new System.Drawing.Point(85, 309);
            this.Tinhtoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Tinhtoan.Name = "Tinhtoan";
            this.Tinhtoan.Size = new System.Drawing.Size(101, 29);
            this.Tinhtoan.TabIndex = 2;
            this.Tinhtoan.Text = "Kết quả ";
            // 
            // nhap_so_1
            // 
            this.nhap_so_1.Location = new System.Drawing.Point(233, 146);
            this.nhap_so_1.Name = "nhap_so_1";
            this.nhap_so_1.Size = new System.Drawing.Size(210, 35);
            this.nhap_so_1.TabIndex = 3;
            this.nhap_so_1.TextChanged += new System.EventHandler(this.nhap_so_1_TextChanged);
            // 
            // nhap_so_2
            // 
            this.nhap_so_2.Location = new System.Drawing.Point(233, 231);
            this.nhap_so_2.Name = "nhap_so_2";
            this.nhap_so_2.Size = new System.Drawing.Size(210, 35);
            this.nhap_so_2.TabIndex = 4;
            // 
            // nhap_so_3
            // 
            this.nhap_so_3.Location = new System.Drawing.Point(233, 309);
            this.nhap_so_3.Name = "nhap_so_3";
            this.nhap_so_3.Size = new System.Drawing.Size(210, 35);
            this.nhap_so_3.TabIndex = 5;
            // 
            // tieude
            // 
            this.tieude.AutoSize = true;
            this.tieude.Font = new System.Drawing.Font("Bookman Old Style", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieude.Location = new System.Drawing.Point(165, 52);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(220, 40);
            this.tieude.TabIndex = 6;
            this.tieude.Text = "TÍNH TOÁN";
            // 
            // phep_tru
            // 
            this.phep_tru.Location = new System.Drawing.Point(163, 387);
            this.phep_tru.Name = "phep_tru";
            this.phep_tru.Size = new System.Drawing.Size(75, 34);
            this.phep_tru.TabIndex = 7;
            this.phep_tru.Text = "-";
            this.phep_tru.UseVisualStyleBackColor = true;
            this.phep_tru.Click += new System.EventHandler(this.phep_tru_Click);
            // 
            // phep_cong
            // 
            this.phep_cong.Location = new System.Drawing.Point(52, 387);
            this.phep_cong.Name = "phep_cong";
            this.phep_cong.Size = new System.Drawing.Size(75, 34);
            this.phep_cong.TabIndex = 8;
            this.phep_cong.Text = "+";
            this.phep_cong.UseVisualStyleBackColor = true;
            this.phep_cong.Click += new System.EventHandler(this.phep_cong_Click);
            // 
            // phep_nhan
            // 
            this.phep_nhan.Location = new System.Drawing.Point(281, 387);
            this.phep_nhan.Name = "phep_nhan";
            this.phep_nhan.Size = new System.Drawing.Size(75, 34);
            this.phep_nhan.TabIndex = 9;
            this.phep_nhan.Text = "x";
            this.phep_nhan.UseVisualStyleBackColor = true;
            this.phep_nhan.Click += new System.EventHandler(this.phep_nhan_Click);
            // 
            // phep_chia
            // 
            this.phep_chia.Location = new System.Drawing.Point(397, 387);
            this.phep_chia.Name = "phep_chia";
            this.phep_chia.Size = new System.Drawing.Size(75, 34);
            this.phep_chia.TabIndex = 10;
            this.phep_chia.Text = "/";
            this.phep_chia.UseVisualStyleBackColor = true;
            this.phep_chia.Click += new System.EventHandler(this.phep_chia_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(114, 455);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(115, 38);
            this.Xoa.TabIndex = 11;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(281, 455);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(117, 38);
            this.thoat.TabIndex = 12;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 520);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.phep_chia);
            this.Controls.Add(this.phep_nhan);
            this.Controls.Add(this.phep_cong);
            this.Controls.Add(this.phep_tru);
            this.Controls.Add(this.tieude);
            this.Controls.Add(this.nhap_so_3);
            this.Controls.Add(this.nhap_so_2);
            this.Controls.Add(this.nhap_so_1);
            this.Controls.Add(this.Tinhtoan);
            this.Controls.Add(this.so2);
            this.Controls.Add(this.so1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Ex1";
            this.Text = "Caculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so1;
        private System.Windows.Forms.Label so2;
        private System.Windows.Forms.Label Tinhtoan;
        private System.Windows.Forms.TextBox nhap_so_1;
        private System.Windows.Forms.TextBox nhap_so_2;
        private System.Windows.Forms.TextBox nhap_so_3;
        private System.Windows.Forms.Label tieude;
        private System.Windows.Forms.Button phep_tru;
        private System.Windows.Forms.Button phep_cong;
        private System.Windows.Forms.Button phep_nhan;
        private System.Windows.Forms.Button phep_chia;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button thoat;
    }
}