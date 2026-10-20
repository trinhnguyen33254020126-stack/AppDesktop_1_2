using System;
using System.Windows.Forms;

namespace AppDesktop_1_2;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();

        // Đăng ký chung 1 sự kiện cho tất cả các điều khiển
        // Giúp ứng dụng tự động cập nhật kết quả ngay khi người dùng thay đổi giá trị
        nudNhietDo.ValueChanged += CapNhatKetQua;
        rdbCtoF.CheckedChanged += CapNhatKetQua;
        rdbFtoC.CheckedChanged += CapNhatKetQua;
        chkLamTron.CheckedChanged += CapNhatKetQua;

        // Tính toán lần đầu khi mở Form
        CapNhatKetQua(null, null);
    }

    private void CapNhatKetQua(object sender, EventArgs e)
    {
        // Lấy giá trị nhiệt độ nhập vào
        double val = (double)nudNhietDo.Value;
        double ketQua = 0;

        if (rdbCtoF.Checked)
        {
            // Công thức: °F = °C * 1.8 + 32
            ketQua = val * 1.8 + 32;

            if (chkLamTron.Checked)
            {
                ketQua = Math.Round(ketQua);
                val = Math.Round(val);
                lblKetQua.Text = $"{val} °C = {ketQua} °F";
            }
            else
            {
                lblKetQua.Text = $"{val:0.#} °C = {ketQua:0.#} °F";
            }
        }
        else // Chuyển từ °F sang °C
        {
            // Công thức: °C = (°F - 32) / 1.8
            ketQua = (val - 32) / 1.8;

            if (chkLamTron.Checked)
            {
                ketQua = Math.Round(ketQua);
                val = Math.Round(val);
                lblKetQua.Text = $"{val} °F = {ketQua} °C";
            }
            else
            {
                lblKetQua.Text = $"{val:0.#} °F = {ketQua:0.#} °C";
            }
        }
    }
}