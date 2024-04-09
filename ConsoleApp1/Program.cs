using SportingEquipmentApp.Models;
namespace SportingEquipmentApp
{
    class Program
{
    static void Main(string[] args)
    {
        Skis skis = new Skis(1000, 120);
        RunningSki runningSki = new RunningSki(800, 100);
        MountainSki mountainSki = new MountainSki(900, 110);
        Snowboard snowboard = new Snowboard(500, 60);
        Backpack backpack = new Backpack(500);
        Helmet helmet = new Helmet(750);

        Console.WriteLine($"Лижі: Price = {skis.Price} $, Max Speed = {skis.GetMaxSpeed()} km/h");
        Console.WriteLine($"Бігові лижі: Price = {runningSki.Price} $, Max Speed = {runningSki.GetMaxSpeed()} km/h");
        Console.WriteLine($"Гірські лижі: Price = {mountainSki.Price} $, Max Speed = {mountainSki.GetMaxSpeed()} km/h");
        Console.WriteLine($"Сноуборд: Price = {snowboard.Price} $, Max Speed = {snowboard.GetMaxSpeed()} km/h");
        Console.WriteLine($"Рюкзак: Price = {backpack.Price} $, Max Speed = {backpack.GetMaxSpeed()} km/h");
        Console.WriteLine($"Шолом: Price = {helmet.Price} $, Max Speed = {helmet.GetMaxSpeed()} km/h");
    }
}
}