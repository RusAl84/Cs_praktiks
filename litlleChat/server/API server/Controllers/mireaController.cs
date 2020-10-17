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
            return new string[] { "Андрей", "вернись я всё прощу;)" };
        }

        // GET api/<mireaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string str1 = "Отправляйтесь в служить в Сирию";
            if ((id>500) && (id < 3000)){
                str1 = "Вы слишком нужны родине и оставайтесь дома;)";
            }
            if ((id > 3000) && (id < 10001))
            {
                str1 = "Приходите за военником;)";
            }
            if ((id > 10000) && (id < 1000000))
            {
                str1 = "Военник с доставкой на дом;)";
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
