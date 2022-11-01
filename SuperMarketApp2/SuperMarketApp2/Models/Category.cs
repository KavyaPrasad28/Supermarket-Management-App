using SuperMarketApp2.DataBase;
using System.Data.SqlClient;

namespace SuperMarketApp2.Models
{
    public class Category
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// To get Names from Category Table
        /// </summary>
        /// <returns>SqlDataReader data</returns>
        internal SqlDataReader GetCategory()
        {
            string qur = $"select Name from Category";
            var data = DBClass.ReadColomn(qur);
            return data;
        }
    }
}
