using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();

        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            Load();
        }
        #region methods
        void Load()
        {
            dgv_Food.DataSource = foodList;
            dgv_Account.DataSource = accountList;
            dgv_Category.DataSource = categoryList;
            dgv_Table.DataSource = tableList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtp_FromDate.Value, dtp_ToDate.Value, 1);
            LoadListFood();
            LoadListCategory();
            LoadTable();
            LoadAccount();
            LoadCategoryIntoCombobox(cbo_FoodCategory);

            AddFoodBinding();
            AddCategoryBinding();
            AddAccountBinding();
            AddTableBinding();
        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut, int pageNum)
        {
            dgv_Bill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(checkIn, checkOut, Convert.ToInt32(txt_PageBill.Text));
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtp_FromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtp_ToDate.Value = dtp_FromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void LoadTable()
        {
            tableList.DataSource = TableDAO.Instance.GetTable();
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddFoodBinding()
        {
            txt_FoodName.DataBindings.Add(new Binding("Text", dgv_Food.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txt_FoodID.DataBindings.Add(new Binding("Text", dgv_Food.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nm_FoodPrice.DataBindings.Add(new Binding("Value", dgv_Food.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryBinding()
        {
            txt_CategoryID.DataBindings.Add(new Binding("Text", dgv_Category.DataSource, "id", true, DataSourceUpdateMode.Never));
            txt_CategoryName.DataBindings.Add(new Binding("Text", dgv_Category.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void AddTableBinding()
        {
            txt_TableID.DataBindings.Add(new Binding("Text", dgv_Table.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txt_TableName.DataBindings.Add(new Binding("Text", dgv_Table.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txt_TableStatus.DataBindings.Add(new Binding("Text", dgv_Table.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txt_UserName.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txt_DisplayName.DataBindings.Add(new Binding("Text", dgv_Account.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nm_AccountType.DataBindings.Add(new Binding("Value", dgv_Account.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }
        void UpdateAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể xoá tài khoản đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        }
        void ResetPassword(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Reset mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reset mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region events
        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtp_FromDate.Value, dtp_ToDate.Value, 1);
        }
        private void btn_ShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void txt_FoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Food.SelectedCells.Count > 0)
                {
                    int id = (int)dgv_Food.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cbo_FoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbo_FoodCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbo_FoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }
        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            string name = txt_FoodName.Text;
            int categoryID = (cbo_FoodCategory.SelectedItem as Category).ID;
            float price = (float)nm_FoodPrice.Value;
            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm món không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_EditFood_Click(object sender, EventArgs e)
        {
            string name = txt_FoodName.Text;
            int categoryID = (cbo_FoodCategory.SelectedItem as Category).ID;
            float price = (float)nm_FoodPrice.Value;
            int id = Convert.ToInt32(txt_FoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Cập nhật món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Cập nhật món không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_DeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_FoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xoá món không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_SearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txt_SearchFoodName.Text);
        }
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string displayName = txt_DisplayName.Text;
            int type = (int)nm_AccountType.Value;

            AddAccount(userName, displayName, type);
        }
        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;

            DeleteAccount(userName);
        }
        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string displayName = txt_DisplayName.Text;
            int type = (int)nm_AccountType.Value;

            UpdateAccount(userName, displayName, type);
        }
        private void btn_ShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;

            ResetPassword(userName);
        }
        private void btn_FirstBillPage_Click(object sender, EventArgs e)
        {
            txt_PageBill.Text = "1";
            dgv_Bill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(dtp_FromDate.Value, dtp_ToDate.Value, Convert.ToInt32(txt_PageBill.Text));
        }
        private void btn_LastBillPage_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtp_FromDate.Value, dtp_ToDate.Value);
            int lastPage = sumRecord / 20;
            if (sumRecord % 20 != 0) lastPage++;
            txt_PageBill.Text = lastPage.ToString();
        }
        private void txt_PageBill_TextChanged(object sender, EventArgs e)
        {
            dgv_Bill.DataSource = BillDAO.Instance.GetListBillByDateAndPage(dtp_FromDate.Value, dtp_ToDate.Value, Convert.ToInt32(txt_PageBill.Text));
        }
        private void btn_PrevioursBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txt_PageBill.Text);
            if (page > 1) page--;
            txt_PageBill.Text = page.ToString();
        }
        private void btn_NextBillPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txt_PageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillByDate(dtp_FromDate.Value, dtp_ToDate.Value);
            int lastPage = sumRecord / 20;

            if (sumRecord % 20 != 0) lastPage++;
            if (page < lastPage)
            {
                if (page < sumRecord) page++;
                txt_PageBill.Text = page.ToString();
            }
        }
        private void btn_ShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }
        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            string name = txt_CategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm danh mục không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_CategoryID.Text);
            if (FoodDAO.Instance.DeleteFoodByCategory(id))
            {
                if (CategoryDAO.Instance.DeleteCategory(id))
                {
                    MessageBox.Show("Xoá danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListCategory();
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Xoá danh mục không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CategoryDAO.Instance.DeleteCategory(id))
                {
                    MessageBox.Show("Xoá danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListCategory();
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Xoá danh mục không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_EditCategory_Click(object sender, EventArgs e)
        {
            string name = txt_CategoryName.Text;
            int id = Convert.ToInt32(txt_CategoryID.Text);
            if (CategoryDAO.Instance.UpdateCategory(name, id))
            {
                MessageBox.Show("Sửa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa danh mục không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ShowTable_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            string name = txt_TableName.Text;
            string status = txt_TableStatus.Text;

            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_TableID.Text);

            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xoá bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                if (deleteTable != null)
                    deleteTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Xoá bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_EditTable_Click(object sender, EventArgs e)
        {
            string name = txt_TableName.Text;
            string status = txt_TableStatus.Text;
            int id = Convert.ToInt32(txt_TableID.Text);

            if (TableDAO.Instance.UpdateTable(name, status, id))
            {
                MessageBox.Show("Sửa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa bàn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // food
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        // category
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        // table
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }
        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }
        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }
    }
}
