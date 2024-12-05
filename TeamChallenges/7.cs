using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;

namespace InsecureLoginAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string connectionString = "Server=myServer;Database=myDB;User Id=admin;Password=admin123;";

        // 1. SQL Injection (Use parameterized queries)
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", model.Username);
                cmd.Parameters.AddWithValue("@Password", model.Password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return Ok("Login Successful");
                }
                else
                {
                    return Unauthorized("Login Failed");
                }
            }
        }

        // 2. Secure Password Storage (Hash passwords before storing)
        [HttpPost("storePassword")]
        public IActionResult StorePassword([FromBody] string password)
        {
            string hashedPassword = HashPassword(password);
            System.IO.File.WriteAllText("passwords.txt", hashedPassword); // Storing hashed password
            return Ok("Password stored securely");
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // 3. Proper Exception Handling (Avoid logging sensitive info)
        [HttpGet("testError")]
        public IActionResult TestError()
        {
            try
            {
                throw new Exception("Critical Error!"); // Unhandled exception
            }
            catch (Exception)
            {
                // Avoid logging sensitive exception details
                return BadRequest("An error occurred");
            }
        }

        // 4. Avoid Hardcoded Credentials (Use secure configuration)
        [HttpGet("adminAccess")]
        public IActionResult AdminAccess()
        {
            string adminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD"); // Use environment variable
            if (adminPassword == "admin123")
            {
                return Ok("Admin access granted");
            }
            return Unauthorized("Access denied");
        }

        // 5. Validate Input Handling (Prevent XSS)
        [HttpGet("greet")]
        public IActionResult GreetUser(string username)
        {
            string safeUsername = System.Net.WebUtility.HtmlEncode(username); // Encode input to prevent XSS
            return Content($"<h1>Hello, {safeUsername}!</h1>");
        }

        public class LoginModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
