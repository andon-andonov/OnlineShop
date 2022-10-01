using MediatR;

namespace OnlineShop.Application.Products.Queries.GetAllProducts;

public class GetAllProductsQuery : IRequest<IEnumerable<ProductModel>> {}
