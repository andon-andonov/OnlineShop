using AutoMapper;
using MediatR;
using OnlineShop.Application.Common.Interfaces;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Products.Queries.GetSingleProduct;

public class GetSingleProductQueryHandler : IRequestHandler<GetSingleProductQuery, ProductModel>
{
    private readonly IReadRepository<Product> productRepository;
    private readonly IMapper mapper;

    public GetSingleProductQueryHandler(IReadRepository<Product> productRepository, IMapper mapper)
    {
        this.productRepository = productRepository;
        this.mapper = mapper;
    }

    public async Task<ProductModel> Handle(GetSingleProductQuery request, CancellationToken cancellationToken)
    {
        Product productEntity = await this.productRepository.Get(request.Id);
        return mapper.Map<ProductModel>(productEntity);
    }
}
