using CQRS.DB;
using CQRS.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Query
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly ProductDBContext productDBContext;

        public GetProductByIdHandler(ProductDBContext productDBContext)
        {
            this.productDBContext = productDBContext;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await productDBContext.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}
