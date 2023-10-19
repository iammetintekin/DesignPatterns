using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern.EasyMod
{
    public interface IMove
    {
        IMove Run();
        IMove TurnRight();
        IMove TurnLeft();
        IMove Stop();
        IMove Shot();
        void Print();
    }
}
