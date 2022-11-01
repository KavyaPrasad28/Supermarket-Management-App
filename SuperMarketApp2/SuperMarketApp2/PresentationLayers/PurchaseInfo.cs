using SuperMarketApp2.DataBase;
using SuperMarketApp2.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarketApp2.PresentationLayers
{
    public partial class PurchaseInfo : UserControl
    {
        public PurchaseInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Binds Purchase table to dgvPurchase
        /// </summary>
        private void PurchaseTableBind()
        {
            Purchase purchase = new Purchase();
            var data = purchase.ViewPurchaseInfo();

            dgvPurchase.AutoGenerateColumns = false;

            dgvPurchase.ColumnCount = 6;

            dgvPurchase.Columns[0].Name = "Id";
            dgvPurchase.Columns[0].HeaderText = "Purchase Id";
            dgvPurchase.Columns[0].DataPropertyName = "Id";

            dgvPurchase.Columns[1].Name = "Name";
            dgvPurchase.Columns[1].HeaderText = "Product Name";
            dgvPurchase.Columns[1].DataPropertyName = "Name";

            dgvPurchase.Columns[2].Name = "Quantity";
            dgvPurchase.Columns[2].HeaderText = "Quantity";
            dgvPurchase.Columns[2].DataPropertyName = "Quantity";

            dgvPurchase.Columns[3].Name = "Price";
            dgvPurchase.Columns[3].HeaderText = "Price";
            dgvPurchase.Columns[3].DataPropertyName = "Price";

            dgvPurchase.Columns[4].Name = "Total";
            dgvPurchase.Columns[4].HeaderText = "Total Price";
            dgvPurchase.Columns[4].DataPropertyName = "Total";

            dgvPurchase.Columns[5].Name = "Purchased_Date";
            dgvPurchase.Columns[5].HeaderText = "Purchase Date";
            dgvPurchase.Columns[5].DataPropertyName = "Purchased_Date";

            dgvPurchase.DataSource = data;
        }

        /// <summary>
        /// For binding the Purchase table to dgvPurchase according to the choosen date range
        /// </summary>
        private void RefreshPurchaseTable()
        {
            var fromDate = DateTime.Parse(dtpFrom.Text);
            var toDate = DateTime.Parse(dtpTo.Text);
            string qur = $"select * from Purchase P left join Product PD on P.Product_Id = PD.Id where P.Purchased_Date between '{fromDate.ToString("MM-dd-yyyy")}' and '{toDate.ToString("MM-dd-yyyy")}'";

            var data = DBClass.ReadTable(qur);

            dgvPurchase.AutoGenerateColumns = false;

            dgvPurchase.Columns[0].Name = "Id";
            dgvPurchase.Columns[0].HeaderText = "Purchase Id";
            dgvPurchase.Columns[0].DataPropertyName = "Id";

            dgvPurchase.Columns[1].Name = "Name";
            dgvPurchase.Columns[1].HeaderText = "Product Name";
            dgvPurchase.Columns[1].DataPropertyName = "Name";

            dgvPurchase.Columns[2].Name = "Quantity";
            dgvPurchase.Columns[2].HeaderText = "Quantity";
            dgvPurchase.Columns[2].DataPropertyName = "Quantity";

            dgvPurchase.Columns[3].Name = "Price";
            dgvPurchase.Columns[3].HeaderText = "Price";
            dgvPurchase.Columns[3].DataPropertyName = "Price";

            dgvPurchase.Columns[4].Name = "Total";
            dgvPurchase.Columns[4].HeaderText = "Total Price";
            dgvPurchase.Columns[4].DataPropertyName = "Total";

            dgvPurchase.Columns[5].Name = "Purchased_Date";
            dgvPurchase.Columns[5].HeaderText = "Purchase Date";
            dgvPurchase.Columns[5].DataPropertyName = "Purchased_Date";

            dgvPurchase.DataSource = data;
        }
        #region Events
        private void PurchaseInfo_Load(object sender, EventArgs e)
        {
            PurchaseTableBind();
        }

        private void pdPurchase_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int numberOfItemsPerPage = 0;
            int numberOfItemsPrintedSoFar = 0;

            string heading = "SUPERMARKET PURCHASE REPORT";
            e.Graphics.DrawString(heading, new System.Drawing.Font("Book Antiqua", 25, FontStyle.Bold), Brushes.Blue, 120, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 0, 100);

            string g1 = "Purchase\nId";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 50, 140);

            string g2 = "Product Name";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 150, 140);

            string g3 = "Quantity";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 300, 140);

            string g4 = "Price";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 400, 140);

            string g5 = "Total";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 500, 140);

            string g6 = "Purchase Date";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 600, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 0, 170);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < dgvPurchase.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= dgvPurchase.Rows.Count)
                    {

                        height += dgvPurchase.Rows[0].Height;

                        e.Graphics.DrawString(dgvPurchase.Rows[l].Cells[0].FormattedValue.ToString(), dgvPurchase.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(50, height, dgvPurchase.Columns[0].Width, dgvPurchase.Rows[0].Height));

                        e.Graphics.DrawString(dgvPurchase.Rows[l].Cells[1].FormattedValue.ToString(), dgvPurchase.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(150, height, dgvPurchase.Columns[0].Width, dgvPurchase.Rows[0].Height));

                        e.Graphics.DrawString(dgvPurchase.Rows[l].Cells[2].FormattedValue.ToString(), dgvPurchase.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(300, height, dgvPurchase.Columns[0].Width, dgvPurchase.Rows[0].Height));

                        e.Graphics.DrawString(dgvPurchase.Rows[l].Cells[3].FormattedValue.ToString(), dgvPurchase.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(400, height, dgvPurchase.Columns[0].Width, dgvPurchase.Rows[0].Height));

                        e.Graphics.DrawString(dgvPurchase.Rows[l].Cells[4].FormattedValue.ToString(), dgvPurchase.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(500, height, dgvPurchase.Columns[0].Width, dgvPurchase.Rows[0].Height));

                        e.Graphics.DrawString(dgvPurchase.Rows[l].Cells[5].FormattedValue.ToString(), dgvPurchase.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(600, height, dgvPurchase.Columns[0].Width, dgvPurchase.Rows[0].Height));
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }
            }
        }

        private void btnPrintPurchase_Click(object sender, EventArgs e)
        {
            if (ppdPurchase.ShowDialog() == DialogResult.OK)
            {
                pdPurchase.Print();
            }
        }
        
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshPurchaseTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
