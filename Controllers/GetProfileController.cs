namespace chatRestApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using ChatApp.Framework.DataAccess;
using ChatApp.Database.Models;

[ApiController]
[Route("[controller]")]
public class GetProfileController : ControllerBase
{
    private readonly ILogger<GetAllProfilesController> _logger;

    public GetProfileController(ILogger<GetAllProfilesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProfile")]
    public Profile? Get()
    {
        EntityProviderFactory providerFactory = new EntityProviderFactory();
        
        return providerFactory.Build<Profile>().Get(profile => profile.id == 1);
    }
}