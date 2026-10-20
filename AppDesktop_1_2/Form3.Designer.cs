namespace AppDesktop_1_2
{
    partial class Form3
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
            lblTitle = new Label();
            txtFeedback = new TextBox();
            lblCharCount = new Label();
            btnSend = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Ý kiến của bạn về môn học:";
            // 
            // txtFeedback
            // 
            txtFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFeedback.BorderStyle = BorderStyle.FixedSingle;
            txtFeedback.Location = new Point(24, 43);
            txtFeedback.MaxLength = 500;
            txtFeedback.Multiline = true;
            txtFeedback.Name = "txtFeedback";
            txtFeedback.ScrollBars = ScrollBars.Vertical;
            txtFeedback.Size = new Size(734, 320);
            txtFeedback.TabIndex = 1;
            // 
            // lblCharCount
            // 
            lblCharCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCharCount.AutoSize = true;
            lblCharCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCharCount.Location = new Point(24, 380);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(78, 15);
            lblCharCount.TabIndex = 2;
            lblCharCount.Text = "0 / 500 ký tự";
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(580, 375);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(85, 30);
            btnSend.TabIndex = 3;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(673, 375);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 30);
            btnClose.TabIndex = 4;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 421);
            Controls.Add(btnClose);
            Controls.Add(btnSend);
            Controls.Add(lblCharCount);
            Controls.Add(txtFeedback);
            Controls.Add(lblTitle);
            MinimumSize = new Size(400, 300);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Góp ý (bố cục co giãn)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtFeedback;
        private Label lblCharCount;
        private Button btnSend;
        private Button btnClose;
    }
}