
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using burger_shack.Interfaces;

namespace burger_shack.Models
{

  public class Menu
  {
    public string Name { get; set; }
    public Dictionary<string, List<IMenuItem>> MenuItems { get; set; }


    public Menu(string name)
    {
      Name = name;
      MenuItems = new Dictionary<string, List<IMenuItem>>();
      MenuItems.Add("Burgers", new List<IMenuItem>());
      MenuItems.Add("Drinks", new List<IMenuItem>());
      MenuItems.Add("Sides", new List<IMenuItem>());

    }
  }


}