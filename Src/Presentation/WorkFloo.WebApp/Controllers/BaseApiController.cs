﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorkFloo.WebApp.Infrastracture.Filters;

namespace WorkFloo.WebApp.Controllers
{
    [ApiController]
    [ApiResultFilter]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public abstract class BaseApiController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
