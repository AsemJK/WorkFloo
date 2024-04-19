using MediatR;
using WorkFloo.Application.Wrappers;
using WorkFloo.Domain.Products.Dtos;

namespace WorkFloo.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
