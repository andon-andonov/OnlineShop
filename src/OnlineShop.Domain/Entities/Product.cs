using System;

namespace OnlineShop.Domain.Entities;

public class Product : EntityBase
{
	public string? Name { get; set; }
	public decimal Price { get; set; }
	public string? ImageUrl { get; set; }
	public string? Description { get; set; }
}
