namespace OOP_Practices
{
    /// <summary>
    /// This is Planet class
    /// </summary>
    public abstract class Planet
    {
        //fields
        private bool _isWaterExist;
        private string _waterType;
        private long _distanceFromSolar;

        //properties
        //concrete
        public bool IsWaterExit
        {
            get
            {
                return _isWaterExist;
            }
            set
            {
                _isWaterExist = value;
            }
        }

        public long DistanceFromSolar
        {
            get { return _distanceFromSolar; }
            set { _distanceFromSolar = value; }
        }

        public string WaterType
        {
            get { return _waterType; }
            set { _waterType = value; }
        }

        //abstract
        public abstract int Temperature { get; set; }

        public abstract int OrbitalPeriod { get; set; }

        public abstract int SolarRoundPeriod { get; set; }

        public abstract double Weight { get; set; }

        public virtual bool IsLifeExist { get; set; } = false;


        //constructors
        public Planet()
        {

        }

        public Planet(bool isWaterExist) : this()
        {
            this._isWaterExist = isWaterExist;
        }

        public Planet(bool isWaterExist, string waterType)
        {
            this._isWaterExist = isWaterExist;
            this._waterType = waterType;
        }

        public Planet(bool isWaterExist, string waterType, long distanceFromSolar)
        {
            this._isWaterExist = isWaterExist;
            this._waterType = waterType;
            this._distanceFromSolar = distanceFromSolar;
        }

        //destructor
        ~Planet()
        {
            Console.WriteLine("Planet is destruct");
        }

        //method 
        //Method overriding
        public virtual double WeightDecrease()
        {
            return this.Weight - (this.Weight * 1) / 100;
        }

        public virtual double WeightDecrease(double weight)
        {
            return weight - (weight * 1) / 100;
        }

        public virtual double WeightDecrease(double weight, float percentage)
        {
            if (percentage < -100 && percentage > 100)
            {
                throw new Exception("Percentage must be between -100 and 100");
            }
            return weight - (weight * percentage) / 100;
        }

        public abstract string PlanetInfo();
    }

}
