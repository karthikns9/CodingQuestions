using CQRS.DB;
using CQRS.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Query
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly ProductDBContext _context;
        public GetAllProductsQueryHandler(ProductDBContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
