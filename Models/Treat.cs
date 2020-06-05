using System.Collections.Generic;
using System;

namespace PierresTreat.Models
{
  public class Recipe
  {
    public Treat()
    {
      this.Flavors = new List<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
   
    public string Instructions { get; set; }
    public string Ingredients { get; set; }
    public int Rating { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<RecipeTag> Flavors { get; }
  }
}