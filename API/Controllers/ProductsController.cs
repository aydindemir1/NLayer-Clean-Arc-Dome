using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ProductService productService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productService.CalculateKdv(5));
        }
    }
}
