namespace OOP_Practices
{
    public abstract class SolarSystem
    {
        //field
        private int _temperature;
        private int _orbitalPeriod;
        private double _weight;
        private bool _isLifeExist;

        //property
        //Encapsulation
        public int Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
            }
        }
        public int OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                if (_orbitalPeriod != value)
                {
                    _orbitalPeriod = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (_weight != value)
                {
                    _weight = value;
                }
            }
        }
        public bool IsLifeExist
        {
            get
            {
                return _isLifeExist;
            }
            set
            {
                _isLifeExist = value;
            }
        }

        public Planet Planet { get; set; }

        //public List<Planet> Planets { get; set; } = new List<Planet>();

        //constructor

        //destructor

        //method

        //abstract
    }
}
