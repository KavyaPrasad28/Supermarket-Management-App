using SuperMarketApp2.DataBase;
using SuperMarketApp2.Models;
using System;
using System.Windows.Forms;

namespace SuperMarketApp2.PresentationLayers
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
        }

        #region Fields
        private string productName = "";
        private int pid = 0;
        private float price = 0;
        private int stock = 0;
        #endregion

        /// <summary>
        /// Adds Category names from Category table to cbCategory
        /// </summary>
        private void CategoryBind()
        {
            Category category = new Category();
            var dr = category.GetCategory();
            while (dr.Read())
            {
                cbCategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        /// <summary>
        /// For binding Product table again after removing a product
        /// </summary>
        private void RefreshTable()
        {
            Product product = new Product();
            var data = product.ViewProductList();

            dgvAdmin.AutoGenerateColumns = false;

            dgvAdmin.Columns[0].Name = "Id";
            dgvAdmin.Columns[0].HeaderText = "Id";
            dgvAdmin.Columns[0].DataPropertyName = "Id";

            dgvAdmin.Columns[1].Name = "Name";
            dgvAdmin.Columns[1].HeaderText = "Product Name";
            dgvAdmin.Columns[1].DataPropertyName = "Name";

            dgvAdmin.Columns[2].Name = "Price";
            dgvAdmin.Columns[2].HeaderText = "Price";
            dgvAdmin.Columns[2].DataPropertyName = "Price";

            dgvAdmin.Columns[3].Name = "Stock";
            dgvAdmin.Columns[3].HeaderText = "Stock";
            dgvAdmin.Columns[3].DataPropertyName = "Stock";

            dgvAdmin.DataSource = data;
        }

        /// <summary>
        /// For binding Product table to dgvAdmin
        /// </summary>
        private void ProductTableBind()
        {
            Product product = new Product();
            var data = product.ViewProductList();

            dgvAdmin.AutoGenerateColumns = false;

            dgvAdmin.ColumnCount = 4;

            dgvAdmin.Columns[0].Name = "Id";
            dgvAdmin.Columns[0].HeaderText = "Id";
            dgvAdmin.Columns[0].DataPropertyName = "Id";

            dgvAdmin.Columns[1].Name = "Name";
            dgvAdmin.Columns[1].HeaderText = "Product Name";
            dgvAdmin.Columns[1].DataPropertyName = "Name";

            dgvAdmin.Columns[2].Name = "Price";
            dgvAdmin.Columns[2].HeaderText = "Price";
            dgvAdmin.Columns[2].DataPropertyName = "Price";

            dgvAdmin.Columns[3].Name = "Stock";
            dgvAdmin.Columns[3].HeaderText = "Stock";
            dgvAdmin.Columns[3].DataPropertyName = "Stock";

            dgvAdmin.DataSource = data;
        }

        /// <summary>
        /// For binding Product table according to it's Category
        /// </summary>
        private void CategorizedProductList()
        {
            Product product = new Product();

            if (cbCategory.SelectedItem.ToString() == "Stationery")
            {
                var data = product.ViewStationeryList();

                dgvAdmin.AutoGenerateColumns = false;

                dgvAdmin.Columns[0].Name = "Id";
                dgvAdmin.Columns[0].HeaderText = "Id";
                dgvAdmin.Columns[0].DataPropertyName = "Id";

                dgvAdmin.Columns[1].Name = "Name";
                dgvAdmin.Columns[1].HeaderText = "Product Name";
                dgvAdmin.Columns[1].DataPropertyName = "Name";

                dgvAdmin.Columns[2].Name = "Price";
                dgvAdmin.Columns[2].HeaderText = "Price";
                dgvAdmin.Columns[2].DataPropertyName = "Price";

                dgvAdmin.Columns[3].Name = "Stock";
                dgvAdmin.Columns[3].HeaderText = "Stock";
                dgvAdmin.Columns[3].DataPropertyName = "Stock";

                dgvAdmin.DataSource = data;
            }

            if (cbCategory.SelectedItem.ToString() == "Grocery")
            {
                var data = product.ViewGroceryList();

                dgvAdmin.AutoGenerateColumns = false;

                dgvAdmin.Columns[0].Name = "Id";
                dgvAdmin.Columns[0].HeaderText = "Id";
                dgvAdmin.Columns[0].DataPropertyName = "Id";

                dgvAdmin.Columns[1].Name = "Name";
                dgvAdmin.Columns[1].HeaderText = "Product Name";
                dgvAdmin.Columns[1].DataPropertyName = "Name";

                dgvAdmin.Columns[2].Name = "Price";
                dgvAdmin.Columns[2].HeaderText = "Price";
                dgvAdmin.Columns[2].DataPropertyName = "Price";

                dgvAdmin.Columns[3].Name = "Stock";
                dgvAdmin.Columns[3].HeaderText = "Stock";
                dgvAdmin.Columns[3].DataPropertyName = "Stock";

                dgvAdmin.DataSource = data;
            }

            if (cbCategory.SelectedItem.ToString() == "Fruit")
            {
                var data = product.ViewFruitList();

                dgvAdmin.AutoGenerateColumns = false;

                dgvAdmin.Columns[0].Name = "Id";
                dgvAdmin.Columns[0].HeaderText = "Id";
                dgvAdmin.Columns[0].DataPropertyName = "Id";

                dgvAdmin.Columns[1].Name = "Name";
                dgvAdmin.Columns[1].HeaderText = "Product Name";
                dgvAdmin.Columns[1].DataPropertyName = "Name";

                dgvAdmin.Columns[2].Name = "Price";
                dgvAdmin.Columns[2].HeaderText = "Price";
                dgvAdmin.Columns[2].DataPropertyName = "Price";

                dgvAdmin.Columns[3].Name = "Stock";
                dgvAdmin.Columns[3].HeaderText = "Stock";
                dgvAdmin.Columns[3].DataPropertyName = "Stock";

                dgvAdmin.DataSource = data;
            }

            if (cbCategory.SelectedItem.ToString() == "Vegetable")
            {
                var data = product.ViewVegetableList();

                dgvAdmin.AutoGenerateColumns = false;

                dgvAdmin.Columns[0].Name = "Id";
                dgvAdmin.Columns[0].HeaderText = "Id";
                dgvAdmin.Columns[0].DataPropertyName = "Id";

                dgvAdmin.Columns[1].Name = "Name";
                dgvAdmin.Columns[1].HeaderText = "Product Name";
                dgvAdmin.Columns[1].DataPropertyName = "Name";

                dgvAdmin.Columns[2].Name = "Price";
                dgvAdmin.Columns[2].HeaderText = "Price";
                dgvAdmin.Columns[2].DataPropertyName = "Price";

                dgvAdmin.Columns[3].Name = "Stock";
                dgvAdmin.Columns[3].HeaderText = "Stock";
                dgvAdmin.Columns[3].DataPropertyName = "Stock";

                dgvAdmin.DataSource = data;
            }
        }

        #region Events
        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                CategoryBind();
                ProductTableBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            CategorizedProductList();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            new PurchaseForm().ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new SalesPage().ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Select Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int flag = 0;
                    Product product = new Product();
                    var dr = product.ReadProductNames();
                    while (dr.Read())
                    {
                        if (txtProductName.Text.ToLower() == dr[0].ToString().ToLower())
                        {
                            MessageBox.Show($"A product named {txtProductName.Text} already exists!", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            flag = 1;
                        }
                    }
                    dr.Close();

                    if (flag == 0)
                    {
                        product.Name = txtProductName.Text;
                    }

                    try
                    {
                        product.Price = float.Parse(txtPrice.Text);
                        product.Stock = int.Parse(txtStock.Text);
                    }
                    catch (Exception ex)
                    {
                        flag = 1;
                        MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string qur1 = $"select Id from Category where Name = '{cbCategory.SelectedItem.ToString()}'";

                    var id = DBClass.ReadSingleRecord(qur1);
                    product.CategoryId = int.Parse(id["Id"].ToString());

                    if (flag == 0)
                    {
                        product.AddProduct();
                        MessageBox.Show("Product Added Successfully");
                    }

                    txtProductName.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();

                    CategorizedProductList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                try
                {
                    pid = int.Parse(dgvAdmin.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                    productName = dgvAdmin.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    price = float.Parse(dgvAdmin.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    stock = int.Parse(dgvAdmin.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());

                    txtProductName.Text = productName;
                    txtPrice.Text = price.ToString();
                    txtStock.Text = stock.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Meessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this record ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //Since Product_Id is refferd by Id of Product
                    string qur2 = $"delete from Purchase where Product_Id = '{pid}'";
                    DBClass.Execute_Query(qur2);
                    string qur3 = $"delete from Sales where Product_Id = '{pid}'";
                    DBClass.Execute_Query(qur3);

                    string qur1 = $"delete from Product where Name = '{productName}'";
                    DBClass.Execute_Query(qur1);
                    MessageBox.Show("Product Removed Succssfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtProductName.Clear();
                txtPrice.Clear();
                txtStock.Clear();

                if (cbCategory.SelectedItem == null)
                {
                    RefreshTable();
                }
                else
                {
                    CategorizedProductList();
                }
            }
        }
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Select Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Product product = new Product();
                product.Id = pid;
                product.Name = txtProductName.Text;
                try
                {
                    product.Price = float.Parse(txtPrice.Text);
                    product.Stock = int.Parse(txtStock.Text);
                }
                catch (Exception ex)
                {
                    flag = 1;
                    MessageBox.Show(ex.Message, "Error Meessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(flag != 1)
                {
                    string qur1 = $"select Id from Category where Name = '{cbCategory.SelectedItem.ToString()}'";

                    var id = DBClass.ReadSingleRecord(qur1);
                    product.CategoryId = int.Parse(id["Id"].ToString());
                    product.UpdateProduct();

                    MessageBox.Show("Product Updated Successfully");

                    txtProductName.Clear();
                    txtPrice.Clear();
                    txtStock.Clear();

                    CategorizedProductList();
                }
                
            }
        }
        #endregion
    }
}
