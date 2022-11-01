using SuperMarketApp2.DataBase;
using System;
using System.Data;

namespace SuperMarketApp2.Models
{
    public class Sales
    {
        #region Properties
        public int Id { get; set; }//Not used since it set as Identity in Sales table
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }
        public DateTime Date { get; set; }
        #endregion

        /// <summary>
        /// For inserting data to Sales Table
        /// </summary>
        public void AddSale()
        {
            string que = $"insert into Sales (Product_Id, Quantity, Total, Date) values('{ProductId}','{Quantity}','{Total}','{Date.ToString("MM-dd-yyyy")}')";
            DBClass.Execute_Query(que);
        }

        /// <summary>
        /// For selecting the Puchase details by joining product and Sales table
        /// </summary>
        /// <returns>DataTable data</returns>
        internal DataTable ViewSalesInfo()
        {
            string qur = $"select * from Sales S left join Product PD on S.Product_Id = PD.Id";
            var data = DBClass.ReadTable(qur);
            return data;
        }
    }
}
