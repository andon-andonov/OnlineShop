using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public partial class ProductsController : ControllerBase
{
    private readonly IMediator mediator;

    public ProductsController(IMediator mediator)
    {
        this.mediator = mediator;
    }
}
