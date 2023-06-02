using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresMarket.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat's description can't be empty!")]
    public string TreatDescription { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
  }
}