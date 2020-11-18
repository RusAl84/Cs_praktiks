using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RegController : ControllerBase
  {
    // POST api/<RegController>
    [HttpPost]
    public int Post([FromBody] AuthData auth_data)
    {
      int int_token = Program.Sessions.registration(auth_data);
      Console.WriteLine(int_token);
      return int_token;
    }
  }
}
