using Mango.Services.ProductAPI.Models.DTO;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(Guid id);
        Task<ProductDto> CreateUpdateProduct(ProductDto name);
        Task<bool> DeleteProduct(Guid name);
    }
}
