using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Primitives;
using System.Data;

namespace ChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatRoomController : ControllerBase
    {
        //old connection
        //string connection = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ChatDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
        string connection = "Data Source=(localdb)\\ProjectModels;Initial Catalog=ChatDB;Integrated Security=True;Pooling=False;Connect Timeout=30";
        SQL Sql = new SQL("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\GMRDC1\\Folder Redirection\\Veer.Shah\\Documents\\Visual Studio 2022\\Projects\\SQLAPIs\\ChatApp\\DBLibrary\\ChatRoomDB.mdf\";Integrated Security=True");
        [HttpPost("CreateAccount")]      


        public ActionResult<User> CreateAccount(string username, string password)
        {
            object id;

            if (Sql.CreateAccount(username, password, out id))
            {
                return Ok(new User(username, (int)id));
            }
            return BadRequest();
        }

        [HttpGet("Login")]
        public ActionResult<User> Login(string username, string password)
        {
            object id;
            Exception err;
            if(Sql.Login(username, password, out id, out err))
            {
                return Ok(new User(username, (int)id));
            }
            

            return BadRequest();
        }

        [HttpPost("CreateRoom")]
        public ActionResult<Room> CreateRoom(string roomName, string roomPassword)
        {
            object id;
            
            if(Sql.CreateRoom(roomName, roomPassword, out id))
            {
                return Ok(new Room(roomName, (int)id));
            }
            return BadRequest();
        }

        [HttpGet("JoinRoom")]
        public ActionResult<AccountRoom> JoinRoom(string roomName, string roomPassword, string username)
        {
            object userId;
            Sql.GetID(username, out userId);
            object roomId;
            if(Sql.JoinRoom(roomName, roomPassword, out roomId))
            {
                if(Sql.CreateAccountRoom((int)userId, (int)roomId))
                {
                    return Ok(new AccountRoom((int)userId, (int)roomId));
                }
            }
            return BadRequest();

        }

    }
}
