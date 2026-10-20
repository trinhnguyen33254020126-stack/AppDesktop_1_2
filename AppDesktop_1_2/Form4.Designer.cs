namespace AppDesktop_1_2
{
    partial class Form4
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
            lblSoGiay = new Label();
            nudSoGiay = new NumericUpDown();
            btnBatDau = new Button();
            btnDung = new Button();
            lblHienSoGiay = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudSoGiay).BeginInit();
            SuspendLayout();
            // 
            // lblSoGiay
            // 
            lblSoGiay.AutoSize = true;
            lblSoGiay.Location = new Point(27, 36);
            lblSoGiay.Name = "lblSoGiay";
            lblSoGiay.Size = new Size(45, 15);
            lblSoGiay.TabIndex = 0;
            lblSoGiay.Text = "Số giây";
            // 
            // nudSoGiay
            // 
            nudSoGiay.Location = new Point(81, 34);
            nudSoGiay.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nudSoGiay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoGiay.Name = "nudSoGiay";
            nudSoGiay.Size = new Size(120, 23);
            nudSoGiay.TabIndex = 1;
            nudSoGiay.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnBatDau
            // 
            btnBatDau.Location = new Point(259, 32);
            btnBatDau.Name = "btnBatDau";
            btnBatDau.Size = new Size(75, 23);
            btnBatDau.TabIndex = 2;
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.UseVisualStyleBackColor = true;
            btnBatDau.Click += btnBatDau_Click;
            // 
            // btnDung
            // 
            btnDung.Location = new Point(340, 32);
            btnDung.Name = "btnDung";
            btnDung.Size = new Size(75, 23);
            btnDung.TabIndex = 3;
            btnDung.Text = "Dừng";
            btnDung.UseVisualStyleBackColor = true;
            btnDung.Click += btnDung_Click;
            // 
            // lblHienSoGiay
            // 
            lblHienSoGiay.AutoSize = true;
            lblHienSoGiay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHienSoGiay.ForeColor = SystemColors.ActiveCaptionText;
            lblHienSoGiay.Location = new Point(178, 103);
            lblHienSoGiay.Name = "lblHienSoGiay";
            lblHienSoGiay.Size = new Size(83, 37);
            lblHienSoGiay.TabIndex = 4;
            lblHienSoGiay.Text = "00:10";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(28, 157);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(387, 14);
            progressBar1.TabIndex = 5;
            progressBar1.Click += btnBatDau_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 221);
            Controls.Add(progressBar1);
            Controls.Add(lblHienSoGiay);
            Controls.Add(btnDung);
            Controls.Add(btnBatDau);
            Controls.Add(nudSoGiay);
            Controls.Add(lblSoGiay);
            Name = "Form4";
            Text = "Đồng hồ đếm ngược";
            ((System.ComponentModel.ISupportInitialize)nudSoGiay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoGiay;
        private NumericUpDown nudSoGiay;
        private Button btnBatDau;
        private Button btnDung;
        private Label lblHienSoGiay;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}