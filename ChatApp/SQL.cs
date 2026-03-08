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

        public void CreateAccount(string username, string password)
        {
            string salt = MakeSalt();
            string hash = CreateMD5Hash(password + salt);

            Connection.Open();

            Connection.Close();
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
