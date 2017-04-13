using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipdMPMain
{
    class Database
    {
        private SqlConnection conn;
        public Database()
        {
            // IF MULTI  updates....use TRANSACTIONS...
            conn = new SqlConnection("Server=tcp:mocko.database.windows.net,1433;Initial Catalog=MockO;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
        }

    }

    public void AddUser(NewUser nu)
    {
        string sql = "INSERT INTO Users.UserProfile(userID)"
    }
}
