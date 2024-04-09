using SportingEquipmentApp.Interfaces;
namespace SportingEquipmentApp.Models
{
    public class Skis : Equipment, IHasMaxSpeed
{
    public double MaxSpeed { get; set; }

    public Skis(double price, double maxSpeed) : base(price)
    {
        MaxSpeed = maxSpeed;
    }

    public override double GetMaxSpeed()
    {
        return MaxSpeed;
    }
}
}