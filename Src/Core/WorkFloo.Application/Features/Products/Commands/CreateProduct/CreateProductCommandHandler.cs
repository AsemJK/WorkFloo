using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkFloo.Application.Interfaces;
using WorkFloo.Application.Interfaces.Repositories;
using WorkFloo.Application.Wrappers;
using WorkFloo.Domain.Products.Entities;

namespace WorkFloo.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, BaseResult<long>>
    {
        public async Task<BaseResult<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price, request.BarCode);

            await productRepository.AddAsync(product);
            await unitOfWork.SaveChangesAsync();

            return new BaseResult<long>(product.Id);
        }
    }
}
