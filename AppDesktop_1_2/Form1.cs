using System;
using System.Windows.Forms; // Bắt buộc phải có dòng này

namespace AppDesktop_1_2
{
    public partial class Form1 : Form // Phải thêm ": Form" ở đây
    {
        public Form1()
        {
            InitializeComponent();
        }


        // 1. Chỉ cho phép nhập số, dấu phẩy/chấm và phím Backspace (Không cho gõ chữ)
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép các phím điều khiển (như Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Cho phép các chữ số
            if (char.IsDigit(e.KeyChar))
                return;

            // Cho phép dấu phẩy ',' hoặc chấm '.' đại diện cho số thập phân
            TextBox txt = sender as TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !txt.Text.Contains(",") && !txt.Text.Contains("."))
            {
                // Quy đổi về dấu phân cách thập phân chuẩn của hệ thống
                e.KeyChar = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                return;
            }

            // Chặn tất cả các ký tự khác (chữ cái, ký tự đặc biệt...)
            e.Handled = true;
        }

        // 2. Hàm xử lý tính toán chung cho 4 phép tính
        private void ThucHienPhepTinh(char phepTinh)
        {
            // Xóa báo lỗi cũ
            errorProvider1.SetError(txtSo1, "");
            errorProvider1.SetError(txtSo2, "");
            lblKetQua.Text = "Kết quả:";

            bool hopLe = true;
            double so1 = 0, so2 = 0;

            // Kiểm tra số thứ nhất
            if (string.IsNullOrWhiteSpace(txtSo1.Text) || !double.TryParse(txtSo1.Text, out so1))
            {
                errorProvider1.SetError(txtSo1, "Số thứ nhất không hợp lệ!");
                hopLe = false;
            }

            // Kiểm tra số thứ hai
            if (string.IsNullOrWhiteSpace(txtSo2.Text) || !double.TryParse(txtSo2.Text, out so2))
            {
                errorProvider1.SetError(txtSo2, "Số thứ hai không hợp lệ!");
                hopLe = false;
            }

            // Nếu dữ liệu đầu vào không hợp lệ thì dừng
            if (!hopLe) return;

            // Kiểm tra lỗi chia cho 0
            if (phepTinh == '÷' && so2 == 0)
            {
                errorProvider1.SetError(txtSo2, "Không chia được cho 0");
                return;
            }

            // Tính toán kết quả
            double ketQua = 0;
            switch (phepTinh)
            {
                case '+':
                    ketQua = so1 + so2;
                    break;
                case '-':
                    ketQua = so1 - so2;
                    break;
                case '×':
                    ketQua = so1 * so2;
                    break;
                case '÷':
                    ketQua = so1 / so2;
                    break;
            }

            // Hiển thị kết quả định dạng 2 chữ số thập phân (ví dụ: 12,50 × 4,00 = 50,00)
            lblKetQua.Text = $"Kết quả: {so1:N2} {phepTinh} {so2:N2} = {ketQua:N2}";
        }

        // 3. Sự kiện Click của các nút bấm
        private void btnCong_Click(object sender, EventArgs e)
        {
            ThucHienPhepTinh('+');
        }

        // Dấu trừ
        private void btnTru_Click(object sender, EventArgs e)
        {
            ThucHienPhepTinh('-');
        }

        // Dấu nhân
        private void btnNhan_Click(object sender, EventArgs e)
        {
            ThucHienPhepTinh('×');
        }

        // Dấu chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            ThucHienPhepTinh('÷');
        }
    }
}