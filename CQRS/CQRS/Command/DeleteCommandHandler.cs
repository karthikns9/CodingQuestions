using CQRS.DB;
using CQRS.Model;
using MediatR;

namespace CQRS.Command
{
    public class DeleteCommandHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly ProductDBContext productDBContext;

        public DeleteCommandHandler(ProductDBContext productDBContext)
        {
            this.productDBContext = productDBContext;
        }
        public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = productDBContext.Products.Find(request.Id);

            if (product is null)
                return default;

            productDBContext.Products.Remove(product);
            await productDBContext.SaveChangesAsync();
            return product;
        }
    }
}
