using MediatR;

namespace OnlineShop.Application.Products.Queries.GetAllProducts;

public record GetAllProductsQuery : IRequest<IEnumerable<ProductModel>>;
