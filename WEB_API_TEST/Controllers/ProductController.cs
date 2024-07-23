using CoreLayer.Models;
using CoreLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IService<Product> _service;



        public ProductController(IService<Product> service)
        {

            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }
    }
}
