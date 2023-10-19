using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern.EasyMod
{
    public class SoliderMoveBuilder : IMove
    {
        public void Print()
        {
            Console.WriteLine("Project End");
        }

        public IMove Run()
        {
            Console.WriteLine("Running");
            return this;
        }

        public IMove Shot()
        {
            Console.WriteLine("Shoted");
            return this;
        }

        public IMove Stop()
        {
            Console.WriteLine("Stopped");
            return this;
        }

        public IMove TurnLeft()
        {
            Console.WriteLine("Turning Left");
            return this;
        }

        public IMove TurnRight()
        {
            Console.WriteLine("Turning Right");
            return this;
        }
    }
}
