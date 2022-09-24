using AutoMapper;
using OnlineShop.Application.Products.Queries.GetAllProducts;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductModel>();
    }
}
