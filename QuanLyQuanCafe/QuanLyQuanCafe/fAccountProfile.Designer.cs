namespace QuanLyQuanCafe
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txt_UserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txt_DisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txt_PassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txt_NewPassWord = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txt_ReEnterPass = new TextBox();
            label5 = new Label();
            btn_Update = new Button();
            btn_Exit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_UserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 56);
            panel2.TabIndex = 1;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(195, 12);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.ReadOnly = true;
            txt_UserName.Size = new Size(376, 27);
            txt_UserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_DisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 56);
            panel1.TabIndex = 2;
            // 
            // txt_DisplayName
            // 
            txt_DisplayName.Location = new Point(195, 15);
            txt_DisplayName.Name = "txt_DisplayName";
            txt_DisplayName.Size = new Size(376, 27);
            txt_DisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_PassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(574, 56);
            panel3.TabIndex = 3;
            // 
            // txt_PassWord
            // 
            txt_PassWord.Location = new Point(195, 15);
            txt_PassWord.Name = "txt_PassWord";
            txt_PassWord.Size = new Size(376, 27);
            txt_PassWord.TabIndex = 1;
            txt_PassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 15);
            label3.Name = "label3";
            label3.Size = new Size(104, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txt_NewPassWord);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(574, 56);
            panel4.TabIndex = 4;
            // 
            // txt_NewPassWord
            // 
            txt_NewPassWord.Location = new Point(195, 12);
            txt_NewPassWord.Name = "txt_NewPassWord";
            txt_NewPassWord.Size = new Size(376, 27);
            txt_NewPassWord.TabIndex = 1;
            txt_NewPassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 15);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_ReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 56);
            panel5.TabIndex = 5;
            // 
            // txt_ReEnterPass
            // 
            txt_ReEnterPass.Location = new Point(195, 12);
            txt_ReEnterPass.Name = "txt_ReEnterPass";
            txt_ReEnterPass.Size = new Size(376, 27);
            txt_ReEnterPass.TabIndex = 1;
            txt_ReEnterPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(186, 24);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khẩu:";
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.Location = new Point(322, 332);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(129, 45);
            btn_Update.TabIndex = 6;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(457, 332);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(129, 45);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btn_Update;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Exit;
            ClientSize = new Size(598, 403);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Update);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txt_UserName;
        private Label label1;
        private Panel panel1;
        private TextBox txt_DisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txt_PassWord;
        private Label label3;
        private Panel panel4;
        private TextBox txt_NewPassWord;
        private Label label4;
        private Panel panel5;
        private TextBox txt_ReEnterPass;
        private Label label5;
        private Button btn_Update;
        private Button btn_Exit;
    }
}