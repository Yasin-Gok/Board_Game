using System.Data.SqlClient;

namespace Prelab
{
    internal class Database
    {
        private static Database database;

        private string con = "Data Source=sql8002.site4now.net;Initial Catalog=db_a88027_hardalt;Persist Security Info=True;User ID=db_a88027_hardalt_admin;Password=hardal123";
        private SqlConnection sqlConnection;

        public string ConnectionString
        {
            get => con;
        }
        /// <summary>
        /// This function creates connection with connection string.
        /// </summary>
        public void GetConnection()
        {
            sqlConnection = new SqlConnection(con);
        }
        public SqlConnection Sqlconnection
        {
            get => sqlConnection;
        }
        /// <summary>
        /// This function is for implement Singleton Pattern.
        /// </summary>
        /// <returns>Non Null Database object</returns>
        public static Database CreateSingle()
        {
            if (database == null)
            {
                database = new Database();
            }
            return database;
        }
    }
}