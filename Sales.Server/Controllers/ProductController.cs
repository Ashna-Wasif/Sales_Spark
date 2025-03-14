//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Data.SqlClient;
//using Sales.Server.Model;

//namespace Sales.Server.Controllers
//{
//    public class ProductController : Controller
//    {
//        private readonly IConfiguration _configuration;
//        private string connectionString;
//        DBConn dbconn;
//        public ProductController(IConfiguration configuration)
//        {
//            _configuration = configuration;
//            connectionString = _configuration.GetConnectionString("DefaultConnection");

//        }

//        [HttpGet("FetchProducts")]


//        // GET: ProductController
//        public ActionResult Index()
//        {
//            return View();
//        }

//        // GET: ProductController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: ProductController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ProductController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ProductController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: ProductController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ProductController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: ProductController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}



using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Sales.Server.Controllers
{
    [Route("api/[controller]")] // Add route for the controller
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DBConn _dbConn;

        public ProductController()
        {
            _dbConn = new DBConn();
        }

        [HttpGet("FetchProducts")]
        public IActionResult FetchProducts()
        {
            try
            {
                string query = "SELECT * FROM Products"; // Replace with your actual table name
                DataTable productsTable = _dbConn.FetchData(query);

                // Convert DataTable to a list of products
                var products = new List<object>();
                foreach (DataRow row in productsTable.Rows)
                {
                    products.Add(new
                    {
                        Id = row["prodID"],
                        Name = row["prodName"],
                        Category = row["prodCategory"],
                        Color = row["prodColor"],
                        Size = row["prodSize"],
                        Price = row["prodPrice"],
                        Material= row["prodMaterial"], 
                        Brand = row["prodBrand"],
                        Image = row["prodImage"]

                    });
                }

                return Ok(products); // Return the products as JSON
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}