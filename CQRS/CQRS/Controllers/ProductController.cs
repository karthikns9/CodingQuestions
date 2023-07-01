using CQRS.Command;
using CQRS.Model;
using CQRS.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            var result = await mediator.Send(new GetAllProductsQuery());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await mediator.Send(new GetProductByIdQuery() { Id = id}));
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            return Ok(await mediator.Send(new CreateProductCommand()
            {
                Active = product.Active,
                Category = product.Category,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price
            }));
        }

        [HttpPut]
        public async Task<ActionResult<Product>> Put(Product product)
        {
            return Ok(await mediator.Send(new UpdateProductCommand() { 
                Id = product.Id,
                Active = product.Active,
                Category = product.Category,
                Description = product.Description,
                Name = product.Name,
                Price = product.Price
            }));
        }

        [HttpDelete]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            return Ok(await mediator.Send(new DeleteProductCommand()
            {
                Id = id
            }));
        }
    }
}