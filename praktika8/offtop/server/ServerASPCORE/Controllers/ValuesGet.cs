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
  public class ValuesGet : ControllerBase
  {
    // GET: api/<ValuesGet>
    //[HttpGet]
    //public IEnumerable<string> Get()
    //{
    //  return new string[] { "value1", "value2" };
    //}

    // GET api/<ValuesGet>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return Program.listOfMessages.GetMessage(id);
    }

    //// POST api/<ValuesGet>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT api/<ValuesGet>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<ValuesGet>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
  }
}
