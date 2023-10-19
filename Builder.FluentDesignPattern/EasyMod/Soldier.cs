using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern.EasyMod
{
    public class Soldier
    {
        public SoliderMoveBuilder Moves = new SoliderMoveBuilder();
    }
}
