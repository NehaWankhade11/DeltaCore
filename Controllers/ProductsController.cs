using DeltaCore.Models;
using DeltaCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace DeltaCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ProductsService _productsService = new ProductsService();

        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var products = _productsService.GetProducts();
            return Json(products);
        }
    }
}
