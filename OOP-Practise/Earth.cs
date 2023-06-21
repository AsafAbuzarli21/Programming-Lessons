using OOP_Practice;

namespace OOP_Practices
{
    //Inheritance
    public class Earth : Planet
    {
        //fields

        //properties
        public override int Temperature { get; set; } //0
        public override int OrbitalPeriod { get; set; }  //0
        public override int SolarRoundPeriod { get; set; }  //0
        public override double Weight { get; set; }  //0
        //public List<Satellite> Satellites { get; set; }
        public Satellite Satellite { get; set; } //= new Satellite();  //null

        public Earth()
        {

        }

        public Earth(bool isLifeExist) : base(isLifeExist)
        {

        }

        public Earth(bool isLifeExist, string waterType) : base(isLifeExist, waterType)
        {

        }

        public Earth(bool isLifeExist, string waterType, long distanceFromSolar) : base(isLifeExist, waterType, distanceFromSolar)
        {

        }

        ~Earth()
        {
            Console.WriteLine("Earth is destructed");
        }

        //methods
        public override string PlanetInfo()
        {
            string message = string.Empty;

            message = $" Planet Name : {nameof(Earth)} \n Weight : {Weight}\n Temperature : {Temperature}";

            return message;
        }
    }

}
