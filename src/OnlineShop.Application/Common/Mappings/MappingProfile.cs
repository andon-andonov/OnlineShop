using AutoMapper;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, Products.Queries.GetAllProducts.ProductModel>();
        CreateMap<Product, Products.Queries.GetSingleProduct.ProductModel>();
    }
}
