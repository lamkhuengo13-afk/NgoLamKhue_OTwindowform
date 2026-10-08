using System;
using System.Windows.Forms;

namespace OT_baitap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);

            button1.Click += new EventHandler(btnThem_Click);
            button2.Click += new EventHandler(btnCapNhat_Click);
            button3.Click += new EventHandler(btnXoa_Click);
            button4.Click += new EventHandler(btnXoaHet_Click);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) || string.IsNullOrWhiteSpace(txtTenVT.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) || cmbDonVi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDonGia.Text, out double donGia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == txtMaVT.Text.Trim())
                {
                    MessageBox.Show("Mã Vật Tư này đã tồn tại trong danh sách!", "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(txtMaVT.Text.Trim());
            newItem.SubItems.Add(txtTenVT.Text.Trim());
            newItem.SubItems.Add(cmbDonVi.Text);
            newItem.SubItems.Add(donGia.ToString("N0"));

            listView1.Items.Add(newItem);
            ResetForm();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                txtMaVT.Text = selectedItem.Text;
                txtTenVT.Text = selectedItem.SubItems[1].Text;
                cmbDonVi.Text = selectedItem.SubItems[2].Text;
                txtDonGia.Text = selectedItem.SubItems[3].Text.Replace(",", "").Replace(".", "");
                txtMaVT.ReadOnly = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (!double.TryParse(txtDonGia.Text, out double donGia))
                {
                    MessageBox.Show("Đơn giá phải là số hợp lệ!", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedItem.SubItems[1].Text = txtTenVT.Text.Trim();
                selectedItem.SubItems[2].Text = cmbDonVi.Text;
                selectedItem.SubItems[3].Text = donGia.ToString("N0");

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách để cập nhật!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn sắp XÓA TẤT CẢ dữ liệu. Bạn có chắc chắn không?", "Cảnh báo nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listView1.Items.Clear();
                    ResetForm();
                }
            }
        }

        private void ResetForm()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            cmbDonVi.SelectedIndex = -1;
            txtMaVT.ReadOnly = false;
            txtMaVT.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}