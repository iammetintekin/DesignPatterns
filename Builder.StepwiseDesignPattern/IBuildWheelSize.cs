using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.StepwiseDesignPattern
{
    public interface IBuildWheelSize
    {
        IBuildCar BuildhWheelSize(int wheel);
    }
}
