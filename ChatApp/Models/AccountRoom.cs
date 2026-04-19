namespace ChatApp
{
    public class AccountRoom
    {
        public int RoomID { get; set; }
        public int UserID { get; set; }

        public AccountRoom(int uId, int rId)
        {
            UserID = uId;
            RoomID = rId;
        }

    }
}
