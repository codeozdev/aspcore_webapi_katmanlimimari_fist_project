using CoreLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        private readonly IProductService _productService;



        public ProductController(IProductService productService)
        {

            _productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }
    }
}
