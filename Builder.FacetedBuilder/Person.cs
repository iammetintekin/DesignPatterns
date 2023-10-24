using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FacetedBuilder
{
    public class Person
    {
        public string Address, City, Postal;
        public string CompanyName, Position;
        public int AnnualIncome;
        public override string ToString()
        {
            return $"{nameof(CompanyName)} = {CompanyName} & {nameof(Position)} = {Position} & {nameof(AnnualIncome)} = {AnnualIncome}"+
               $"{nameof(Address)} = {Address} & {nameof(City)} = {City} & {nameof(Postal)} = {Postal}";
        }
    }
}
