using System;
using System.Windows.Forms;

namespace OT_baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
            ofd.Title = "Chọn ảnh chụp lỗi";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhLoi.ImageLocation = ofd.FileName;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) ||
                string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text) ||
                cmbLoaiSuCo.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền mã phiếu, tên người yêu cầu và chọn loại sự cố!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mucDo = "";
            if (radThap.Checked) mucDo = radThap.Text;
            else if (radTrungBinh.Checked) mucDo = radTrungBinh.Text;
            else if (radKhanCap.Checked) mucDo = radKhanCap.Text;

            string thietBi = "";
            if (chkPC.Checked) thietBi += chkPC.Text + ", ";
            if (chkLaptop.Checked) thietBi += chkLaptop.Text + ", ";
            if (chkMayIn.Checked) thietBi += chkMayIn.Text + ", ";
            if (chkDienThoai.Checked) thietBi += chkDienThoai.Text + ", ";

            if (thietBi.Length > 0)
            {
                thietBi = thietBi.Substring(0, thietBi.Length - 2);
            }
            else
            {
                thietBi = "Không có thiết bị cụ thể";
            }

            string tomTat = $"--- TÓM TẮT YÊU CẦU IT ---\n" +
                            $"Mã phiếu: {txtMaPhieu.Text}\n" +
                            $"Người yêu cầu: {txtNguoiYeuCau.Text}\n" +
                            $"Ngày ghi nhận: {dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy")}\n" +
                            $"Mức độ ưu tiên: {mucDo}\n" +
                            $"Loại sự cố: {cmbLoaiSuCo.SelectedItem.ToString()}\n" +
                            $"Thiết bị ảnh hưởng: {thietBi}";

            MessageBox.Show(tomTat, "Chi tiết Phiếu Hỗ Trợ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();

            dtpNgayGhiNhan.Value = DateTime.Now;

            cmbLoaiSuCo.SelectedIndex = -1;

            radThap.Checked = true;

            chkPC.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            picAnhLoi.Image = null;

            txtMaPhieu.Focus();
        }
    }
}