using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern
{
    /// <summary>
    /// Person nesnesi oluşturur.
    /// </summary>
    public abstract class PersonBuilder
    {
        public Person Person = new Person();
        public Person Build()
        {
            return Person;
        }
    }
}
