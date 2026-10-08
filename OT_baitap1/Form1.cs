namespace OT_baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            bool isDonGiaValid = double.TryParse(txtDonGia.Text, out double donGia);
            bool isSoLuongValid = int.TryParse(txtSoLuong.Text, out int soLuong);
            bool isGiamGiaValid = double.TryParse(txtGiamGia.Text, out double giamGia);

            if (!isDonGiaValid || !isSoLuongValid || !isGiamGiaValid)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào các ô!\nKhông được để trống hoặc nhập chữ.", "Báo lỗi");
                return;
            }

            double tongTien = (donGia * soLuong) * ((100.0 - giamGia) / 100.0);

            lblTongTien.Text = "Tổng tiền thanh toán: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();

            lblTongTien.Text = "Tổng tiền thanh toán: 0 VNĐ";

            txtDonGia.Focus();
        }
    }
}
