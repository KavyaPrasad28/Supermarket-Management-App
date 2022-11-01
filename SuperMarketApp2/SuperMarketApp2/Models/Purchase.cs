using SuperMarketApp2.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketApp2.Models
{
    public class Purchase
    {
        #region Properties
        public int Id { get; set; }//Not used since it set as Identity in Purchase table
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Total { get; set; }
        #endregion

        /// <summary>
        /// For inserting data to Purchase table
        /// </summary>
        public void AddPurchase()
        {
            string que = $"insert into Purchase (Product_Id, Quantity, Price, Total, Purchased_Date) values('{ProductId}','{Quantity}','{Price}','{Total}','{Date.ToString("MM-dd-yyyy")}')";
            DBClass.Execute_Query(que);
        }

        /// <summary>
        /// For selecting the Puchase details by joining product and Purchase table
        /// </summary>
        /// <returns>DataTable data</returns>
        internal DataTable ViewPurchaseInfo()
        {
            string qur = $"select * from Purchase P left join Product PD on P.Product_Id = PD.Id";
            var data = DBClass.ReadTable(qur);
            return data;
        }
    }
}
