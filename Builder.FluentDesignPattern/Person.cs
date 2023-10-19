using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        // sondan başa doğru ilerliyoruz 
        // static
        public static Builder New { get; set; } = new Builder();
        public override string ToString()
        {
            return $"{nameof(Name)} : {Name} works as {nameof(Position)} : {Position} in  {nameof(Company)} :  {Company} ";
        }
    }
}
