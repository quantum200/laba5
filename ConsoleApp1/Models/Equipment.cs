using System;
namespace SportingEquipmentApp.Models
{
    public abstract class Equipment
{
    public double Price { get; set; }

    public Equipment(double price)
    {
        Price = price;
    }

    public abstract double GetMaxSpeed();
}
}