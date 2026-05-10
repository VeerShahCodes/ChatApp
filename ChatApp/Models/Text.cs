namespace ChatApp
{
    public class Text
    {
        public int TextID { get; set; }
        public string Content { get; set; }
        public int AccountID { get; set; }
        public int RoomID { get; set; }
        public DateTime dateTime { get; set; }

        public Text(int textId, string content, int accountId, int roomId, DateTime dateTime)
        {
            TextID = textId;
            Content = content;
            AccountID = accountId;
            RoomID = roomId;
            this.dateTime = dateTime;
        }
    }
}
