using SportingEquipmentApp.Interfaces;
namespace SportingEquipmentApp.Models
{
    public class Snowboard : Equipment, IHasMaxSpeed
{
    public double MaxSpeed { get; set; }

    public Snowboard(double price, double maxSpeed) : base(price)
    {
        MaxSpeed = maxSpeed;
    }

    public override double GetMaxSpeed()
    {
        return MaxSpeed;
    }
}
}