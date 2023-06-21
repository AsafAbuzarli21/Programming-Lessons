using OOP_Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Saturn : Planet, ISaturn
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public override int Temperature { get; set; }
        public override int OrbitalPeriod { get; set; }
        public override int SolarRoundPeriod { get; set; }
        public override double Weight { get; set; }
        int ISaturn.DistanceFromSolar { get; set; }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public override string PlanetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
