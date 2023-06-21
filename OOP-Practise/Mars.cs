namespace OOP_Practices
{
    public class Mars : Planet
    {
        //fields

        //properties
        public override int Temperature { get; set; }
        public override int OrbitalPeriod { get; set; }
        public override int SolarRoundPeriod { get; set; }
        public override double Weight { get; set; }

        public Mars()
        {

        }

        public Mars(bool isLifeExist) : base(isLifeExist)
        {

        }

        public Mars(bool isLifeExist, string waterType) : base(isLifeExist, waterType)
        {

        }

        public Mars(bool isLifeExist, string waterType, int distanceFromSolar) : base(isLifeExist, waterType, distanceFromSolar)
        {

        }

        ~Mars()
        {
            Console.WriteLine($"{nameof(Mars)} is destructed");
        }

        //methods
        public override string PlanetInfo()
        {
            string message = string.Empty;

            message = $@"
                Planet Name : {nameof(Mars)}\n
                Weight : {Weight}\n
                Temperature : {Temperature}";

            return message;
        }
    }

}
