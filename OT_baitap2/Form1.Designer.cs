namespace OT_baitap2
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
            txtMaPhieu = new TextBox();
            txtNguoiYeuCau = new TextBox();
            dtpNgayGhiNhan = new DateTimePicker();
            grpUuTien = new GroupBox();
            radThap = new RadioButton();
            radKhanCap = new RadioButton();
            radTrungBinh = new RadioButton();
            cmbLoaiSuCo = new ComboBox();
            grpThietBi = new GroupBox();
            chkDienThoai = new CheckBox();
            chkMayIn = new CheckBox();
            chkLaptop = new CheckBox();
            chkPC = new CheckBox();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGui = new Button();
            btnNhapLai = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            grpUuTien.SuspendLayout();
            grpThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(12, 32);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(162, 27);
            txtMaPhieu.TabIndex = 0;
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(12, 92);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(162, 27);
            txtNguoiYeuCau.TabIndex = 1;
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Short;
            dtpNgayGhiNhan.Location = new Point(439, 18);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(124, 27);
            dtpNgayGhiNhan.TabIndex = 2;
            // 
            // grpUuTien
            // 
            grpUuTien.Controls.Add(radThap);
            grpUuTien.Controls.Add(radKhanCap);
            grpUuTien.Controls.Add(radTrungBinh);
            grpUuTien.Location = new Point(12, 135);
            grpUuTien.Name = "grpUuTien";
            grpUuTien.Size = new Size(259, 148);
            grpUuTien.TabIndex = 3;
            grpUuTien.TabStop = false;
            grpUuTien.Text = "Mức độ ưu tiên";
            // 
            // radThap
            // 
            radThap.AutoSize = true;
            radThap.Checked = true;
            radThap.Location = new Point(6, 35);
            radThap.Name = "radThap";
            radThap.Size = new Size(63, 24);
            radThap.TabIndex = 4;
            radThap.TabStop = true;
            radThap.Text = "Thấp";
            radThap.UseVisualStyleBackColor = true;
            // 
            // radKhanCap
            // 
            radKhanCap.AutoSize = true;
            radKhanCap.Location = new Point(6, 95);
            radKhanCap.Name = "radKhanCap";
            radKhanCap.Size = new Size(91, 24);
            radKhanCap.TabIndex = 6;
            radKhanCap.Text = "Khẩn cấp";
            radKhanCap.UseVisualStyleBackColor = true;
            // 
            // radTrungBinh
            // 
            radTrungBinh.AutoSize = true;
            radTrungBinh.Location = new Point(6, 65);
            radTrungBinh.Name = "radTrungBinh";
            radTrungBinh.Size = new Size(100, 24);
            radTrungBinh.TabIndex = 5;
            radTrungBinh.Text = "Trung bình";
            radTrungBinh.UseVisualStyleBackColor = true;
            // 
            // cmbLoaiSuCo
            // 
            cmbLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiSuCo.FormattingEnabled = true;
            cmbLoaiSuCo.Items.AddRange(new object[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cmbLoaiSuCo.Location = new Point(97, 294);
            cmbLoaiSuCo.Name = "cmbLoaiSuCo";
            cmbLoaiSuCo.Size = new Size(156, 28);
            cmbLoaiSuCo.TabIndex = 7;
            // 
            // grpThietBi
            // 
            grpThietBi.Controls.Add(chkDienThoai);
            grpThietBi.Controls.Add(chkMayIn);
            grpThietBi.Controls.Add(chkLaptop);
            grpThietBi.Controls.Add(chkPC);
            grpThietBi.Location = new Point(12, 339);
            grpThietBi.Name = "grpThietBi";
            grpThietBi.Size = new Size(266, 99);
            grpThietBi.TabIndex = 8;
            grpThietBi.TabStop = false;
            grpThietBi.Text = "Thiết bị ảnh hưởng";
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(141, 65);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 3;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(141, 26);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(75, 24);
            chkMayIn.TabIndex = 2;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(7, 65);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkPC
            // 
            chkPC.AutoSize = true;
            chkPC.Location = new Point(7, 26);
            chkPC.Name = "chkPC";
            chkPC.Size = new Size(117, 24);
            chkPC.TabIndex = 0;
            chkPC.Text = "Máy tính bàn";
            chkPC.UseVisualStyleBackColor = true;
            // 
            // picAnhLoi
            // 
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(351, 59);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(381, 253);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 9;
            picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(365, 319);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(94, 29);
            btnTaiAnh.TabIndex = 10;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // btnGui
            // 
            btnGui.Location = new Point(497, 319);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(94, 29);
            btnGui.TabIndex = 11;
            btnGui.Text = "Gửi yêu cầu";
            btnGui.UseVisualStyleBackColor = true;
            btnGui.Click += btnGui_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(621, 319);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(97, 28);
            btnNhapLai.TabIndex = 12;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 13;
            label1.Text = "Nhập mã phiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 69);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 14;
            label2.Text = "Nhập người yêu cầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 23);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Chọn ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 297);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 16;
            label4.Text = "Loại sự cố:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGui);
            Controls.Add(btnTaiAnh);
            Controls.Add(cmbLoaiSuCo);
            Controls.Add(picAnhLoi);
            Controls.Add(grpThietBi);
            Controls.Add(grpUuTien);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Name = "Form1";
            Text = "Form1";
            grpUuTien.ResumeLayout(false);
            grpUuTien.PerformLayout();
            grpThietBi.ResumeLayout(false);
            grpThietBi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaPhieu;
        private TextBox txtNguoiYeuCau;
        private DateTimePicker dtpNgayGhiNhan;
        private GroupBox grpUuTien;
        private RadioButton radThap;
        private RadioButton radTrungBinh;
        private RadioButton radKhanCap;
        private ComboBox cmbLoaiSuCo;
        private GroupBox grpThietBi;
        private CheckBox chkDienThoai;
        private CheckBox chkMayIn;
        private CheckBox chkLaptop;
        private CheckBox chkPC;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGui;
        private Button btnNhapLai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
