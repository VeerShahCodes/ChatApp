using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatRoomController : ControllerBase
    {
        SQL Sql = new SQL("Data Source=(localdb)\\ProjectModels;Initial Catalog=ChatDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        [HttpPost("CreateAccount")]      


        public ActionResult<User> CreateAccount(string username, string password)
        {
            object id;

            if (Sql.CreateAccount(username, password, out id))
            {
                return Ok(new User(username, (int)id));
            }
            return BadRequest("bruh");
        }

        [HttpGet("Login")]
        public IActionResult Login(string username, string password)
        {
            object id;
            Exception err;
            if(Sql.Login(username, password, out id, out err))
            {
                return Ok(new User(username, (int)id));
            }
            

            return BadRequest("bruh");
        }

    }
}
