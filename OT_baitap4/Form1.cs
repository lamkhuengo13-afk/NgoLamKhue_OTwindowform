using System;
using System.Drawing;
using System.Windows.Forms;

namespace OT_baitap4
{
    public partial class Form1 : Form
    {
        private int giaTien = 100000; 

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKhungGio.Items.Add("Sáng (100.000đ)");
            cmbKhungGio.Items.Add("Tối (150.000đ)");
            cmbKhungGio.SelectedIndex = 0; 
            cmbKhungGio.SelectedIndexChanged += new EventHandler(cmbKhungGio_SelectedIndexChanged);

            TaoSoDoGhe();

            btnXacNhan.Click += new EventHandler(btnXacNhan_Click);
            btnHuy.Click += new EventHandler(btnHuy_Click);
        }

        private void TaoSoDoGhe()
        {
            flpSoDo.Controls.Clear();
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Text = "Bàn " + i.ToString();
                btn.Width = 60;   
                btn.Height = 60; 
                btn.Margin = new Padding(5); 
                btn.BackColor = Color.LightGray; 
                btn.FlatStyle = FlatStyle.Flat;

                btn.Click += new EventHandler(Ghe_Click);

                flpSoDo.Controls.Add(btn);
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế này đã có người đặt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btn.BackColor == Color.LightGray)
            {
                btn.BackColor = Color.LightGreen;
            }
            else if (btn.BackColor == Color.LightGreen)
            {
                btn.BackColor = Color.LightGray;
            }

            TinhTien();
        }

        private void TinhTien()
        {
            int soLuong = 0;
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button && ctrl.BackColor == Color.LightGreen)
                {
                    soLuong++;
                }
            }

            int tongTien = soLuong * giaTien;
        }

        private void cmbKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhungGio.SelectedIndex == 0) giaTien = 100000;
            else giaTien = 150000;

            TinhTien();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soLuong = 0;
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button && ctrl.BackColor == Color.LightGreen)
                {
                    ctrl.BackColor = Color.Red; 
                    soLuong++;
                }
            }

            if (soLuong > 0)
            {
                MessageBox.Show($"Đặt thành công {soLuong} ghế!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TinhTien(); 
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn vị trí nào!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpSoDo.Controls)
            {
                if (ctrl is Button && ctrl.BackColor == Color.LightGreen)
                {
                    ctrl.BackColor = Color.LightGray;
                }
            }
            TinhTien(); 
        }
    }
}