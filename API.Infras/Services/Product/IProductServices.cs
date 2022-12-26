using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infras.Services.Product
{
   public interface IProductServices
    {
        Task<dynamic> GetAllProduct();
    }
}
