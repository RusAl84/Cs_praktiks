using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class chatController : ControllerBase
    {
        static MessagesClass ms = new MessagesClass();

        // GET api/<chatController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            string json = "Not found";
            if ((id < ms.GetCountMessages()) && (id >= 0))
            {
                json = JsonSerializer.Serialize(ms.Get(id));
                return json.ToString();
            }
            return NotFound();
        }

        // POST api/<chatController>
        [HttpPost]
        public void Post([FromBody] message msg)
        {
            ms.Add(msg);
            Console.WriteLine($"{msg.username}:  {msg.text} ({ms.messages.Count})");
        }

    }
}
