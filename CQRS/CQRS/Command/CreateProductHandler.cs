using CQRS.DB;
using CQRS.Model;
using MediatR;

namespace CQRS.Command
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly ProductDBContext productDBContext;

        public CreateProductHandler(ProductDBContext productDBContext)
        {
            this.productDBContext = productDBContext;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Active = request.Active,
                Category = request.Category,
                Description = request.Description,
                Price = request.Price,
            };

            productDBContext.Products.Add(product);
            await productDBContext.SaveChangesAsync();

            return product;
        }
    }
}
