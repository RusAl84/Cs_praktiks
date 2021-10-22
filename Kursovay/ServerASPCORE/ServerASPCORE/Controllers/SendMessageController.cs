using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerASPCORE.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SendMessageController : ControllerBase
  {

    // POST api/<SendMessageController>
    [HttpPost]
    public void Post([FromBody] MessangerLib.MesaageClass mes)
    {
      Program.listOfMessages.Add(mes);
      Console.WriteLine(mes);
      //! проверки
    }

  }
}
