namespace ChatApp
{
    public class User
    {
        public User(string username, int id)
        {
            Username = username;
            ID = id;
        }

        public string Username { get; set; }
        public int ID { get; set; }
        
    }
}
