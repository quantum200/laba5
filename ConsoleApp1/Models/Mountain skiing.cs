using SportingEquipmentApp.Interfaces;
namespace SportingEquipmentApp.Models
{
    public class MountainSki : Equipment, IHasMaxSpeed
{
    public double MaxSpeed { get; set; }

    public MountainSki(double price, double maxSpeed) : base(price)
    {
        MaxSpeed = maxSpeed;
    }

    public override double GetMaxSpeed()
    {
        return MaxSpeed;
    }
}
}