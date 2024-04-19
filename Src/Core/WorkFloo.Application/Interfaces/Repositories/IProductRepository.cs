using System.Threading.Tasks;
using WorkFloo.Application.DTOs;
using WorkFloo.Domain.Products.Dtos;
using WorkFloo.Domain.Products.Entities;

namespace WorkFloo.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PagenationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
