namespace OT_baitap5
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            statusStrip1 = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            lblTongSL = new ToolStripStatusLabel();
            lblTongTL = new ToolStripStatusLabel();
            lblTongTien = new ToolStripStatusLabel();
            cmbLoaiVC = new ComboBox();
            txtDiaChi = new Label();
            txtDienThoai = new Label();
            txtTenKH = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(statusStrip1);
            splitContainer1.Panel1.Controls.Add(cmbLoaiVC);
            splitContainer1.Panel1.Controls.Add(txtDiaChi);
            splitContainer1.Panel1.Controls.Add(txtDienThoai);
            splitContainer1.Panel1.Controls.Add(txtTenKH);
            splitContainer1.Panel1.Controls.Add(textBox3);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 385;
            splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThoiGian, lblTongSL, lblTongTL, lblTongTien });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(385, 26);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(151, 20);
            lblThoiGian.Text = "toolStripStatusLabel1";
            // 
            // lblTongSL
            // 
            lblTongSL.Name = "lblTongSL";
            lblTongSL.Size = new Size(151, 20);
            lblTongSL.Text = "toolStripStatusLabel2";
            // 
            // lblTongTL
            // 
            lblTongTL.Name = "lblTongTL";
            lblTongTL.Size = new Size(151, 20);
            lblTongTL.Text = "toolStripStatusLabel3";
            // 
            // lblTongTien
            // 
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(151, 20);
            lblTongTien.Text = "toolStripStatusLabel4";
            // 
            // cmbLoaiVC
            // 
            cmbLoaiVC.FormattingEnabled = true;
            cmbLoaiVC.Location = new Point(115, 168);
            cmbLoaiVC.Name = "cmbLoaiVC";
            cmbLoaiVC.Size = new Size(151, 28);
            cmbLoaiVC.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.AutoSize = true;
            txtDiaChi.Location = new Point(12, 142);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(58, 20);
            txtDiaChi.TabIndex = 5;
            txtDiaChi.Text = "Địa chỉ:";
            // 
            // txtDienThoai
            // 
            txtDienThoai.AutoSize = true;
            txtDienThoai.Location = new Point(12, 82);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(100, 20);
            txtDienThoai.TabIndex = 4;
            txtDienThoai.Text = "Số điện thoại:";
            // 
            // txtTenKH
            // 
            txtTenKH.AutoSize = true;
            txtTenKH.Location = new Point(12, 29);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(114, 20);
            txtTenKH.TabIndex = 3;
            txtTenKH.Text = "Tên khách hàng:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dataGridView1.Location = new Point(20, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(370, 358);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colTenHang
            // 
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            colTenHang.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 125;
            // 
            // colTrongLuong
            // 
            colTrongLuong.HeaderText = "Trọng lượng ";
            colTrongLuong.MinimumWidth = 6;
            colTrongLuong.Name = "colTrongLuong";
            colTrongLuong.Width = 125;
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.Width = 125;
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 125;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label txtDiaChi;
        private Label txtDienThoai;
        private Label txtTenKH;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ComboBox cmbLoaiVC;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private ToolStripStatusLabel lblThoiGian;
        private ToolStripStatusLabel lblTongSL;
        private ToolStripStatusLabel lblTongTL;
        private ToolStripStatusLabel lblTongTien;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}
