using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace offtop_serv.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class sendMessageController : ControllerBase
  {

    // POST api/<sendMessageController>
    [HttpPost]
    public void Post([FromBody] ClassLib.MessageClass mes)
    {
      Program.listOfMessages.Add(mes);
      Console.WriteLine(mes);
    }

  
  }
}
