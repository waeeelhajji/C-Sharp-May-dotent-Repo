#pragma warning disable CS8618

namespace OneToManyDemo.Models;


public class MyViewModel
{
    public Maker Maker { get; set; }
    public List<Maker> AllMakers { get; set; }

    public Vehicle Vehicle { get; set; }
    public List<Vehicle>  AllVehicles { get; set; }

}