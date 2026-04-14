using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AkilliEvOtomasyonu.Controllers
{
    [ApiController]
    [Route("api/device")]
    [Authorize]
    public class DeviceController : ControllerBase
    {
        private readonly IConfiguration _config;

        public DeviceController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("action")]
        public IActionResult Action(string device, string action)
        {
            using (SqlConnection conn = new SqlConnection(
                _config.GetConnectionString("DefaultConnection")))
            {
                conn.Open();

                string query = "INSERT INTO Logs VALUES (@d,@a,@t)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@d", device);
                cmd.Parameters.AddWithValue("@a", action);
                cmd.Parameters.AddWithValue("@t", DateTime.Now);

                cmd.ExecuteNonQuery();
            }

            return Ok("Log eklendi");
        }
    }
}