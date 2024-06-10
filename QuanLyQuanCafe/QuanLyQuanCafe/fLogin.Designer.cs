namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_Exit = new Button();
            btn_Login = new Button();
            panel3 = new Panel();
            txt_PassWord = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txt_UserName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Exit);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(10, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 216);
            panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(387, 151);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(150, 47);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(108, 149);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(160, 49);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Đăng nhập";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_PassWord);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(7, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 56);
            panel3.TabIndex = 2;
            // 
            // txt_PassWord
            // 
            txt_PassWord.Location = new Point(200, 12);
            txt_PassWord.Name = "txt_PassWord";
            txt_PassWord.Size = new Size(421, 27);
            txt_PassWord.TabIndex = 1;
            txt_PassWord.Text = "123";
            txt_PassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_UserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(7, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 56);
            panel2.TabIndex = 0;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(200, 12);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(421, 27);
            txt_UserName.TabIndex = 1;
            txt_UserName.Text = "linhtikay";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(159, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // fLogin
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btn_Exit;
            ClientSize = new Size(688, 243);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox txt_PassWord;
        private Label label2;
        private TextBox txt_UserName;
        private Button btn_Login;
        private Button btn_Exit;
    }
}