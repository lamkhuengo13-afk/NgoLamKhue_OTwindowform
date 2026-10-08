namespace OT_baitap3
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
            grpNhapLieu = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDonGia = new TextBox();
            cmbDonVi = new ComboBox();
            txtTenVT = new TextBox();
            txtMaVT = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            grpNhapLieu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpNhapLieu
            // 
            grpNhapLieu.Controls.Add(label4);
            grpNhapLieu.Controls.Add(label3);
            grpNhapLieu.Controls.Add(label2);
            grpNhapLieu.Controls.Add(label1);
            grpNhapLieu.Controls.Add(txtDonGia);
            grpNhapLieu.Controls.Add(cmbDonVi);
            grpNhapLieu.Controls.Add(txtTenVT);
            grpNhapLieu.Controls.Add(txtMaVT);
            grpNhapLieu.Location = new Point(30, 45);
            grpNhapLieu.Name = "grpNhapLieu";
            grpNhapLieu.Size = new Size(273, 163);
            grpNhapLieu.TabIndex = 0;
            grpNhapLieu.TabStop = false;
            grpNhapLieu.Text = "Thông tin vật tư";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "Đơn vị tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên VT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã VT:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(96, 130);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 1;
            // 
            // cmbDonVi
            // 
            cmbDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDonVi.FormattingEnabled = true;
            cmbDonVi.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cmbDonVi.Location = new Point(96, 95);
            cmbDonVi.Name = "cmbDonVi";
            cmbDonVi.Size = new Size(151, 28);
            cmbDonVi.TabIndex = 1;
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(96, 62);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(125, 27);
            txtTenVT.TabIndex = 2;
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(96, 26);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(125, 27);
            txtMaVT.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(45, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(296, 293);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã VT";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên VT";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn vị tính";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn giá";
            columnHeader4.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(109, 225);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thêm mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(565, 368);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Xóa dòng";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(209, 225);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Cập nhật";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(433, 368);
            button4.Name = "button4";
            button4.Size = new Size(126, 29);
            button4.TabIndex = 5;
            button4.Text = "Xóa toàn bộ";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(361, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 350);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách vật tư";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grpNhapLieu);
            Name = "Form1";
            Text = "Form1";
            grpNhapLieu.ResumeLayout(false);
            grpNhapLieu.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNhapLieu;
        private TextBox txtDonGia;
        private ComboBox cmbDonVi;
        private TextBox txtTenVT;
        private TextBox txtMaVT;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
