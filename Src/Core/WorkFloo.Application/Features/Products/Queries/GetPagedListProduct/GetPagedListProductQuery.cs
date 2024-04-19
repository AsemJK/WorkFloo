using MediatR;
using WorkFloo.Application.Parameters;
using WorkFloo.Application.Wrappers;
using WorkFloo.Domain.Products.Dtos;

namespace WorkFloo.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PagenationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
