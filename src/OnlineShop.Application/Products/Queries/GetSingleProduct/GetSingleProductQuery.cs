using MediatR;

namespace OnlineShop.Application.Products.Queries.GetSingleProduct;

public class GetSingleProductQuery : IRequest<ProductModel>
{
    public Guid Id { get; set; }
}
