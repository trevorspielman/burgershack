using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burger_shack.Assets.Enums;
using burger_shack.Models;
using Microsoft.AspNetCore.Mvc;

namespace burger_shack.Controllers
{
  [Route("api/[controller]")]
  public class MenuController : Controller
  {
    public Menu menu {get; set;}

    public MenuController()
    {
      menu = new Menu("My Menu");
      menu.MenuItems["Burgers"].Add(new Burger("The Aloha Burger", "Tasty meat with Pineapple (taste the island)", 11.99, 2200, "stuff n things with pineapple of course"));
      menu.MenuItems["Burgers"].Add(new Burger("The BBQ Brittany", "tasty meat with BBQ Sauce.... its a secret", 15.74, 2100, "stuff n thing with BBQ sauce"));
      menu.MenuItems["Burgers"].Add(new Burger("The Veg", "dont worry its gross", 2.99, 15, "lettuce mostly"));
      menu.MenuItems["Drinks"].Add(new Drink ("Coca Cola", "Liquid Sugar", 5.99, 2000000, Size.Biggie, "sugar mostly... maybe some cocaine"));
      menu.MenuItems["Sides"].Add(new Side ("Fries", "Salty Starch Sticks", 4.99, 3400000, Size.Biggie, "salt mostly... maybe some potato..."));
    }

    // GET api/values
    [HttpGet]
    public dynamic Get()
    {
      return menu.MenuItems;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      //you have actual work to do here
      //boards.findById(id)
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
