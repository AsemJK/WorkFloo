using MediatR;
using WorkFloo.Application.Wrappers;

namespace WorkFloo.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
