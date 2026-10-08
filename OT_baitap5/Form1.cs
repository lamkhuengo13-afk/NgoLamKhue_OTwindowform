using System;
using System.Drawing;
using System.Windows.Forms;

namespace OT_baitap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form5_Load);
            timer1.Tick += new EventHandler(timer1_Tick);
            dataGridView1.CellValidating += new DataGridViewCellValidatingEventHandler(dataGridView1_CellValidating);
            dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            this.KeyDown += new KeyEventHandler(Form5_KeyDown);
            this.KeyPreview = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmbLoaiVC.Items.Add("Giao thường");
            cmbLoaiVC.Items.Add("Giao hỏa tốc");
            cmbLoaiVC.SelectedIndex = 0;

            timer1.Start();
            CapNhatStatusStrip();

            // Tự động tạo nút "Xác nhận đơn hàng" bằng code ở nửa bên trái (Panel1)
            Button btnXacNhan = new Button();
            btnXacNhan.Text = "Xác nhận đơn hàng";
            btnXacNhan.Location = new Point(20, 200); // Tọa độ đặt bên dưới các ô nhập thông tin
            btnXacNhan.Size = new Size(160, 35);
            btnXacNhan.BackColor = Color.LightGreen;
            btnXacNhan.Click += new EventHandler(btnXacNhan_Click);

            // Thêm nút vào Panel1 của SplitContainer
            if (splitContainer1 != null && splitContainer1.Panel1 != null)
            {
                splitContainer1.Panel1.Controls.Add(btnXacNhan);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = "⏰ Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dataGridView1.Rows.Add();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    CapNhatStatusStrip();
                }
                e.Handled = true;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                string valueStr = e.FormattedValue.ToString();
                if (!string.IsNullOrWhiteSpace(valueStr))
                {
                    if (!double.TryParse(valueStr, out double val) || val <= 0)
                    {
                        MessageBox.Show("Số lượng và trọng lượng bắt buộc phải lớn hơn 0!", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (e.ColumnIndex == 1 || e.ColumnIndex == 3)
                {
                    double.TryParse(row.Cells[1].Value?.ToString(), out double soLuong);
                    double.TryParse(row.Cells[3].Value?.ToString(), out double donGia);

                    double thanhTien = soLuong * donGia; // Đã sửa lỗi dấu nhân
                    row.Cells[4].Value = thanhTien;
                }

                CapNhatStatusStrip();
            }
            catch (Exception)
            {
                // Bắt ngoại lệ tránh crash
            }
        }

        private void CapNhatStatusStrip()
        {
            double tongSL = 0;
            double tongTL = 0;
            double tongTien = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                double.TryParse(row.Cells[1].Value?.ToString(), out double sl);
                double.TryParse(row.Cells[2].Value?.ToString(), out double tl);
                double.TryParse(row.Cells[4].Value?.ToString(), out double tt);

                tongSL += sl;
                tongTL += (sl * tl); // Đã sửa lỗi dấu nhân
                tongTien += tt;
            }

            lblTongSL.Text = $" | Tổng SL: {tongSL}";
            lblTongTL.Text = $" | Tổng TL: {tongTL} kg";
            lblTongTien.Text = $" | Tổng tiền đơn hàng: {tongTien:N0} VNĐ";
        }

        // Xử lý sự kiện khi bấm nút Xác nhận đơn hàng
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }

            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("Đơn hàng chưa có sản phẩm nào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double tongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                double.TryParse(row.Cells[4].Value?.ToString(), out double tt);
                tongTien += tt;
            }

            MessageBox.Show($"Xác nhận thành công đơn hàng cho khách: {txtTenKH.Text}!\nTổng giá trị đơn: {tongTien:N0} VNĐ\nLoại vận chuyển: {cmbLoaiVC.Text}",
                            "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}