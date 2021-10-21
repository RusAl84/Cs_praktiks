using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class getMessageController : ControllerBase
  {
    // GET api/<getMessageController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      if (id >=0 && id < Program.listOfMessages.Count)
      {
        return Program.listOfMessages[id].ToString();
      }
      else
      return "Not found";
    }
  }
}
