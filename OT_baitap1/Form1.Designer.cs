namespace OT_baitap1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtDonGia = new TextBox();
            label2 = new Label();
            txtSoLuong = new TextBox();
            label3 = new Label();
            txtGiamGia = new TextBox();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 34);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Đơn giá dịch vụ:";
            label1.Click += label1_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(220, 31);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 67);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Số lượng khách:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(220, 64);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 100);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Giảm giá:";
            label3.Click += label3_Click;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(220, 97);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(125, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(320, 141);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(193, 20);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng tiền thanh toán: 0VNĐ";
            lblTongTien.Click += label4_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(120, 137);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(94, 29);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(220, 137);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblTongTien);
            Controls.Add(txtGiamGia);
            Controls.Add(label3);
            Controls.Add(txtSoLuong);
            Controls.Add(label2);
            Controls.Add(txtDonGia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDonGia;
        private Label label2;
        private TextBox txtSoLuong;
        private Label label3;
        private TextBox txtGiamGia;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}
