using AutoMapper;
using MediatR;
using OnlineShop.Application.Common.Interfaces;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Products.Queries.GetAllProducts;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductModel>>
{
    private readonly IReadRepository<Product> productRepository;
    private readonly IMapper mapper;

    public GetAllProductsQueryHandler(IReadRepository<Product> productRepository, IMapper mapper)
    {
        this.productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<IEnumerable<ProductModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        ISpecification<Product> specification = new ProductsSortedAscByPriceSpec();
        IEnumerable<Product> productEntities = await this.productRepository.Get(specification);
        return mapper.Map<IEnumerable<ProductModel>>(productEntities);
    }
}
