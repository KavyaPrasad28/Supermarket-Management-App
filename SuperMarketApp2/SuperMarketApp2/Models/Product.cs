using SuperMarketApp2.DataBase;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarketApp2.Models
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        #endregion

        #region Functions

        /// <summary>
        /// For inserting data to Product table
        /// </summary>
        public void AddProduct()
        {
            string que = $"insert into Product (Name, Price, Stock, Category_Id) values('{Name}','{Price}','{Stock}','{CategoryId}')";
            DBClass.Execute_Query(que);
        }

        /// <summary>
        /// For updating the values of Product table
        /// </summary>
        public void UpdateProduct()
        {
            string que = $"update Product set Name = '{Name}', Price = '{Price}', Stock = '{Stock}', Category_Id = '{CategoryId}' where Id = '{Id}'";
            DBClass.Execute_Query(que);
        }

        /// <summary>
        /// To select the Product table from database
        /// </summary>
        /// <returns>DataTable data</returns>
        internal DataTable ViewProductList()
        {
            string qur = $"select * from Product";
            var data = DBClass.ReadTable(qur);
            return data;
        }
        /// <summary>
        /// To select Names from Product table
        /// </summary>
        /// <returns>SqlDataReader data</returns>
        internal SqlDataReader ReadProductNames()
        {
            string qur = $"select Name from Product";
            var data = DBClass.ReadColomn(qur);
            return data;
        }

        // For selecting Names from Product table based on Category_Id
        #region Categorized Products Selection
        internal SqlDataReader ReadStationeryList()
        {
            string qur = $"select Name from Product where Category_Id = '1'";
            var data = DBClass.ReadColomn(qur);
            return data;
        }

        internal SqlDataReader ReadGroceryList()
        {
            string qur = $"select Name from Product where Category_Id = '2'";
            var data = DBClass.ReadColomn(qur);
            return data;
        }

        internal SqlDataReader ReadFruitList()
        {
            string qur = $"select Name from Product where Category_Id = '3'";
            var data = DBClass.ReadColomn(qur);
            return data;
        }

        internal SqlDataReader ReadVegetableList()
        {
            string qur = $"select Name from Product where Category_Id = '4'";
            var data = DBClass.ReadColomn(qur);
            return data;
        }

        internal DataTable ViewStationeryList()
        {
            string qur = $"select * from Product where Category_Id = '1'";
            var data = DBClass.ReadTable(qur);
            return data;
        }

        internal DataTable ViewGroceryList()
        {
            string qur = $"select * from Product where Category_Id = '2'";
            var data = DBClass.ReadTable(qur);
            return data;
        }

        internal DataTable ViewFruitList()
        {
            string qur = $"select * from Product where Category_Id = '3'";
            var data = DBClass.ReadTable(qur);
            return data;
        }

        internal DataTable ViewVegetableList()
        {
            string qur = $"select * from Product where Category_Id = '4'";
            var data = DBClass.ReadTable(qur);
            return data;
        }
        #endregion

        #endregion
    }
}
