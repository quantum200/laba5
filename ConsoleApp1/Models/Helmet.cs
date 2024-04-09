namespace SportingEquipmentApp.Models
{
    public class Helmet : Equipment
{
    public Helmet(double price) : base(price)
    {
    }

    public override double GetMaxSpeed()
    {
        return 0;
    }
}
}