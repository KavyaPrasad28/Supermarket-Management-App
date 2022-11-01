using SuperMarketApp2.DataBase;
using SuperMarketApp2.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarketApp2.PresentationLayers
{
    public partial class SalesInfo : UserControl
    {
        public SalesInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Binds Sales table to dgvSales
        /// </summary>
        private void SalesTableBind()
        {
            Sales sales = new Sales();
            var data = sales.ViewSalesInfo();

            dgvSales.AutoGenerateColumns = false;

            dgvSales.ColumnCount = 6;

            dgvSales.Columns[0].Name = "Id";
            dgvSales.Columns[0].HeaderText = "Sale Id";
            dgvSales.Columns[0].DataPropertyName = "Id";

            dgvSales.Columns[1].Name = "Name";
            dgvSales.Columns[1].HeaderText = "Product Name";
            dgvSales.Columns[1].DataPropertyName = "Name";

            dgvSales.Columns[2].Name = "Quantity";
            dgvSales.Columns[2].HeaderText = "Quantity";
            dgvSales.Columns[2].DataPropertyName = "Quantity";

            dgvSales.Columns[3].Name = "Price";
            dgvSales.Columns[3].HeaderText = "Price";
            dgvSales.Columns[3].DataPropertyName = "Price";

            dgvSales.Columns[4].Name = "Total";
            dgvSales.Columns[4].HeaderText = "Total Price";
            dgvSales.Columns[4].DataPropertyName = "Total";

            dgvSales.Columns[5].Name = "Sale_Date";
            dgvSales.Columns[5].HeaderText = "Sale Date";
            dgvSales.Columns[5].DataPropertyName = "Date";


            dgvSales.DataSource = data;
        }

        /// <summary>
        /// For binding the sales table to dgvSales according to the choosen date range
        /// </summary>
        private void RefreshSalesTable()
        {
            var fromDate = DateTime.Parse(dtpFrom.Text);
            var toDate = DateTime.Parse(dtpTo.Text);
            string qur = $"select * from Sales S left join Product PD on S.Product_Id = PD.Id where S.Date between '{fromDate.ToString("MM-dd-yyyy")}' and '{toDate.ToString("MM-dd-yyyy")}'";

            var data = DBClass.ReadTable(qur);

            dgvSales.AutoGenerateColumns = false;

            dgvSales.Columns[0].Name = "Id";
            dgvSales.Columns[0].HeaderText = "Sale Id";
            dgvSales.Columns[0].DataPropertyName = "Id";

            dgvSales.Columns[1].Name = "Name";
            dgvSales.Columns[1].HeaderText = "Product Name";
            dgvSales.Columns[1].DataPropertyName = "Name";

            dgvSales.Columns[2].Name = "Quantity";
            dgvSales.Columns[2].HeaderText = "Quantity";
            dgvSales.Columns[2].DataPropertyName = "Quantity";

            dgvSales.Columns[3].Name = "Price";
            dgvSales.Columns[3].HeaderText = "Price";
            dgvSales.Columns[3].DataPropertyName = "Price";

            dgvSales.Columns[4].Name = "Total";
            dgvSales.Columns[4].HeaderText = "Total Price";
            dgvSales.Columns[4].DataPropertyName = "Total";

            dgvSales.Columns[5].Name = "Sale_Date";
            dgvSales.Columns[5].HeaderText = "Sale Date";
            dgvSales.Columns[5].DataPropertyName = "Date";

            dgvSales.DataSource = data;
        }

        #region Events
        private void SalesInfo_Load(object sender, EventArgs e)
        {
            SalesTableBind();
        }

        private void pdSales_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int numberOfItemsPerPage = 0;
            int numberOfItemsPrintedSoFar = 0;

            string heading = "SUPERMARKET SALES REPORT";
            e.Graphics.DrawString(heading, new System.Drawing.Font("Book Antiqua", 25, FontStyle.Bold), Brushes.Blue, 120, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 0, 100);

            string g1 = "Sale\nId";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 50, 140);

            string g2 = "Product Name";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 130, 140);

            string g3 = "Quantity";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 300, 140);

            string g4 = "Price";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 400, 140);

            string g5 = "Total";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 500, 140);

            string g6 = "Sale Date";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 600, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 0, 170);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < dgvSales.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= dgvSales.Rows.Count)
                    {

                        height += dgvSales.Rows[0].Height;

                        e.Graphics.DrawString(dgvSales.Rows[l].Cells[0].FormattedValue.ToString(), dgvSales.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(50, height, dgvSales.Columns[0].Width, dgvSales.Rows[0].Height));

                        e.Graphics.DrawString(dgvSales.Rows[l].Cells[1].FormattedValue.ToString(), dgvSales.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(130, height, dgvSales.Columns[0].Width, dgvSales.Rows[0].Height));

                        e.Graphics.DrawString(dgvSales.Rows[l].Cells[2].FormattedValue.ToString(), dgvSales.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(300, height, dgvSales.Columns[0].Width, dgvSales.Rows[0].Height));

                        e.Graphics.DrawString(dgvSales.Rows[l].Cells[3].FormattedValue.ToString(), dgvSales.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(400, height, dgvSales.Columns[0].Width, dgvSales.Rows[0].Height));

                        e.Graphics.DrawString(dgvSales.Rows[l].Cells[4].FormattedValue.ToString(), dgvSales.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(500, height, dgvSales.Columns[0].Width, dgvSales.Rows[0].Height));

                        e.Graphics.DrawString(dgvSales.Rows[l].Cells[5].FormattedValue.ToString(), dgvSales.Font = new Font("Book Antiqua", 14), Brushes.Black, new RectangleF(600, height, dgvSales.Columns[0].Width, dgvSales.Rows[0].Height));
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

        private void btnPrintSales_Click(object sender, EventArgs e)
        {
            if (ppdSales.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pdSales.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshSalesTable();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
