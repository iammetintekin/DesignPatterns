using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern
{ 
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAs(string Position)
        {
            Person.Position = Position;
            return (SELF)this;
        }
    }
}
