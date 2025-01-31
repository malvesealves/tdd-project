using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : ControllerBase
{
    private readonly ILogger<RestaurantController> _logger;

    public RestaurantController(ILogger<RestaurantController> logger) => _logger = logger;

}
