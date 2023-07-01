using CQRS.Model;
using MediatR;

namespace CQRS.Query
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {
    }
}
