namespace AppDesktop_1_2
{
    partial class Form5: Form
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
            panelDraw = new Panel();
            btnChonMau = new Button();
            btnXoaHet = new Button();
            lblToaDo = new Label();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // panelDraw
            // 
            panelDraw.Location = new Point(12, 12);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(741, 384);
            panelDraw.TabIndex = 0;
            panelDraw.Paint += panelDraw_Paint;
            panelDraw.MouseDown += panelDraw_MouseDown;
            panelDraw.MouseMove += panelDraw_MouseMove;
            panelDraw.MouseUp += panelDraw_MouseUp;
            // 
            // btnChonMau
            // 
            btnChonMau.Location = new Point(12, 410);
            btnChonMau.Name = "btnChonMau";
            btnChonMau.Size = new Size(103, 23);
            btnChonMau.TabIndex = 1;
            btnChonMau.Text = "Chọn màu ...";
            btnChonMau.UseVisualStyleBackColor = true;
            btnChonMau.Click += btnSelectColor_Click;
            // 
            // btnXoaHet
            // 
            btnXoaHet.Location = new Point(121, 410);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(75, 23);
            btnXoaHet.TabIndex = 2;
            btnXoaHet.Text = "Xóa hết";
            btnXoaHet.UseVisualStyleBackColor = true;
            btnXoaHet.Paint += panelDraw_Paint;
            // 
            // lblToaDo
            // 
            lblToaDo.AutoSize = true;
            lblToaDo.BorderStyle = BorderStyle.FixedSingle;
            lblToaDo.Location = new Point(643, 414);
            lblToaDo.Name = "lblToaDo";
            lblToaDo.Size = new Size(66, 17);
            lblToaDo.TabIndex = 3;
            lblToaDo.Text = "x = 0, y = 0";
            lblToaDo.Paint += panelDraw_Paint;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 445);
            Controls.Add(lblToaDo);
            Controls.Add(btnXoaHet);
            Controls.Add(btnChonMau);
            Controls.Add(panelDraw);
            Name = "Form5";
            Text = "Bảng vẽ bằng chuột";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDraw;
        private Button btnChonMau;
        private Button btnXoaHet;
        private Label lblToaDo;
        private ColorDialog colorDialog1;
    }
}