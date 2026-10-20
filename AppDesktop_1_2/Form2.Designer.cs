namespace AppDesktop_1_2
{
    partial class Form2: Form
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
            groupBox1 = new GroupBox();
            rdbFtoC = new RadioButton();
            rdbCtoF = new RadioButton();
            lblNhietDo = new Label();
            nudNhietDo = new NumericUpDown();
            chkLamTron = new CheckBox();
            lblKetQua = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNhietDo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbFtoC);
            groupBox1.Controls.Add(rdbCtoF);
            groupBox1.Location = new Point(21, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chiều đổi";
            // 
            // rdbFtoC
            // 
            rdbFtoC.AutoSize = true;
            rdbFtoC.Location = new Point(16, 50);
            rdbFtoC.Name = "rdbFtoC";
            rdbFtoC.Size = new Size(68, 19);
            rdbFtoC.TabIndex = 1;
            rdbFtoC.TabStop = true;
            rdbFtoC.Text = "°F -> °C";
            rdbFtoC.UseVisualStyleBackColor = true;
            // 
            // rdbCtoF
            // 
            rdbCtoF.AutoSize = true;
            rdbCtoF.Location = new Point(16, 27);
            rdbCtoF.Name = "rdbCtoF";
            rdbCtoF.Size = new Size(68, 19);
            rdbCtoF.TabIndex = 0;
            rdbCtoF.TabStop = true;
            rdbCtoF.Text = "°C -> °F";
            rdbCtoF.UseVisualStyleBackColor = true;
            // 
            // lblNhietDo
            // 
            lblNhietDo.AutoSize = true;
            lblNhietDo.Location = new Point(210, 26);
            lblNhietDo.Name = "lblNhietDo";
            lblNhietDo.Size = new Size(53, 15);
            lblNhietDo.TabIndex = 1;
            lblNhietDo.Text = "Nhiệt độ";
            // 
            // nudNhietDo
            // 
            nudNhietDo.Location = new Point(210, 49);
            nudNhietDo.Name = "nudNhietDo";
            nudNhietDo.Size = new Size(147, 23);
            nudNhietDo.TabIndex = 2;
            // 
            // chkLamTron
            // 
            chkLamTron.AutoSize = true;
            chkLamTron.Location = new Point(210, 81);
            chkLamTron.Name = "chkLamTron";
            chkLamTron.Size = new Size(155, 19);
            chkLamTron.TabIndex = 3;
            chkLamTron.Text = "Làm tròn đến số nguyên";
            chkLamTron.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            lblKetQua.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKetQua.ForeColor = Color.Blue;
            lblKetQua.Location = new Point(21, 124);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(336, 70);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "label2";
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 255);
            Controls.Add(lblKetQua);
            Controls.Add(chkLamTron);
            Controls.Add(nudNhietDo);
            Controls.Add(lblNhietDo);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Đổi nhiệt độ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNhietDo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNhietDo;
        private NumericUpDown nudNhietDo;
        private CheckBox chkLamTron;
        private Label lblKetQua;
        private RadioButton rdbFtoC;
        private RadioButton rdbCtoF;
    }
}