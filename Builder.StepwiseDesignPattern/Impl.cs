using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.StepwiseDesignPattern
{
    public class Impl : IBuildCarType, IBuildWheelSize, IBuildCar
    {
        private Car car = new();

        public Car Build()
        {
            return car;
        }

        public IBuildWheelSize BuildCarType(CarType Type)
        {
            car.CarType = Type;
            return this; 
        }

        public IBuildCar BuildhWheelSize(int wheel)
        {
            car.WheelSize = wheel;
            return this;

        }
    }
}
