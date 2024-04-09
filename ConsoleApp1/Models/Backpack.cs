namespace SportingEquipmentApp.Models
{
    public class Backpack : Equipment
{
    public Backpack(double price) : base(price)
    {
    }

    public override double GetMaxSpeed()
    {
        return 0;
    }
}
}