// John Magpantay
// 10-25-2022
// Revamp Mini Ch 1, Hello world! API Version
// Peer review [Elizar Garcia] code works great! i entered my name and it showed up on the postman side with no problem. the controller layout on the cs side looks and works great. good job!!                              


using Microsoft.AspNetCore.Mvc;

namespace MagpantayJsayHello.Controllers;

[ApiController]
[Route("[controller]")]
public class sayHelloController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]
    // LocalHost/Input/Hello/{name}

   public string sayHello(string name)
   {
     return $" What up {name}";

   }


}
