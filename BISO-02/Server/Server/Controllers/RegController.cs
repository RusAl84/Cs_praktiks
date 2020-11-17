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
    //// GET: api/<RegController>
    //[HttpGet]
    //public IEnumerable<string> Get()
    //{
    //  return new string[] { "value1", "value2" };
    //}

    //// GET api/<RegController>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //  return "value";
    //}

    // POST api/<RegController>
    [HttpPost]
    public int Post([FromBody] AuthData auth_data)
    {
      int int_token = Program.Sessions.registration(auth_data);
      Console.WriteLine(int_token);
      return int_token;
    }

    //// PUT api/<RegController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<RegController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
  }
}
