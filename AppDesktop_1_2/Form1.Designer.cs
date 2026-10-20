namespace AppDesktop_1_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblSo1 = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            lblSo2 = new Label();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            lblKetQua = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblSo1
            // 
            lblSo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSo1.AutoSize = true;
            lblSo1.Location = new Point(50, 27);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(68, 15);
            lblSo1.TabIndex = 0;
            lblSo1.Text = "Số thứ nhất";
            // 
            // txtSo1
            // 
            txtSo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSo1.Location = new Point(131, 25);
            txtSo1.Name = "txtSo1";
            txtSo1.RightToLeft = RightToLeft.Yes;
            txtSo1.Size = new Size(262, 23);
            txtSo1.TabIndex = 2;
            txtSo1.KeyPress += txtSo_KeyPress;
            // 
            // txtSo2
            // 
            txtSo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSo2.Location = new Point(131, 63);
            txtSo2.Name = "txtSo2";
            txtSo2.RightToLeft = RightToLeft.Yes;
            txtSo2.Size = new Size(262, 23);
            txtSo2.TabIndex = 4;
            txtSo2.KeyPress += txtSo_KeyPress;
            // 
            // lblSo2
            // 
            lblSo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSo2.AutoSize = true;
            lblSo2.Location = new Point(50, 65);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(60, 15);
            lblSo2.TabIndex = 3;
            lblSo2.Text = "Số thứ hai";
            // 
            // btnCong
            // 
            btnCong.Location = new Point(137, 102);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(57, 30);
            btnCong.TabIndex = 5;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(200, 102);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(57, 30);
            btnTru.TabIndex = 6;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(263, 102);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(57, 30);
            btnNhan.TabIndex = 7;
            btnNhan.Text = "×";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(326, 102);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(57, 30);
            btnChia.TabIndex = 8;
            btnChia.Text = "÷";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblKetQua.Location = new Point(50, 161);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(60, 17);
            lblKetQua.TabIndex = 9;
            lblKetQua.Text = "Kết quả:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 213);
            Controls.Add(lblKetQua);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtSo2);
            Controls.Add(lblSo2);
            Controls.Add(txtSo1);
            Controls.Add(lblSo1);
            Name = "Form1";
            Text = "Ví dụ 2.1 - Máy tính bốn phép tính";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSo1;
        private TextBox txtSo1;
        private TextBox txtSo2;
        private Label lblSo2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Label lblKetQua;
        private ErrorProvider errorProvider1;
    }
}