using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
        Task<ProductDto> CreateUpdateProduct(ProductDto product); 
        Task<bool> DeleteProduct(int productId);
    }
}
