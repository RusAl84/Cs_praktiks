using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace serverASPCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        public static List<MessangerLib.MessageClass> listOfMessages = new List<MessangerLib.MessageClass>()
        {
            new MessangerLib.MessageClass(){userName="System", messageText="System is runing...", timeStamp=DateTime.Now.ToString()}
        };


        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id >= 0 && id < listOfMessages.Count)
                return listOfMessages[id].ToString();
            else
                return "Not found";
        }

        // POST api/<MessageController>
        [HttpPost]
        public void Post([FromBody] MessangerLib.MessageClass mes)
        {
            Console.WriteLine(mes);
            listOfMessages.Add(mes);
        }
    }
}
