using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        // GET api/<ChatController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {

            string json = "Not found";
            if ((id < Program.ms.GetCountMessages()) && (id >= 0))
            {
                json = JsonSerializer.Serialize(Program.ms.Get(id));
                return json.ToString();
            }
            return NotFound();
        }


        // POST api/<chatController>
        [HttpPost]
        public void Post([FromBody] message msg)
        {
            Program.ms.Add(msg);
            Console.WriteLine($"{msg.username}:  {msg.text} ({Program.ms.messages.Count})");
        }


    }
}
