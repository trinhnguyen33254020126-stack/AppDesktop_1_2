using System;
using System.Media; // Thư viện để phát âm thanh báo
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDesktop_1_2;

public partial class Form4 : Form
{
    private int totalSeconds = 0; // Tổng số giây đếm ngược
    private int currentSeconds = 0; // Số giây còn lại

    public Form4()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Khởi tạo hiển thị ban đầu
        lblHienSoGiay.Text = string.Format("00:{0:D2}", (int)nudSoGiay.Value);
    }

    // Sự kiện khi nhấn nút Bắt đầu
    private void btnBatDau_Click(object sender, EventArgs e)
    {
        totalSeconds = (int)nudSoGiay.Value;
        currentSeconds = totalSeconds;

        // Cấu hình thanh tiến độ ProgressBar
        progressBar1.Maximum = totalSeconds;
        progressBar1.Value = 0;

        // Hiển thị thời gian ban đầu
        CapNhatGiaoDien();

        // Khởi chạy Timer
        timer1.Start();

        // Quản lý trạng thái nút
        btnBatDau.Enabled = false;
        nudSoGiay.Enabled = false;
        btnDung.Enabled = true;
    }

    // Sự kiện khi nhấn nút Dừng
    private void btnDung_Click(object sender, EventArgs e)
    {
        timer1.Stop();

        // Khôi phục lại trạng thái giao diện
        btnBatDau.Enabled = true;
        nudSoGiay.Enabled = true;
        btnDung.Enabled = true;
    }

    // Sự kiện đếm theo từng chu kỳ 1 giây của Timer
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (currentSeconds > 0)
        {
            currentSeconds--;
            CapNhatGiaoDien();
        }
        else
        {
            // Hết giờ
            timer1.Stop();

            // Phát tiếng báo hiệu của hệ thống
            SystemSounds.Beep.Play(); // Hoặc SystemSounds.Exclamation.Play();

            MessageBox.Show("Hết giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Khôi phục giao diện
            btnBatDau.Enabled = true;
            nudSoGiay.Enabled = true;
        }
    }

    // Hàm hỗ trợ cập nhật nhãn thời gian và thanh tiến độ
    private void CapNhatGiaoDien()
    {
        // Định dạng mm:ss
        TimeSpan time = TimeSpan.FromSeconds(currentSeconds);
        lblHienSoGiay.Text = time.ToString(@"mm\:ss");

        // Thanh tiến độ tăng dần theo thời gian đã trôi qua
        int progress = totalSeconds - currentSeconds;
        if (progress <= progressBar1.Maximum)
        {
            progressBar1.Value = progress;
        }
    }
}