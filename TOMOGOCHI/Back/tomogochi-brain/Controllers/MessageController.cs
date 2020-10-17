using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tomogochi_brain.Controllers
{

    [EnableCors("CorsApi")]
    [Route("api/[controller]")]
    [ApiController]

    public class MessageController : ControllerBase
    {
        static MessagesClass ms = new MessagesClass();
        //// GET: api/<Message>
        //[HttpGet]
        //public string Get()
        //{
        //    string json = JsonSerializer.Serialize(ms.gmessages.ElementAt(0)); 
        //    return  json.ToString() ;
        //}

        // GET api/<Message>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string json = "not found";
            if ((id < ms.messages.Count) && (id>=0))
            {
                 json = JsonSerializer.Serialize(ms.messages.ElementAt(id));
            }
            return json.ToString();
        }

        // POST api/<Message>
        [HttpPost]
        public void Post([FromBody] message msg)
        {
            ms.Add(msg.username,msg.text);
        }

        //// PUT api/<Message>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MessageController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
