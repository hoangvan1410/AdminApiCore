using API.Infras.Services.Product;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }


        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProduct()
        {
            try
            {

                var data = await _productServices.GetAllProduct();
                if (data.Count != 0)
                {
                    return Ok(data);
                }
                else
                {
                    return Ok("null");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
