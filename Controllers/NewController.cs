using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    //localHost9000/Input/Name
    public string SayHello(string name)
    {
        return$"Whats up {name}!";
    }
    
    //return$"This would be my return {var} "
}