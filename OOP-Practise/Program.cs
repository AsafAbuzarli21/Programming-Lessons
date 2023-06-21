using OOP_Practices;

namespace OOP_Practice
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Earth earth = new Earth();
            earth.OrbitalPeriod = 24;
            earth.SolarRoundPeriod = 365;
            earth.Temperature = 25;
            earth.DistanceFromSolar = 3000000000;
            earth.IsLifeExist = true;
            earth.IsWaterExit = true;
            earth.WaterType = "Maye";

            earth.Satellite = new Satellite()
            {
                Age = 100000,
                Description = "The natural satellite of the earth",
                isNatural = true,
                Name = "Moon"
            };

            earth.Satellite.isNatural = true;

            Console.WriteLine(earth.PlanetInfo());


            //polymorphizm
            Planet pl = new Earth();

            Planet pl2 = new Mars();

        }
    }
}