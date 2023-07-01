using CQRS.DB;
using CQRS.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Command
{
    public class UpdateProductHandler :  IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly ProductDBContext productDBContext;

        public UpdateProductHandler(ProductDBContext productDBContext)
        {
            this.productDBContext = productDBContext;
        }

        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = productDBContext.Products.Find(request.Id);

            if (product is null)
                return default;

            product.Name = request.Name;
            product.Description = request.Description;
            product.Category = request.Category;
            product.Price = request.Price;

            await productDBContext.SaveChangesAsync();
            return product;
        }
    }
}
