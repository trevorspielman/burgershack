using System.ComponentModel.DataAnnotations;
using burger_shack.Assets.Enums;
using burger_shack.Interfaces;

namespace burger_shack.Models
{

  public class Side : IMenuItem
  {
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public double Price { get; set; }
    public int KCal { get; set; }
    [Required]
    public Size Size { get; set; }
    public string Ingredients { get; set; }

    public Side(string name, string desc, double price, int kcal, Size size, string ingredients)
    {
      Name = name;
      Description = desc;
      Price = price;
      KCal = kcal;
      Size = size;
      Ingredients = ingredients;
    }
  }

}