using SuperMarketApp2.DataBase;
using SuperMarketApp2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarketApp2.PresentationLayers
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            btnPrint.Enabled = false;
            closeFlag = 0;
        }

        public static int closeFlag;
        List<string> price = new List<string>();//For storing price of each added product

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
        /// For updating Stock column of Product table
        /// </summary>
        public void UpdateProductTable()
        {
            string qur1 = $"select Stock from Product where Id = '{int.Parse(txtPdId.Text)}'";
            var stock = DBClass.ReadSingleRecord(qur1);
            var update = int.Parse(stock["Stock"].ToString()) + int.Parse(txtQuantity.Text);

            string qur2 = $"update Product set Stock = '{update}' where Id = '{int.Parse(txtPdId.Text)}'";
            DBClass.Execute_Query(qur2);
        }

        /// <summary>
        /// For inserting values to Purchase table
        /// </summary>
        private void AddToPurchaseTable()
        {
            Purchase purchase = new Purchase();
            purchase.ProductId = int.Parse(txtPdId.Text);
            purchase.Price = float.Parse(txtPrice.Text);
            try
            {
                purchase.Quantity = int.Parse(txtQuantity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            purchase.Total = CalculateTotal();
            purchase.Date = DateTime.Parse(dtpProduct.Text);
            purchase.AddPurchase();
        }


        #region Events
        private void PurchaseForm_Load(object sender, EventArgs e)
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
            price.Add(txtPrice.Text);

            AddProducts();

            float total1 = float.Parse(lblTotal.Text);
            float grandTotal = total1 + CalculateTotal();
            lblTotal.Text = grandTotal.ToString();

            AddToPurchaseTable();

            UpdateProductTable();

            string qur3 = $"select Stock from Product where Name = '{cbProductNames.SelectedItem.ToString()}'";

            var availableStock = DBClass.ReadSingleRecord(qur3);
            lblStock.Text = availableStock["Stock"].ToString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtQuantity.Text) && string.IsNullOrEmpty(dtpProduct.Text))
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
            if(float.Parse(lblTotal.Text) > 0 )
            {
                btnPrint.Enabled = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SUPERMARKET PURCHASE BILL", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Blue, new Point(180, 50));

            e.Graphics.DrawString("Products", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(70,150));

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

            e.Graphics.DrawString($"Purchase Date: {dtpProduct.Text}", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(70, 200 + i));

            e.Graphics.DrawString($"Total Rs: {lblTotal.Text}/-", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(70, 250 + i));
        }
        
        private void PurchaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeFlag = 1;
        }
        #endregion
    }
}
