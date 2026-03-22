using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ChatApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatRoomController : ControllerBase
    {
        SQL Sql = new SQL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ChatApp;Integrated Security=True;Encrypt=True");
        [HttpPost("CreateAccount")]      


        public ActionResult<User> CreateAccount(string username, string password)
        {
            if(Sql.CreateAccount(username, password))
            {
                return Ok();
            }
            return BadRequest("bruh");
        }

        [HttpGet("Login")]
        public IActionResult Login(string username, string password)
        {
            DataTable data = Sql.Login(username, password);
            if (data.Rows.Count > 0)
            {
                return Ok(new User(username, (int)data.Rows[0][0]));
                
            }
            return BadRequest("bruh");
        }

    }
}
