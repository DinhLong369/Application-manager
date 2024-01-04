using QuanLyQuanLauNuong.DAO;
using QuanLyQuanLauNuong.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanLauNuong
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource AccountList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            //Load doanh thu
            LoadDateTimePicker();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

            //Load thức ăn
            dtgvFood.DataSource = foodList;
            LoadListFood();
            LoadCategoryInComboBox(cbFoodCategory);
            FoodBinding();

            //Load danh mục
            dtgvCategory.DataSource = categoryList;
            LoadListCategory();
            CategoryBinding();

            //Load bàn ăn
            dtgvTable.DataSource = tableList;
            LoadTableList();
            TableBinding();

            //Load Tài khoản
            dtgvAccount.DataSource = AccountList;
            LoadAccount();
            BindingAccount();
        }
       
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetListBillByDate(checkIn, checkOut);
        }


        // -------------------------------- Bảng thức ăn ---------------------------------
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        List<Food> SeachFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }
        void FoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "name", true , DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryInComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "name";
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbFoodCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbFoodCategory.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbFoodCategory.SelectedIndex = index;
                }
            }
            catch
            {
                
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id,name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xoá món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá thức ăn");
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SeachFoodByName(txbSearchFoodName.Text);
        }

        /* ------------------------------ Bảng danh mục ------------------------------- */
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void CategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id" , true , DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(name, id))
            {
                MessageBox.Show("Sửa danh mục thành công");
                LoadListCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục");
            }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }


        /*--------------------------------- Bàn ăn -------------------------------------------*/
        void LoadTableList()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }

        void TableBinding()
        {
            txbTableID.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "id", true , DataSourceUpdateMode.Never));
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            if (TableDAO.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTableList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xoá bàn thành công");
                LoadTableList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá bàn");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableID.Text);
            string name = txbTableName.Text;
            if (TableDAO.Instance.UpdateTable(name,id))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadTableList();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn");
            }
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTableList();
        }

        /*------------------------ tài khoản ----------------------*/
        void LoadAccount()
        {
            AccountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void BindingAccount()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "ShowName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
            txbPassAcc.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "PassWord", true, DataSourceUpdateMode.Never));
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string showName = txbDisplayName.Text;
            int type = (int)numericUpDown1.Value;
            string password = txbPassAcc.Text;
            if (AccountDAO.Instance.InsertAccount(username , showName, type,password))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xoá tài khoản thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xoá tài khoản");
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string showName = txbDisplayName.Text;
            int type = (int)numericUpDown1.Value;
            string password = txbPassAcc.Text;
            if (AccountDAO.Instance.UpdateAccount(username, showName, type, password))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản");
            }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

     
    }
}
