using System.Data;
using System.Data.SqlClient;

namespace SuperMarketApp2.DataBase
{
    /// <summary>
    /// Contains the connection string and static methods for executing queries.
    /// </summary>
    public class DBClass
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\source\Training\SuperMarketApp2\SuperMarketApp2\DataBase\DBSuperMarket.mdf;Integrated Security=True";

        /// <summary>
        /// For executing sql queries
        /// </summary>
        /// <param name="que">string which contains the sql query</param>
        public static void Execute_Query(string que)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(que, connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }

        }

        /// <summary>
        /// For reading the data table
        /// </summary>
        /// <param name="qur">string which contains the sql query</param>
        /// <returns>SqlDataReader dr</returns>
        public static SqlDataReader ReadColomn(string qur)
        {
            SqlDataReader dr;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            var command = new SqlCommand(qur, connection);
            dr = command.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// To get the data row from the data table based on the query
        /// </summary>
        /// <param name="query">string which contains the sql query</param>
        /// <returns>DataRow dt.Rows[0]</returns>
        public static DataRow ReadSingleRecord(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var command = new SqlCommand(query, con);
                using (SqlDataAdapter sda = new SqlDataAdapter(command))
                {
                    sda.Fill(dt);
                }
                command.Dispose();
            }
            return dt.Rows[0];
        }

        /// <summary>
        /// For executing queries related to data table
        /// </summary>
        /// <param name="query">string which contains the sql query</param>
        /// <returns>DataTable dt</returns>
        public static DataTable ReadTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                using (SqlDataAdapter sda = new SqlDataAdapter(command))
                {
                    sda.Fill(dt);
                }
                command.Dispose();
            }
            return dt;
        }

    }
}
