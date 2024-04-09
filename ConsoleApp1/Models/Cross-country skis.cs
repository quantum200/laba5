using SportingEquipmentApp.Interfaces;
namespace SportingEquipmentApp.Models
{
    public class RunningSki : Equipment, IHasMaxSpeed
{
    public double MaxSpeed { get; set; }

    public RunningSki(double price, double maxSpeed) : base(price)
    {
        MaxSpeed = maxSpeed;
    }

    public override double GetMaxSpeed()
    {
        return MaxSpeed;
    }
}
}