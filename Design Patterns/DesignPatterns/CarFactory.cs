using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class CarFactory:VehicleFactory
    {
        public override void Drive()
        {
            return new Car();
        }
    }
}
