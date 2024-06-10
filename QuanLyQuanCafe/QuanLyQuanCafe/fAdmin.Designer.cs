namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tp_Account = new TabPage();
            panel12 = new Panel();
            btn_ShowAccount = new Button();
            btn_EditAccount = new Button();
            btn_DeleteAccount = new Button();
            btn_AddAccount = new Button();
            panel14 = new Panel();
            dgv_Account = new DataGridView();
            panel15 = new Panel();
            btn_ResetPassword = new Button();
            panel25 = new Panel();
            nm_AccountType = new NumericUpDown();
            label5 = new Label();
            panel26 = new Panel();
            txt_DisplayName = new TextBox();
            label6 = new Label();
            panel27 = new Panel();
            txt_UserName = new TextBox();
            label12 = new Label();
            tp_Table = new TabPage();
            panel19 = new Panel();
            btn_ShowTable = new Button();
            btn_EditTable = new Button();
            btn_DeleteTable = new Button();
            btn_AddTable = new Button();
            panel20 = new Panel();
            dgv_Table = new DataGridView();
            panel21 = new Panel();
            panel24 = new Panel();
            txt_TableStatus = new TextBox();
            label11 = new Label();
            panel22 = new Panel();
            txt_TableName = new TextBox();
            label9 = new Label();
            panel23 = new Panel();
            txt_TableID = new TextBox();
            label10 = new Label();
            tp_FoodCategory = new TabPage();
            panel11 = new Panel();
            btn_ShowCategory = new Button();
            btn_EditCategory = new Button();
            btn_DeleteCategory = new Button();
            btn_AddCategory = new Button();
            panel18 = new Panel();
            dgv_Category = new DataGridView();
            panel13 = new Panel();
            panel16 = new Panel();
            txt_CategoryName = new TextBox();
            label7 = new Label();
            panel17 = new Panel();
            txt_CategoryID = new TextBox();
            label8 = new Label();
            tp_Food = new TabPage();
            panel6 = new Panel();
            txt_SearchFoodName = new TextBox();
            btn_SearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nm_FoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbo_FoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txt_FoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txt_FoodID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            dgv_Food = new DataGridView();
            panel3 = new Panel();
            btn_ShowFood = new Button();
            btn_EditFood = new Button();
            btn_DeleteFood = new Button();
            btn_AddFood = new Button();
            tp_Bill = new TabPage();
            panel2 = new Panel();
            btn_ViewBill = new Button();
            dtp_ToDate = new DateTimePicker();
            dtp_FromDate = new DateTimePicker();
            panel1 = new Panel();
            txt_PageBill = new TextBox();
            btn_NextBillPage = new Button();
            btn_PrevioursBillPage = new Button();
            btn_LastBillPage = new Button();
            btn_FirstBillPage = new Button();
            dgv_Bill = new DataGridView();
            tc_Admin = new TabControl();
            tp_Account.SuspendLayout();
            panel12.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Account).BeginInit();
            panel15.SuspendLayout();
            panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_AccountType).BeginInit();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            tp_Table.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Table).BeginInit();
            panel21.SuspendLayout();
            panel24.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            tp_FoodCategory.SuspendLayout();
            panel11.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Category).BeginInit();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            tp_Food.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Food).BeginInit();
            panel3.SuspendLayout();
            tp_Bill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).BeginInit();
            tc_Admin.SuspendLayout();
            SuspendLayout();
            // 
            // tp_Account
            // 
            tp_Account.Controls.Add(panel12);
            tp_Account.Controls.Add(panel14);
            tp_Account.Controls.Add(panel15);
            tp_Account.Location = new Point(4, 29);
            tp_Account.Name = "tp_Account";
            tp_Account.Padding = new Padding(3);
            tp_Account.Size = new Size(993, 648);
            tp_Account.TabIndex = 4;
            tp_Account.Text = "Tài khoản";
            tp_Account.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(btn_ShowAccount);
            panel12.Controls.Add(btn_EditAccount);
            panel12.Controls.Add(btn_DeleteAccount);
            panel12.Controls.Add(btn_AddAccount);
            panel12.Location = new Point(3, 5);
            panel12.Name = "panel12";
            panel12.Size = new Size(539, 85);
            panel12.TabIndex = 13;
            // 
            // btn_ShowAccount
            // 
            btn_ShowAccount.Location = new Point(435, 3);
            btn_ShowAccount.Name = "btn_ShowAccount";
            btn_ShowAccount.Size = new Size(101, 79);
            btn_ShowAccount.TabIndex = 3;
            btn_ShowAccount.Text = "Xem";
            btn_ShowAccount.UseVisualStyleBackColor = true;
            btn_ShowAccount.Click += btn_ShowAccount_Click;
            // 
            // btn_EditAccount
            // 
            btn_EditAccount.Location = new Point(292, 3);
            btn_EditAccount.Name = "btn_EditAccount";
            btn_EditAccount.Size = new Size(101, 79);
            btn_EditAccount.TabIndex = 2;
            btn_EditAccount.Text = "Sửa";
            btn_EditAccount.UseVisualStyleBackColor = true;
            btn_EditAccount.Click += btn_EditAccount_Click;
            // 
            // btn_DeleteAccount
            // 
            btn_DeleteAccount.Location = new Point(146, 3);
            btn_DeleteAccount.Name = "btn_DeleteAccount";
            btn_DeleteAccount.Size = new Size(101, 79);
            btn_DeleteAccount.TabIndex = 1;
            btn_DeleteAccount.Text = "Xoá";
            btn_DeleteAccount.UseVisualStyleBackColor = true;
            btn_DeleteAccount.Click += btn_DeleteAccount_Click;
            // 
            // btn_AddAccount
            // 
            btn_AddAccount.Location = new Point(3, 3);
            btn_AddAccount.Name = "btn_AddAccount";
            btn_AddAccount.Size = new Size(101, 79);
            btn_AddAccount.TabIndex = 0;
            btn_AddAccount.Text = "Thêm";
            btn_AddAccount.UseVisualStyleBackColor = true;
            btn_AddAccount.Click += btn_AddAccount_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(dgv_Account);
            panel14.Location = new Point(3, 93);
            panel14.Name = "panel14";
            panel14.Size = new Size(539, 551);
            panel14.TabIndex = 12;
            // 
            // dgv_Account
            // 
            dgv_Account.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Account.Location = new Point(3, 3);
            dgv_Account.Name = "dgv_Account";
            dgv_Account.RowHeadersWidth = 51;
            dgv_Account.RowTemplate.Height = 29;
            dgv_Account.Size = new Size(533, 545);
            dgv_Account.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.Controls.Add(btn_ResetPassword);
            panel15.Controls.Add(panel25);
            panel15.Controls.Add(panel26);
            panel15.Controls.Add(panel27);
            panel15.Location = new Point(545, 93);
            panel15.Name = "panel15";
            panel15.Size = new Size(445, 551);
            panel15.TabIndex = 11;
            // 
            // btn_ResetPassword
            // 
            btn_ResetPassword.Location = new Point(300, 196);
            btn_ResetPassword.Name = "btn_ResetPassword";
            btn_ResetPassword.Size = new Size(145, 66);
            btn_ResetPassword.TabIndex = 4;
            btn_ResetPassword.Text = "Reset mật khẩu";
            btn_ResetPassword.UseVisualStyleBackColor = true;
            btn_ResetPassword.Click += btn_ResetPassword_Click;
            // 
            // panel25
            // 
            panel25.Controls.Add(nm_AccountType);
            panel25.Controls.Add(label5);
            panel25.Location = new Point(3, 124);
            panel25.Name = "panel25";
            panel25.Size = new Size(439, 53);
            panel25.TabIndex = 3;
            // 
            // nm_AccountType
            // 
            nm_AccountType.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            nm_AccountType.Location = new Point(135, 17);
            nm_AccountType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nm_AccountType.Name = "nm_AccountType";
            nm_AccountType.Size = new Size(92, 27);
            nm_AccountType.TabIndex = 1;
            nm_AccountType.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 20);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 0;
            label5.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txt_DisplayName);
            panel26.Controls.Add(label6);
            panel26.Location = new Point(3, 65);
            panel26.Name = "panel26";
            panel26.Size = new Size(439, 53);
            panel26.TabIndex = 2;
            // 
            // txt_DisplayName
            // 
            txt_DisplayName.Location = new Point(135, 12);
            txt_DisplayName.Name = "txt_DisplayName";
            txt_DisplayName.Size = new Size(292, 27);
            txt_DisplayName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 20);
            label6.Name = "label6";
            label6.Size = new Size(107, 19);
            label6.TabIndex = 0;
            label6.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            panel27.Controls.Add(txt_UserName);
            panel27.Controls.Add(label12);
            panel27.Location = new Point(3, 6);
            panel27.Name = "panel27";
            panel27.Size = new Size(439, 53);
            panel27.TabIndex = 1;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(135, 12);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(292, 27);
            txt_UserName.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 16);
            label12.Name = "label12";
            label12.Size = new Size(121, 19);
            label12.TabIndex = 0;
            label12.Text = "Tên tài khoản:";
            // 
            // tp_Table
            // 
            tp_Table.Controls.Add(panel19);
            tp_Table.Controls.Add(panel20);
            tp_Table.Controls.Add(panel21);
            tp_Table.Location = new Point(4, 29);
            tp_Table.Name = "tp_Table";
            tp_Table.Padding = new Padding(3);
            tp_Table.Size = new Size(993, 648);
            tp_Table.TabIndex = 3;
            tp_Table.Text = "Bàn";
            tp_Table.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            panel19.Controls.Add(btn_ShowTable);
            panel19.Controls.Add(btn_EditTable);
            panel19.Controls.Add(btn_DeleteTable);
            panel19.Controls.Add(btn_AddTable);
            panel19.Location = new Point(3, 5);
            panel19.Name = "panel19";
            panel19.Size = new Size(539, 85);
            panel19.TabIndex = 10;
            // 
            // btn_ShowTable
            // 
            btn_ShowTable.Location = new Point(435, 3);
            btn_ShowTable.Name = "btn_ShowTable";
            btn_ShowTable.Size = new Size(101, 79);
            btn_ShowTable.TabIndex = 3;
            btn_ShowTable.Text = "Xem";
            btn_ShowTable.UseVisualStyleBackColor = true;
            btn_ShowTable.Click += btn_ShowTable_Click;
            // 
            // btn_EditTable
            // 
            btn_EditTable.Location = new Point(292, 3);
            btn_EditTable.Name = "btn_EditTable";
            btn_EditTable.Size = new Size(101, 79);
            btn_EditTable.TabIndex = 2;
            btn_EditTable.Text = "Sửa";
            btn_EditTable.UseVisualStyleBackColor = true;
            btn_EditTable.Click += btn_EditTable_Click;
            // 
            // btn_DeleteTable
            // 
            btn_DeleteTable.Location = new Point(146, 3);
            btn_DeleteTable.Name = "btn_DeleteTable";
            btn_DeleteTable.Size = new Size(101, 79);
            btn_DeleteTable.TabIndex = 1;
            btn_DeleteTable.Text = "Xoá";
            btn_DeleteTable.UseVisualStyleBackColor = true;
            btn_DeleteTable.Click += btn_DeleteTable_Click;
            // 
            // btn_AddTable
            // 
            btn_AddTable.Location = new Point(3, 3);
            btn_AddTable.Name = "btn_AddTable";
            btn_AddTable.Size = new Size(101, 79);
            btn_AddTable.TabIndex = 0;
            btn_AddTable.Text = "Thêm";
            btn_AddTable.UseVisualStyleBackColor = true;
            btn_AddTable.Click += btn_AddTable_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(dgv_Table);
            panel20.Location = new Point(3, 93);
            panel20.Name = "panel20";
            panel20.Size = new Size(539, 551);
            panel20.TabIndex = 9;
            // 
            // dgv_Table
            // 
            dgv_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Table.Location = new Point(3, 3);
            dgv_Table.Name = "dgv_Table";
            dgv_Table.RowHeadersWidth = 51;
            dgv_Table.RowTemplate.Height = 29;
            dgv_Table.Size = new Size(533, 545);
            dgv_Table.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.Controls.Add(panel24);
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(panel23);
            panel21.Location = new Point(545, 93);
            panel21.Name = "panel21";
            panel21.Size = new Size(445, 551);
            panel21.TabIndex = 8;
            // 
            // panel24
            // 
            panel24.Controls.Add(txt_TableStatus);
            panel24.Controls.Add(label11);
            panel24.Location = new Point(3, 124);
            panel24.Name = "panel24";
            panel24.Size = new Size(439, 53);
            panel24.TabIndex = 3;
            // 
            // txt_TableStatus
            // 
            txt_TableStatus.Location = new Point(135, 16);
            txt_TableStatus.Name = "txt_TableStatus";
            txt_TableStatus.Size = new Size(292, 27);
            txt_TableStatus.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 20);
            label11.Name = "label11";
            label11.Size = new Size(94, 19);
            label11.TabIndex = 0;
            label11.Text = "Trạng thái:";
            // 
            // panel22
            // 
            panel22.Controls.Add(txt_TableName);
            panel22.Controls.Add(label9);
            panel22.Location = new Point(3, 65);
            panel22.Name = "panel22";
            panel22.Size = new Size(439, 53);
            panel22.TabIndex = 2;
            // 
            // txt_TableName
            // 
            txt_TableName.Location = new Point(135, 12);
            txt_TableName.Name = "txt_TableName";
            txt_TableName.Size = new Size(292, 27);
            txt_TableName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 20);
            label9.Name = "label9";
            label9.Size = new Size(78, 19);
            label9.TabIndex = 0;
            label9.Text = "Tên bàn:";
            // 
            // panel23
            // 
            panel23.Controls.Add(txt_TableID);
            panel23.Controls.Add(label10);
            panel23.Location = new Point(3, 6);
            panel23.Name = "panel23";
            panel23.Size = new Size(439, 53);
            panel23.TabIndex = 1;
            // 
            // txt_TableID
            // 
            txt_TableID.Location = new Point(135, 12);
            txt_TableID.Name = "txt_TableID";
            txt_TableID.ReadOnly = true;
            txt_TableID.Size = new Size(292, 27);
            txt_TableID.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 16);
            label10.Name = "label10";
            label10.Size = new Size(31, 19);
            label10.TabIndex = 0;
            label10.Text = "ID:";
            // 
            // tp_FoodCategory
            // 
            tp_FoodCategory.Controls.Add(panel11);
            tp_FoodCategory.Controls.Add(panel18);
            tp_FoodCategory.Controls.Add(panel13);
            tp_FoodCategory.Location = new Point(4, 29);
            tp_FoodCategory.Name = "tp_FoodCategory";
            tp_FoodCategory.Padding = new Padding(3);
            tp_FoodCategory.Size = new Size(993, 648);
            tp_FoodCategory.TabIndex = 2;
            tp_FoodCategory.Text = "Danh mục";
            tp_FoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(btn_ShowCategory);
            panel11.Controls.Add(btn_EditCategory);
            panel11.Controls.Add(btn_DeleteCategory);
            panel11.Controls.Add(btn_AddCategory);
            panel11.Location = new Point(3, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(539, 85);
            panel11.TabIndex = 7;
            // 
            // btn_ShowCategory
            // 
            btn_ShowCategory.Location = new Point(435, 3);
            btn_ShowCategory.Name = "btn_ShowCategory";
            btn_ShowCategory.Size = new Size(101, 79);
            btn_ShowCategory.TabIndex = 3;
            btn_ShowCategory.Text = "Xem";
            btn_ShowCategory.UseVisualStyleBackColor = true;
            btn_ShowCategory.Click += btn_ShowCategory_Click;
            // 
            // btn_EditCategory
            // 
            btn_EditCategory.Location = new Point(292, 3);
            btn_EditCategory.Name = "btn_EditCategory";
            btn_EditCategory.Size = new Size(101, 79);
            btn_EditCategory.TabIndex = 2;
            btn_EditCategory.Text = "Sửa";
            btn_EditCategory.UseVisualStyleBackColor = true;
            btn_EditCategory.Click += btn_EditCategory_Click;
            // 
            // btn_DeleteCategory
            // 
            btn_DeleteCategory.Location = new Point(146, 3);
            btn_DeleteCategory.Name = "btn_DeleteCategory";
            btn_DeleteCategory.Size = new Size(101, 79);
            btn_DeleteCategory.TabIndex = 1;
            btn_DeleteCategory.Text = "Xoá";
            btn_DeleteCategory.UseVisualStyleBackColor = true;
            btn_DeleteCategory.Click += btn_DeleteCategory_Click;
            // 
            // btn_AddCategory
            // 
            btn_AddCategory.Location = new Point(3, 3);
            btn_AddCategory.Name = "btn_AddCategory";
            btn_AddCategory.Size = new Size(101, 79);
            btn_AddCategory.TabIndex = 0;
            btn_AddCategory.Text = "Thêm";
            btn_AddCategory.UseVisualStyleBackColor = true;
            btn_AddCategory.Click += btn_AddCategory_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(dgv_Category);
            panel18.Location = new Point(3, 91);
            panel18.Name = "panel18";
            panel18.Size = new Size(539, 551);
            panel18.TabIndex = 6;
            // 
            // dgv_Category
            // 
            dgv_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Category.Location = new Point(3, 3);
            dgv_Category.Name = "dgv_Category";
            dgv_Category.RowHeadersWidth = 51;
            dgv_Category.RowTemplate.Height = 29;
            dgv_Category.Size = new Size(533, 545);
            dgv_Category.TabIndex = 0;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(545, 91);
            panel13.Name = "panel13";
            panel13.Size = new Size(445, 551);
            panel13.TabIndex = 5;
            // 
            // panel16
            // 
            panel16.Controls.Add(txt_CategoryName);
            panel16.Controls.Add(label7);
            panel16.Location = new Point(3, 65);
            panel16.Name = "panel16";
            panel16.Size = new Size(439, 53);
            panel16.TabIndex = 2;
            // 
            // txt_CategoryName
            // 
            txt_CategoryName.Location = new Point(135, 12);
            txt_CategoryName.Name = "txt_CategoryName";
            txt_CategoryName.Size = new Size(292, 27);
            txt_CategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 20);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel17
            // 
            panel17.Controls.Add(txt_CategoryID);
            panel17.Controls.Add(label8);
            panel17.Location = new Point(3, 6);
            panel17.Name = "panel17";
            panel17.Size = new Size(439, 53);
            panel17.TabIndex = 1;
            // 
            // txt_CategoryID
            // 
            txt_CategoryID.Location = new Point(135, 12);
            txt_CategoryID.Name = "txt_CategoryID";
            txt_CategoryID.ReadOnly = true;
            txt_CategoryID.Size = new Size(292, 27);
            txt_CategoryID.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 16);
            label8.Name = "label8";
            label8.Size = new Size(31, 19);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // tp_Food
            // 
            tp_Food.Controls.Add(panel6);
            tp_Food.Controls.Add(panel5);
            tp_Food.Controls.Add(panel4);
            tp_Food.Controls.Add(panel3);
            tp_Food.Location = new Point(4, 29);
            tp_Food.Name = "tp_Food";
            tp_Food.Padding = new Padding(3);
            tp_Food.Size = new Size(993, 648);
            tp_Food.TabIndex = 1;
            tp_Food.Text = "Thức ăn";
            tp_Food.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txt_SearchFoodName);
            panel6.Controls.Add(btn_SearchFood);
            panel6.Location = new Point(551, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(436, 85);
            panel6.TabIndex = 3;
            // 
            // txt_SearchFoodName
            // 
            txt_SearchFoodName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SearchFoodName.Location = new Point(3, 26);
            txt_SearchFoodName.Name = "txt_SearchFoodName";
            txt_SearchFoodName.Size = new Size(323, 34);
            txt_SearchFoodName.TabIndex = 5;
            // 
            // btn_SearchFood
            // 
            btn_SearchFood.Location = new Point(332, 0);
            btn_SearchFood.Name = "btn_SearchFood";
            btn_SearchFood.Size = new Size(101, 79);
            btn_SearchFood.TabIndex = 4;
            btn_SearchFood.Text = "Tìm";
            btn_SearchFood.UseVisualStyleBackColor = true;
            btn_SearchFood.Click += btn_SearchFood_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(551, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(436, 551);
            panel5.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nm_FoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 183);
            panel10.Name = "panel10";
            panel10.Size = new Size(430, 53);
            panel10.TabIndex = 4;
            // 
            // nm_FoodPrice
            // 
            nm_FoodPrice.Location = new Point(100, 13);
            nm_FoodPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nm_FoodPrice.Name = "nm_FoodPrice";
            nm_FoodPrice.Size = new Size(327, 27);
            nm_FoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbo_FoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 124);
            panel9.Name = "panel9";
            panel9.Size = new Size(430, 53);
            panel9.TabIndex = 3;
            // 
            // cbo_FoodCategory
            // 
            cbo_FoodCategory.FormattingEnabled = true;
            cbo_FoodCategory.Location = new Point(100, 12);
            cbo_FoodCategory.Name = "cbo_FoodCategory";
            cbo_FoodCategory.Size = new Size(330, 28);
            cbo_FoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 16);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 0;
            label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txt_FoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 65);
            panel8.Name = "panel8";
            panel8.Size = new Size(430, 53);
            panel8.TabIndex = 2;
            // 
            // txt_FoodName
            // 
            txt_FoodName.Location = new Point(100, 12);
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.Size = new Size(327, 27);
            txt_FoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txt_FoodID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(430, 53);
            panel7.TabIndex = 1;
            // 
            // txt_FoodID
            // 
            txt_FoodID.Location = new Point(100, 12);
            txt_FoodID.Name = "txt_FoodID";
            txt_FoodID.ReadOnly = true;
            txt_FoodID.Size = new Size(327, 27);
            txt_FoodID.TabIndex = 1;
            txt_FoodID.TextChanged += txt_FoodID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgv_Food);
            panel4.Location = new Point(6, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(539, 551);
            panel4.TabIndex = 1;
            // 
            // dgv_Food
            // 
            dgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Food.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Food.Location = new Point(3, 3);
            dgv_Food.Name = "dgv_Food";
            dgv_Food.RowHeadersWidth = 51;
            dgv_Food.RowTemplate.Height = 29;
            dgv_Food.Size = new Size(533, 545);
            dgv_Food.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_ShowFood);
            panel3.Controls.Add(btn_EditFood);
            panel3.Controls.Add(btn_DeleteFood);
            panel3.Controls.Add(btn_AddFood);
            panel3.Location = new Point(6, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 85);
            panel3.TabIndex = 0;
            // 
            // btn_ShowFood
            // 
            btn_ShowFood.Location = new Point(435, 3);
            btn_ShowFood.Name = "btn_ShowFood";
            btn_ShowFood.Size = new Size(101, 79);
            btn_ShowFood.TabIndex = 3;
            btn_ShowFood.Text = "Xem";
            btn_ShowFood.UseVisualStyleBackColor = true;
            btn_ShowFood.Click += btn_ShowFood_Click;
            // 
            // btn_EditFood
            // 
            btn_EditFood.Location = new Point(292, 3);
            btn_EditFood.Name = "btn_EditFood";
            btn_EditFood.Size = new Size(101, 79);
            btn_EditFood.TabIndex = 2;
            btn_EditFood.Text = "Sửa";
            btn_EditFood.UseVisualStyleBackColor = true;
            btn_EditFood.Click += btn_EditFood_Click;
            // 
            // btn_DeleteFood
            // 
            btn_DeleteFood.Location = new Point(146, 3);
            btn_DeleteFood.Name = "btn_DeleteFood";
            btn_DeleteFood.Size = new Size(101, 79);
            btn_DeleteFood.TabIndex = 1;
            btn_DeleteFood.Text = "Xoá";
            btn_DeleteFood.UseVisualStyleBackColor = true;
            btn_DeleteFood.Click += btn_DeleteFood_Click;
            // 
            // btn_AddFood
            // 
            btn_AddFood.Location = new Point(3, 3);
            btn_AddFood.Name = "btn_AddFood";
            btn_AddFood.Size = new Size(101, 79);
            btn_AddFood.TabIndex = 0;
            btn_AddFood.Text = "Thêm";
            btn_AddFood.UseVisualStyleBackColor = true;
            btn_AddFood.Click += btn_AddFood_Click;
            // 
            // tp_Bill
            // 
            tp_Bill.Controls.Add(panel2);
            tp_Bill.Controls.Add(panel1);
            tp_Bill.Location = new Point(4, 29);
            tp_Bill.Name = "tp_Bill";
            tp_Bill.Padding = new Padding(3);
            tp_Bill.Size = new Size(993, 648);
            tp_Bill.TabIndex = 0;
            tp_Bill.Text = "Doanh thu";
            tp_Bill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_ViewBill);
            panel2.Controls.Add(dtp_ToDate);
            panel2.Controls.Add(dtp_FromDate);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 36);
            panel2.TabIndex = 1;
            // 
            // btn_ViewBill
            // 
            btn_ViewBill.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViewBill.Location = new Point(432, 3);
            btn_ViewBill.Name = "btn_ViewBill";
            btn_ViewBill.Size = new Size(127, 30);
            btn_ViewBill.TabIndex = 2;
            btn_ViewBill.Text = "Thống kê";
            btn_ViewBill.UseVisualStyleBackColor = true;
            btn_ViewBill.Click += btn_ViewBill_Click;
            // 
            // dtp_ToDate
            // 
            dtp_ToDate.Location = new Point(685, 3);
            dtp_ToDate.Name = "dtp_ToDate";
            dtp_ToDate.Size = new Size(293, 27);
            dtp_ToDate.TabIndex = 1;
            // 
            // dtp_FromDate
            // 
            dtp_FromDate.Location = new Point(3, 3);
            dtp_FromDate.Name = "dtp_FromDate";
            dtp_FromDate.Size = new Size(304, 27);
            dtp_FromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_PageBill);
            panel1.Controls.Add(btn_NextBillPage);
            panel1.Controls.Add(btn_PrevioursBillPage);
            panel1.Controls.Add(btn_LastBillPage);
            panel1.Controls.Add(btn_FirstBillPage);
            panel1.Controls.Add(dgv_Bill);
            panel1.Location = new Point(6, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 594);
            panel1.TabIndex = 0;
            // 
            // txt_PageBill
            // 
            txt_PageBill.Location = new Point(473, 560);
            txt_PageBill.Name = "txt_PageBill";
            txt_PageBill.ReadOnly = true;
            txt_PageBill.Size = new Size(46, 27);
            txt_PageBill.TabIndex = 7;
            txt_PageBill.Text = "1";
            txt_PageBill.TextAlign = HorizontalAlignment.Center;
            txt_PageBill.TextChanged += txt_PageBill_TextChanged;
            // 
            // btn_NextBillPage
            // 
            btn_NextBillPage.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_NextBillPage.Location = new Point(525, 558);
            btn_NextBillPage.Name = "btn_NextBillPage";
            btn_NextBillPage.Size = new Size(41, 30);
            btn_NextBillPage.TabIndex = 6;
            btn_NextBillPage.Text = ">";
            btn_NextBillPage.UseVisualStyleBackColor = true;
            btn_NextBillPage.Click += btn_NextBillPage_Click;
            // 
            // btn_PrevioursBillPage
            // 
            btn_PrevioursBillPage.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_PrevioursBillPage.Location = new Point(423, 558);
            btn_PrevioursBillPage.Name = "btn_PrevioursBillPage";
            btn_PrevioursBillPage.Size = new Size(41, 30);
            btn_PrevioursBillPage.TabIndex = 5;
            btn_PrevioursBillPage.Text = "<";
            btn_PrevioursBillPage.UseVisualStyleBackColor = true;
            btn_PrevioursBillPage.Click += btn_PrevioursBillPage_Click;
            // 
            // btn_LastBillPage
            // 
            btn_LastBillPage.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_LastBillPage.Location = new Point(572, 558);
            btn_LastBillPage.Name = "btn_LastBillPage";
            btn_LastBillPage.Size = new Size(127, 30);
            btn_LastBillPage.TabIndex = 4;
            btn_LastBillPage.Text = "Last";
            btn_LastBillPage.UseVisualStyleBackColor = true;
            btn_LastBillPage.Click += btn_LastBillPage_Click;
            // 
            // btn_FirstBillPage
            // 
            btn_FirstBillPage.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_FirstBillPage.Location = new Point(290, 558);
            btn_FirstBillPage.Name = "btn_FirstBillPage";
            btn_FirstBillPage.Size = new Size(127, 30);
            btn_FirstBillPage.TabIndex = 3;
            btn_FirstBillPage.Text = "First";
            btn_FirstBillPage.UseVisualStyleBackColor = true;
            btn_FirstBillPage.Click += btn_FirstBillPage_Click;
            // 
            // dgv_Bill
            // 
            dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bill.Location = new Point(6, 6);
            dgv_Bill.Name = "dgv_Bill";
            dgv_Bill.RowHeadersWidth = 51;
            dgv_Bill.RowTemplate.Height = 29;
            dgv_Bill.Size = new Size(975, 545);
            dgv_Bill.TabIndex = 0;
            // 
            // tc_Admin
            // 
            tc_Admin.Controls.Add(tp_Bill);
            tc_Admin.Controls.Add(tp_Food);
            tc_Admin.Controls.Add(tp_FoodCategory);
            tc_Admin.Controls.Add(tp_Table);
            tc_Admin.Controls.Add(tp_Account);
            tc_Admin.Location = new Point(12, 12);
            tc_Admin.Name = "tc_Admin";
            tc_Admin.SelectedIndex = 0;
            tc_Admin.Size = new Size(1001, 681);
            tc_Admin.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 705);
            Controls.Add(tc_Admin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tp_Account.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Account).EndInit();
            panel15.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_AccountType).EndInit();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            tp_Table.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Table).EndInit();
            panel21.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            tp_FoodCategory.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Category).EndInit();
            panel13.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            tp_Food.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nm_FoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Food).EndInit();
            panel3.ResumeLayout(false);
            tp_Bill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).EndInit();
            tc_Admin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private TextBox textBox3;
        private Button button5;
        private TabPage tp_Account;
        private Panel panel12;
        private Button btn_ShowAccount;
        private Button btn_EditAccount;
        private Button btn_DeleteAccount;
        private Button btn_AddAccount;
        private Panel panel14;
        private DataGridView dgv_Account;
        private Panel panel15;
        private Button btn_ResetPassword;
        private Panel panel25;
        private NumericUpDown nm_AccountType;
        private Label label5;
        private Panel panel26;
        private TextBox txt_DisplayName;
        private Label label6;
        private Panel panel27;
        private TextBox txt_UserName;
        private Label label12;
        private TabPage tp_Table;
        private Panel panel19;
        private Button btn_ShowTable;
        private Button btn_EditTable;
        private Button btn_DeleteTable;
        private Button btn_AddTable;
        private Panel panel20;
        private DataGridView dgv_Table;
        private Panel panel21;
        private Panel panel24;
        private TextBox txt_TableStatus;
        private Label label11;
        private Panel panel22;
        private TextBox txt_TableName;
        private Label label9;
        private Panel panel23;
        private TextBox txt_TableID;
        private Label label10;
        private TabPage tp_FoodCategory;
        private Panel panel11;
        private Button btn_ShowCategory;
        private Button btn_EditCategory;
        private Button btn_DeleteCategory;
        private Button btn_AddCategory;
        private Panel panel18;
        private DataGridView dgv_Category;
        private Panel panel13;
        private Panel panel16;
        private TextBox txt_CategoryName;
        private Label label7;
        private Panel panel17;
        private TextBox txt_CategoryID;
        private Label label8;
        private TabPage tp_Food;
        private Panel panel6;
        private TextBox txt_SearchFoodName;
        private Button btn_SearchFood;
        private Panel panel5;
        private Panel panel10;
        private NumericUpDown nm_FoodPrice;
        private Label label4;
        private Panel panel9;
        private ComboBox cbo_FoodCategory;
        private Label label3;
        private Panel panel8;
        private TextBox txt_FoodName;
        private Label label2;
        private Panel panel7;
        private TextBox txt_FoodID;
        private Label label1;
        private Panel panel4;
        private DataGridView dgv_Food;
        private Panel panel3;
        private Button btn_ShowFood;
        private Button btn_EditFood;
        private Button btn_DeleteFood;
        private Button btn_AddFood;
        private TabPage tp_Bill;
        private Panel panel2;
        private Button btn_ViewBill;
        private DateTimePicker dtp_ToDate;
        private DateTimePicker dtp_FromDate;
        private Panel panel1;
        private TextBox txt_PageBill;
        private Button btn_NextBillPage;
        private Button btn_PrevioursBillPage;
        private Button btn_LastBillPage;
        private Button btn_FirstBillPage;
        private DataGridView dgv_Bill;
        private TabControl tc_Admin;
    }
}