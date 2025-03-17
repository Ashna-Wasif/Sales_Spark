using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.Server.Model;
using Sales.Server.Model.Entities;
using System;

namespace Sales.Server.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("FetchProducts")]
        public ActionResult<IEnumerable<Products>> FetchProducts()
        {
            try
            {
                var products = _context.Products.ToList(); // Fetch all products
                return Ok(products); // Return the data as JSON
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Failed to fetch products", details = ex.Message });
            }
        }
    }
}
