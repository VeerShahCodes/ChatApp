namespace ChatApp
{
    public class Room
    {
        public string RoomName { get; set; }
        public int RoomID { get; set; }
        public Room(string name, int id)
        {
            RoomName = name;
            RoomID = id;
        }
    }
}
