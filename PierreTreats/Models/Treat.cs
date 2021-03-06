using System.Collections.Generic;
using System;

namespace PierresTreat.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new List<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
   
    public string Ingredients { get; set; }
    
    public virtual ApplicationUser User { get; set; }
    public ICollection<FlavorTreat> Flavors { get; }
  }
}