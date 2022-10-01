using System.Linq.Expressions;
using OnlineShop.Application.Common.Interfaces;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Application.Products.Queries.GetAllProducts;

public class ProductsSortedAscByNameSpec : ISpecification<Product>
{
    public Expression<Func<Product, bool>> Filter => x => true;
    public Expression<Func<Product, object>> SortBy=> x => x.Name;
}
