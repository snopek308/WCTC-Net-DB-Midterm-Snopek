using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    class ProfessorMark : Driver
    {
        public ProfessorMark(RaceCar car) : base(car)
        {
            Name = "Professor Mark";
            SkillLevel = 8;
        }
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
