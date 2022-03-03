using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllProducts()
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id=id};
            return Ok(await mediator.Send(query));
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateProduct(CreateProductQuery product)
        {
            return Ok(await mediator.Send(product));
        }
    }
}
