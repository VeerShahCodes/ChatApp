using System.Data;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ChatApp
{
    public class SQL
    {
        public string ConnectionString { get; set; }
        SqlConnection Connection;
        public SQL(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new SqlConnection(ConnectionString);
        }

        private int ExecuteNonQuery(SqlCommand sqlCommand)
        {
            Connection.Open();
            int x = -1;
            try
            {
                x = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }
            return x;
        }

        private object ExecuteScalar(SqlCommand sqlCommand)
        {
            object? value;
            Connection.Open();
            try
            {
                value = sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                value = null;
            }
            finally
            {
                Connection.Close();
                
            }
            return value;
        }

        private DataTable DataReturn(SqlCommand command)
        {
            DataTable data = new DataTable();

            Connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            Connection.Close();

            return data;
        }
        public bool CreateAccount(string username, string password)
        {
            string salt = MakeSalt();
            string hash = CreateMD5Hash(password + salt);
            string query = "usp_CreateAccount";

            SqlCommand command = new SqlCommand(query, Connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@PasswordHash", hash);
            command.Parameters.AddWithValue("@Salt", salt);

            int x = ExecuteNonQuery(command);
            if (x != -1) return true;
            return false;
        }
        public object GetID(string username)
        {
            SqlCommand command = new SqlCommand("usp_GetID", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);

            return ExecuteScalar(command);
        }
        public DataTable Login(string username, string password)
        {
            //get salt
            SqlCommand getSalt = new SqlCommand("usp_GetSalt", Connection);
            getSalt.CommandType = System.Data.CommandType.StoredProcedure;
            getSalt.Parameters.AddWithValue("@Username", username);

            string salt = (string)ExecuteScalar(getSalt);

            //create hashed password
            string hashedPassword = CreateMD5Hash(password + salt);

            SqlCommand command = new SqlCommand("usp_Login", Connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);

            DataTable data = DataReturn(command);

            return data;
        }

        public static string CreateMD5Hash(string input)
        {
            using (MD5 mD5 = MD5.Create())
            {
                byte[] rawData = Encoding.UTF8.GetBytes(input);

                byte[] data = mD5.ComputeHash(rawData);

                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
        public static string MakeSalt()
        {
            var sb = new StringBuilder();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                sb.Append((char)random.Next(33, 126));
            }
            return sb.ToString();
        }
    }
}
