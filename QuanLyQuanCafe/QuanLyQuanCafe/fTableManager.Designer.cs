namespace QuanLyQuanCafe
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsv_Bill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            label2 = new Label();
            txt_TotalPrice = new TextBox();
            label1 = new Label();
            cbo_SwitchTable = new ComboBox();
            btn_SwitchTable = new Button();
            nm_Discount = new NumericUpDown();
            btn_CheckOut = new Button();
            panel4 = new Panel();
            nm_FoodCount = new NumericUpDown();
            btn_AddFood = new Button();
            cbo_Food = new ComboBox();
            cbo_Category = new ComboBox();
            flp_Table = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_Discount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1124, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsv_Bill);
            panel2.Location = new Point(666, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 468);
            panel2.TabIndex = 2;
            // 
            // lsv_Bill
            // 
            lsv_Bill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsv_Bill.GridLines = true;
            lsv_Bill.Location = new Point(3, 3);
            lsv_Bill.Name = "lsv_Bill";
            lsv_Bill.Size = new Size(440, 462);
            lsv_Bill.TabIndex = 0;
            lsv_Bill.UseCompatibleStateImageBehavior = false;
            lsv_Bill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên món";
            columnHeader1.Width = 193;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 90;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txt_TotalPrice);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbo_SwitchTable);
            panel3.Controls.Add(btn_SwitchTable);
            panel3.Controls.Add(nm_Discount);
            panel3.Controls.Add(btn_CheckOut);
            panel3.Location = new Point(666, 624);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 78);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(117, 8);
            label2.Name = "label2";
            label2.Size = new Size(94, 27);
            label2.TabIndex = 10;
            label2.Text = " Giảm giá ";
            // 
            // txt_TotalPrice
            // 
            txt_TotalPrice.BackColor = SystemColors.Control;
            txt_TotalPrice.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TotalPrice.ForeColor = Color.IndianRed;
            txt_TotalPrice.Location = new Point(229, 45);
            txt_TotalPrice.Name = "txt_TotalPrice";
            txt_TotalPrice.ReadOnly = true;
            txt_TotalPrice.Size = new Size(100, 28);
            txt_TotalPrice.TabIndex = 9;
            txt_TotalPrice.Text = "0";
            txt_TotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 8;
            label1.Text = "Tổng tiền";
            // 
            // cbo_SwitchTable
            // 
            cbo_SwitchTable.FormattingEnabled = true;
            cbo_SwitchTable.Location = new Point(3, 45);
            cbo_SwitchTable.Name = "cbo_SwitchTable";
            cbo_SwitchTable.Size = new Size(108, 28);
            cbo_SwitchTable.TabIndex = 4;
            // 
            // btn_SwitchTable
            // 
            btn_SwitchTable.Location = new Point(3, 4);
            btn_SwitchTable.Name = "btn_SwitchTable";
            btn_SwitchTable.Size = new Size(108, 36);
            btn_SwitchTable.TabIndex = 6;
            btn_SwitchTable.Text = "Chuyển bàn";
            btn_SwitchTable.UseVisualStyleBackColor = true;
            btn_SwitchTable.Click += btn_SwitchTable_Click;
            // 
            // nm_Discount
            // 
            nm_Discount.Location = new Point(117, 46);
            nm_Discount.Name = "nm_Discount";
            nm_Discount.Size = new Size(94, 27);
            nm_Discount.TabIndex = 4;
            nm_Discount.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_CheckOut
            // 
            btn_CheckOut.Location = new Point(349, 3);
            btn_CheckOut.Name = "btn_CheckOut";
            btn_CheckOut.Size = new Size(94, 71);
            btn_CheckOut.TabIndex = 4;
            btn_CheckOut.Text = "Thanh toán";
            btn_CheckOut.UseVisualStyleBackColor = true;
            btn_CheckOut.Click += btn_CheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nm_FoodCount);
            panel4.Controls.Add(btn_AddFood);
            panel4.Controls.Add(cbo_Food);
            panel4.Controls.Add(cbo_Category);
            panel4.Location = new Point(666, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 95);
            panel4.TabIndex = 4;
            // 
            // nm_FoodCount
            // 
            nm_FoodCount.Location = new Point(376, 35);
            nm_FoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nm_FoodCount.Name = "nm_FoodCount";
            nm_FoodCount.Size = new Size(57, 27);
            nm_FoodCount.TabIndex = 3;
            nm_FoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_AddFood
            // 
            btn_AddFood.Location = new Point(276, 12);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(94, 71);
            btn_AddFood.TabIndex = 2;
            btn_AddFood.Text = "Thêm món";
            btn_AddFood.UseVisualStyleBackColor = true;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // cbo_Food
            // 
            cbo_Food.FormattingEnabled = true;
            cbo_Food.Location = new Point(3, 55);
            cbo_Food.Name = "cbo_Food";
            cbo_Food.Size = new Size(267, 28);
            cbo_Food.TabIndex = 1;
            // 
            // cbo_Category
            // 
            cbo_Category.FormattingEnabled = true;
            cbo_Category.Location = new Point(3, 12);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(267, 28);
            cbo_Category.TabIndex = 0;
            cbo_Category.SelectedIndexChanged += cbo_Category_SelectedIndexChanged;
            // 
            // flp_Table
            // 
            flp_Table.AutoScroll = true;
            flp_Table.Location = new Point(33, 49);
            flp_Table.Name = "flp_Table";
            flp_Table.Size = new Size(600, 653);
            flp_Table.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1124, 714);
            Controls.Add(flp_Table);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán cafe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_Discount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nm_FoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView lsv_Bill;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nm_FoodCount;
        private Button btn_AddFood;
        private ComboBox cbo_Food;
        private ComboBox cbo_Category;
        private Button btn_CheckOut;
        private FlowLayoutPanel flp_Table;
        private Button btn_SwitchTable;
        private NumericUpDown nm_Discount;
        private ComboBox cbo_SwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private TextBox txt_TotalPrice;
        private Label label2;
    }
}