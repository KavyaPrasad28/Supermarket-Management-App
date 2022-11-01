using SuperMarketApp2.DataBase;
using SuperMarketApp2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarketApp2
{
    public partial class SalesPage : Form
    {
        public SalesPage()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            btnPrint.Enabled = false;
            closeFlag = 0;
        }

        public static int closeFlag;
        List<string> price = new List<string>(); //For storing price of each added product

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
        /// Adds Product names to cbProductNames according to selected category on cbCategory
        /// </summary>
        private void CategorizedProductBind()
        {
            Product product = new Product();

            if (cbCategory.SelectedItem.ToString() == "Stationery")
            {
                if (cbProductNames.Items != null)
                {
                    cbProductNames.Items.Clear();
                }
                var dr = product.ReadStationeryList();
                while (dr.Read())
                {
                    cbProductNames.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }

            if (cbCategory.SelectedItem.ToString() == "Grocery")
            {
                if (cbProductNames.Items != null)
                {
                    cbProductNames.Items.Clear();
                }
                var dr = product.ReadGroceryList();
                while (dr.Read())
                {
                    cbProductNames.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }

            if (cbCategory.SelectedItem.ToString() == "Fruit")
            {
                if (cbProductNames.Items != null)
                {
                    cbProductNames.Items.Clear();
                }
                var dr = product.ReadFruitList();
                while (dr.Read())
                {
                    cbProductNames.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }

            if (cbCategory.SelectedItem.ToString() == "Vegetable")
            {
                if (cbProductNames.Items != null)
                {
                    cbProductNames.Items.Clear();
                }
                var dr = product.ReadVegetableList();
                while (dr.Read())
                {
                    cbProductNames.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
        }

        /// <summary>
        /// For adding products to lbProductList
        /// </summary>
        private void AddProducts()
        {
            lbProductList.Items.Add($"{cbProductNames.SelectedItem.ToString()} ({txtQuantity.Text})");
        }

        /// <summary>
        /// Calculates total price of the added products
        /// </summary>
        /// <returns>total</returns>
        private float CalculateTotal()
        {
            int quantity = int.Parse(txtQuantity.Text);
            float price = float.Parse(txtPrice.Text);
            float total = quantity * price;
            return total;
        }

        /// <summary>
        /// For updating Stock column of Product table and for inserting values to Stock table
        /// </summary>
        private void UpdateTables()
        {
            string qur1 = $"select Stock from Product where Id = '{int.Parse(txtPdId.Text)}'";
            var stock = DBClass.ReadSingleRecord(qur1);
            var update = int.Parse(stock["Stock"].ToString()) - int.Parse(txtQuantity.Text);

            if (update < 0)
            {
                MessageBox.Show("Out of Stock !!" + Environment.NewLine + $"Available Stock = {stock["Stock"].ToString()}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddProducts();

                price.Add(txtPrice.Text);

                float total1 = float.Parse(lblTotal.Text);
                float grandTotal = total1 + CalculateTotal();
                lblTotal.Text = grandTotal.ToString();

                Sales sale = new Sales();
                sale.ProductId = int.Parse(txtPdId.Text);
                try
                {
                    sale.Quantity = int.Parse(txtQuantity.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sale.Total = CalculateTotal();
                sale.Date = DateTime.Parse(dtpProduct.Text);
                sale.AddSale();

                string qur2 = $"update Product set Stock = '{update}' where Id = '{int.Parse(txtPdId.Text)}'";
                DBClass.Execute_Query(qur2);
            }
            
        }

        #region Events
        private void SalesPage_Load(object sender, EventArgs e)
        {
            CategoryBind();
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            CategorizedProductBind();
        }

        private void cbProductNames_SelectedValueChanged(object sender, EventArgs e)
        {
            string qur1 = $"select Id from Product where Name = '{cbProductNames.SelectedItem.ToString()}'";

            var id = DBClass.ReadSingleRecord(qur1);
            txtPdId.Text = id["Id"].ToString();

            string qur2 = $"select Price from Product where Name = '{cbProductNames.SelectedItem.ToString()}'";
            var price = DBClass.ReadSingleRecord(qur2);
            txtPrice.Text = price["Price"].ToString();

            string qur3 = $"select Stock from Product where Name = '{cbProductNames.SelectedItem.ToString()}'";

            var availableStock = DBClass.ReadSingleRecord(qur3);
            lblStock.Text = availableStock["Stock"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateTables();

            string qur3 = $"select Stock from Product where Name = '{cbProductNames.SelectedItem.ToString()}'";

            var availableStock = DBClass.ReadSingleRecord(qur3);
            lblStock.Text = availableStock["Stock"].ToString();

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text) && string.IsNullOrEmpty(dtpProduct.Text))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            if (float.Parse(lblTotal.Text) > 0)
            {
                btnPrint.Enabled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SUPERMARKET SALES BILL", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(200, 50));

            e.Graphics.DrawString("Products", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(70, 150));

            e.Graphics.DrawString("Price ", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(250, 150));

            int i = 0;
            foreach (var item in lbProductList.Items)
            {
                e.Graphics.DrawString($"{item}", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(70, 200 + i));
                i += 50;
            }

            int g = 0;
            foreach (var p in price)
            {
                e.Graphics.DrawString($"₹ {p}/-", new Font("Century Gothic", 18, FontStyle.Bold), Brushes.Black, new Point(250, 200 + g));
                g += 50;
            }

            e.Graphics.DrawString($"Sale Date: {dtpProduct.Text}", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(70, 200 + i));

            e.Graphics.DrawString($"Total Rs: {lblTotal.Text}/-", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(70, 250 + i));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void SalesPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeFlag = 1;
        }
        #endregion
    }
}
