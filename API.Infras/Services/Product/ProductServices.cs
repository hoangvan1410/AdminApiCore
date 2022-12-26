using API.Application.DTO;
using API.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infras.Services.Product
{
    public class ProductServices : IProductServices
    {
        private readonly TestDbContext _context;
        public ProductServices(TestDbContext context)
        {
            _context = context;

        }

        async Task<dynamic> IProductServices.GetAllProduct()
        {
            return await _context.Products.Select(x => new ProductDTO { ProductId = x.ProductId }).ToListAsync();
            //return null;
        }
    }
}
