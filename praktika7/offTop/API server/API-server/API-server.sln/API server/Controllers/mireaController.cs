using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mireaController : ControllerBase
    {
        // GET: api/<mireaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Андрюша", "поехал в Сирию" };
        }

        // GET api/<mireaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string str1 = "Поедешь в Сирию";
            if (id > 500){
                str1 = "Всё будет хорошо";
            }
            else
            if (id > 10000)
            {
                str1 = "Военный билет c доставкой на дом";
            }
            return str1;
        }

        // POST api/<mireaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<mireaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<mireaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
