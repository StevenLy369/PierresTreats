using System.Collections.Generic;

namespace PierresTreat.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new List<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Word { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> Treats { get; set; }
  }
}