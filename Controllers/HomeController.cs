using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Controllers
{
    public class HomeController : Controller
    {
        private MySQLDatabaseContext _context;
        public HomeController(MySQLDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Student.ToList();
            return View(result);
            
        }

        public class PostTest
        {
            public string name { get; set; }

            public string content { get; set; }
        }
        [HttpPost]
        public IActionResult PostMessage([FromBody] PostTest data)
		{
            string connectionString = "server=<YourDatabaseHost>; database=<YourDatabaseName>; username=<Database_UserName>; password=<Database_UserPassWord>; oldguids=true; SslMode=None";
            MySqlConnection conn = new MySqlConnection(connectionString);

            string strSQL = @"INSERT INTO `messageboard2` (`MessageTime`, `Name`, `Content`)  VALUES (@MessageTime, @Name, @Content)";
            MySqlCommand cmd = new MySqlCommand(strSQL, conn);


            var date = DateTimeOffset.Now.AddHours(8).ToUnixTimeSeconds();

            conn.Open();
            cmd.Parameters.Add("@MessageTime", MySqlDbType.Int32).Value = date;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = data.name;
            cmd.Parameters.Add("@Content", MySqlDbType.VarChar).Value = data.content;
            cmd.ExecuteNonQuery();
            conn.Close();
            return Content("OK");
        }
        public IActionResult Messageboard()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
