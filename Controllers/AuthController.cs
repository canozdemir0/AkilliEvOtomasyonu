using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using AkilliEvOtomasyonu.Models;
using AkilliEvOtomasyonu.Services;

namespace AkilliEvOtomasyonu.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly JwtService _jwt;

        public AuthController(IConfiguration config, JwtService jwt)
        {
            _config = config;
            _jwt = jwt;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            using (SqlConnection conn = new SqlConnection(
                _config.GetConnectionString("DefaultConnection")))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", request.Username);
                cmd.Parameters.AddWithValue("@p", request.Password);

                int result = (int)cmd.ExecuteScalar();

                if (result == 0)
                    return Unauthorized("Hatalı giriş");
            }

            var token = _jwt.GenerateToken(request.Username);

            return Ok(new { token });
        }
    }
}