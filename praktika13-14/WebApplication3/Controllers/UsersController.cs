using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    UsersContext db;
    public UsersController(UsersContext context)
    {
      db = context;
      if (!db.Users.Any())
      {
        db.Users.Add(new User { Name = "Tom", Age = 26 });
        db.Users.Add(new User { Name = "Alice", Age = 31 });
        db.Users.Add(new User { Name = "Rusakov", Age = 35 });
        db.SaveChanges();
      }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> Get()
    {
      return await db.Users.ToListAsync();
    }

    // GET api/users/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> Get(int id)
    {
      User user = await db.Users.FirstOrDefaultAsync(x => x.Id == id);
      if (user == null)
        return NotFound();
      return new ObjectResult(user);
    }

    // POST api/users
    [HttpPost]
    public async Task<ActionResult<User>> Post(User user)
    {
      // обработка частных случаев валидации
      if (user.Age == 99)
        ModelState.AddModelError("Age", "Возраст не должен быть равен 99");

      if (user.Name == "admin")
      {
        ModelState.AddModelError("Name", "Недопустимое имя пользователя - admin");
      }
      // если есть лшибки - возвращаем ошибку 400
      if (!ModelState.IsValid)
        return BadRequest(ModelState);

      // если ошибок нет, сохраняем в базу данных
      db.Users.Add(user);
      await db.SaveChangesAsync();
      return Ok(user);
    }

    // PUT api/users/
    [HttpPut]
    public async Task<ActionResult<User>> Put(User user)
    {
      if (user == null)
      {
        return BadRequest();
      }
      if (!db.Users.Any(x => x.Id == user.Id))
      {
        return NotFound();
      }

      db.Update(user);
      await db.SaveChangesAsync();
      return Ok(user);
    }

    // DELETE api/users/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<User>> Delete(int id)
    {
      User user = db.Users.FirstOrDefault(x => x.Id == id);
      if (user == null)
      {
        return NotFound();
      }
      db.Users.Remove(user);
      await db.SaveChangesAsync();
      return Ok(user);
    }
  }
}
