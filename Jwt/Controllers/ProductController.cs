using Jwt.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var listProduct = ProductConstants.Products;

            return Ok(listProduct);
        }
    }
}
