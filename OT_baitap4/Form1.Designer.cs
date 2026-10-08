namespace OT_baitap4
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
            flpSoDo = new FlowLayoutPanel();
            cmbKhungGio = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnXacNhan = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // flpSoDo
            // 
            flpSoDo.Location = new Point(21, 25);
            flpSoDo.Name = "flpSoDo";
            flpSoDo.Size = new Size(767, 304);
            flpSoDo.TabIndex = 0;
            // 
            // cmbKhungGio
            // 
            cmbKhungGio.FormattingEnabled = true;
            cmbKhungGio.Location = new Point(21, 335);
            cmbKhungGio.Name = "cmbKhungGio";
            cmbKhungGio.Size = new Size(151, 28);
            cmbKhungGio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 366);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Số vị trí đang chọn: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 386);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 3;
            label2.Text = "Tạm tính tiền: 0 VNĐ";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(507, 335);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(118, 29);
            btnXacNhan.TabIndex = 4;
            btnXacNhan.Text = "Xác nhận đặt";
            btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(631, 335);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(157, 29);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy chọn tất cả";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbKhungGio);
            Controls.Add(flpSoDo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpSoDo;
        private ComboBox cmbKhungGio;
        private Label label1;
        private Label label2;
        private Button btnXacNhan;
        private Button btnHuy;
    }
}
