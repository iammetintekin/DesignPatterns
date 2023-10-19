using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FunctionalDesignPattern
{
    // önce nesneyi ve ardından da classın kendisini gönderdik.
    public sealed class PersonBuilder:FunctionalBuilder<Person, PersonBuilder> 
    {
        public PersonBuilder CallByName(string Name)
        {
            // string parametre alan action delegate oluşturcaz 
            return Do(p => p.Name = Name);
        }
    }
}
