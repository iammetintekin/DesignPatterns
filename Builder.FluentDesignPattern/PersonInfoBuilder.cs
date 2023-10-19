using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern
{
    /// <summary>
    /// Gönderilen generic tipe göre 
    /// </summary>
    /// <typeparam name="SELF"></typeparam>
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string Name)
        {
            Person.Name = Name;
            return (SELF)this;
        }
    }
}
