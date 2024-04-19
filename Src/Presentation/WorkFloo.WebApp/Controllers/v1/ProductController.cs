using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WorkFloo.Application.Features.Products.Commands.CreateProduct;
using WorkFloo.Application.Features.Products.Commands.DeleteProduct;
using WorkFloo.Application.Features.Products.Commands.UpdateProduct;
using WorkFloo.Application.Features.Products.Queries.GetPagedListProduct;
using WorkFloo.Application.Features.Products.Queries.GetProductById;
using WorkFloo.Application.Wrappers;
using WorkFloo.Domain.Products.Dtos;

namespace WorkFloo.WebApp.Controllers.v1
{
    [ApiVersion("1")]
    public class ProductController : BaseApiController
    {

        [HttpGet]
        public async Task<PagedResponse<ProductDto>> GetPagedListProduct([FromQuery] GetPagedListProductQuery model)
            => await Mediator.Send(model);

        [HttpGet]
        public async Task<BaseResult<ProductDto>> GetProductById([FromQuery] GetProductByIdQuery model)
            => await Mediator.Send(model);

        [HttpPost, Authorize]
        public async Task<BaseResult<long>> CreateProduct(CreateProductCommand model)
            => await Mediator.Send(model);

        [HttpPut, Authorize]
        public async Task<BaseResult> UpdateProduct(UpdateProductCommand model)
            => await Mediator.Send(model);

        [HttpDelete, Authorize]
        public async Task<BaseResult> DeleteProduct([FromQuery] DeleteProductCommand model)
            => await Mediator.Send(model);

    }
}