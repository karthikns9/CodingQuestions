using CQRS.Model;
using MediatR;

namespace CQRS.Query
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
