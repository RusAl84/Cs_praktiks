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
  public class GetMessages : ControllerBase
  {

    // GET api/<GetMessages>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return Program.listOfMessages.GetMessage(id);
    }

  
  }
}
