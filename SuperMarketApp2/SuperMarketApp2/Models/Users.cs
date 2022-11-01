using SuperMarketApp2.DataBase;
using System.Data;

namespace SuperMarketApp2.Models
{
    /// <summary>
    /// Abstract class which is inherited by Admin class and Employee class
    /// </summary>
    public abstract class Users
    {
        //Fields of Admin and Employee class
        public static Admin admin;
        public static Employee employee;

        //Properties
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// For validating username and password during login
        /// </summary>
        /// <param name="inputUsername">Username input from txtUserName</param>
        /// <param name="inputPassword">Password input from txtPswd</param>
        /// <returns></returns>
        public static string LoginProcess(string inputUsername, string inputPassword)
        {
            var dt = DBClass.ReadTable("select * from Users");
            var userExist = false;
            string pass = string.Empty;
            string id = string.Empty;
            foreach (DataRow item in dt.Rows)
            {
                if (inputUsername == item["UserName"].ToString())
                {
                    userExist = true;
                    pass = item["Password"].ToString();
                    id = item["Id"].ToString();
                    break;
                }
            }

            if (!userExist)
            {
                return "Username doesn't exist";
            }

            if (inputPassword == pass)
            {
                switch (id)
                {
                    case "1":
                        admin = new Admin();
                        admin.UserName = inputUsername;
                        admin.ReadfromDB();
                        return id;
                    case "2":
                        employee = new Employee();
                        employee.UserName = inputUsername;
                        employee.ReadfromDB();
                        return id;
                    default:
                        break;
                }
            }
            else
            {
                return "Invalid Password";
            }
            return string.Empty;
        }
    }
    public class Admin : Users
    {
        /// <summary>
        /// For validating Admin Username and Password 
        /// </summary>
        /// <returns>bool value</returns>
        public bool ReadfromDB()
        {
            var sql = $"select * from Users where UserName = '{UserName}'";
            try
            {
                var record = DBClass.ReadSingleRecord(sql);
                this.Password = record["Password"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public class Employee : Users
    {
        /// <summary>
        /// For validating Employee Username and Password
        /// </summary>
        /// <returns>bool value</returns>
        public bool ReadfromDB()
        {
            var sql = $"select * from Users where UserName = '{UserName}'";
            try
            {
                var record = DBClass.ReadSingleRecord(sql);
                this.Password = record["Password"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
