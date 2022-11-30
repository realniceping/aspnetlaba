using Microsoft.AspNetCore.Mvc;

namespace aspnetlab.Controllers;

public class User {
    public int Id {get;set;}
    public string Email {get;set;} =  string.Empty;
}

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase{

    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<User> Get(){
        return Enumerable.Range(1, 100).Select(index => new User{
            Id = Random.Shared.Next(0, 10000),
            Email = "Expample@example.com"
        }).ToList();
    }

}