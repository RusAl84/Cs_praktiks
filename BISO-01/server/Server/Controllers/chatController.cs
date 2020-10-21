using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class chatController : ControllerBase
    {
        static MessagesClass ms = new MessagesClass();
        //// GET: api/<chatController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Sasha SIriya" };
        //}

        // GET api/<chatController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string json = "not found";
            if ((id < ms.messages.Count) && (id >= 0))
            {
                json = JsonSerializer.Serialize(ms.messages.ElementAt(id));
            }
            return json.ToString();
        }

        // POST api/<chatController>
        [HttpPost]
        public void Post([FromBody] message msg)
        {
            ms.Add(msg.username, msg.text);
            Console.WriteLine($"{msg.username}:  {msg.text} ({ms.messages.Count})");
        }

        //// PUT api/<chatController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<chatController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
