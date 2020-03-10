using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class SemiTruck : RaceCar
    {
        public SemiTruck()
        {
            Name = "Semi Truck";
            TopSpeed = 50;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} rumbles to life!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is sliding out of control!");
            base.Brake();
        }
    }
}
