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
        
        private bool ExecuteScalar(SqlCommand sqlCommand, out object value, out Exception error)
        {
            Connection.Open();
            try
            {
                value = sqlCommand.ExecuteScalar();
                error = null;
            }
            catch(Exception ex)
            {
                value = -1;
                error = ex;
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return true;
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
        public bool CreateAccount(string username, string password, out object id)
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

            GetID(username, out id);

            if (x != -1) return true;
            return false;
        }
        public bool GetID(string username, out object UserID)
        {
            SqlCommand command = new SqlCommand("usp_GetID", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);

            return ExecuteScalar(command, out UserID, out Exception error);
            
        }
        public bool Login(string username, string password, out object UserID, out Exception login_error)
        {
            //get salt
            SqlCommand getSalt = new SqlCommand("usp_GetSalt", Connection);
            getSalt.CommandType = System.Data.CommandType.StoredProcedure;
            getSalt.Parameters.AddWithValue("@Username", username);
            object salt;
            bool success = ExecuteScalar(getSalt, out salt, out Exception error);

            //create hashed password
            string hashedPassword = CreateMD5Hash(password + salt);

            SqlCommand command = new SqlCommand("usp_Login", Connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@PasswordHash", hashedPassword);

            return ExecuteScalar(command, out UserID, out login_error);

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

        public bool JoinRoom(string roomName,  string roomPassword)
        {
            string cmd = "usp_JoinRoom";
            return true;
        }

        public bool CreateRoom(string roomName, string roomPassword, out object id)
        {
            string cmd = "usp_CreateRoom";
            SqlCommand command = new SqlCommand(cmd, Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoomName", roomName);
            command.Parameters.AddWithValue("@RoomPassword", roomPassword);

            int x =  ExecuteNonQuery(command);
            GetRoomID(roomName, out id);
            if (x == -1) return false;
            return true;
        }

        public bool GetRoomID(string roomName, out object id)
        {
            SqlCommand command = new SqlCommand("usp_GetRoomID", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoomName", roomName);

            return ExecuteScalar(command, out id, out Exception error);
        }

        private bool JoinRoom(string roomName, string roomPassword, out object roomID)
        {
            if (ExecuteScalar(new SqlCommand("usp_JoinRoom", Connection), out roomID, out Exception error))
            {
                return true;
            }
            return false;
        }

        public bool 
    }
}
