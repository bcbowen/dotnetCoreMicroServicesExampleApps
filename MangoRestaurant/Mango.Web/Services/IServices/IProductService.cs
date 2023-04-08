using Mango.w.ProductAPI.Models.Dto;
using Mango.Web.Models.Dto;

namespace Mango.Web.Services.NewFolder
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);

        Task<T> CreateProductAsync<T>(ProductDto product);
        Task<T> UpdateProductAsync<T>(ProductDto product);
        Task<T> DeleteProductAsync<T>(int id);

    }
}
