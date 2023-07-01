using CQRS.Model;
using MediatR;

namespace CQRS.Command
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
