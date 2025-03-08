using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Sales.Server.Model;

namespace Sales.Server.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _configuration;
        private string connectionString;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");

        }


        [HttpPost("login")]
        public IActionResult Login([FromBody] Users user)
        {           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT userId, userName, userAccessLevel FROM Users WHERE userEmail = @Email AND userPassword = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", user.user_Email);
                    cmd.Parameters.AddWithValue("@Password", user.user_Password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // User found
                        {
                            var loggedInUser = new
                            {
                                user_Id = reader["userId"],
                                user_Name = reader["userName"],
                                user_AccessLevel = reader["userAccessLevel"]
                            };

                            return Ok(loggedInUser);
                        }
                    }
                }
            }

            return Unauthorized("Invalid Email or Password");
        }

        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] Users user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Checking if the user already exists
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE userEmail = @Email";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Email", user.user_Email);
                    int userExists = (int)checkCmd.ExecuteScalar();
                    if (userExists > 0)
                    {
                        return BadRequest("User already exists.");
                    }
                }
                // Insert new user
                string insertQuery = "INSERT INTO Users (userName, userEmail, userPassword, userAccessLevel, userContact) VALUES (@Name, @Email, @Password, @AccessLevel, @Contact)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.user_Name);
                    cmd.Parameters.AddWithValue("@Email", user.user_Email);
                    cmd.Parameters.AddWithValue("@Password", user.user_Password); 
                    cmd.Parameters.AddWithValue("@AccessLevel",3);
                    cmd.Parameters.AddWithValue("@Contact", user.user_Contact);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return Ok(new { message = "User registered successfully." });
                    }
                }
            }

            return BadRequest("User registration failed.");
        }



        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Users user)
        {
            try
            {
               

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
