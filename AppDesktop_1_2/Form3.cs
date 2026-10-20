using System;
using System.Windows.Forms;

namespace AppDesktop_1_2
{
    public partial class Form3 : Form
    {
        private const int MAX_LENGTH = 500;

        public Form3()
        {
            InitializeComponent();
            txtFeedback.MaxLength = MAX_LENGTH;
            UpdateCharCount();
        }

        private void UpdateCharCount()
        {
            int currentLength = txtFeedback.Text.Length;
            lblCharCount.Text = $"{currentLength} / {MAX_LENGTH} ký tự";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Vui lòng nhập ý kiến trước khi gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Cảm ơn bạn đã gửi góp ý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFeedback.Clear();
        }
    }
}