using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FacetedBuilder
{
    // its a facade.
    // not build person by itself
    public class PersonBuilder
    {
        // reference
        protected Person Person = new Person();
        //public PersonJobBuilder Works() => new PersonJobBuilder(Person);
        public PersonJobBuilder Works() 
        { 
            return new PersonJobBuilder(Person);
        }
        public PersonAddressBuilder Address() { return new PersonAddressBuilder(Person);}
        //Implicit operators are used to convert a data type to another data type without explicit user intervention
        public static implicit operator Person(PersonBuilder PersonBuilder) {
            return PersonBuilder.Person;
        }
    }

    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.Person = person;
        }
        public PersonJobBuilder WorksIn(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }
        public PersonJobBuilder Position(string position)
        {
            Person.Position = position;
            return this;
        }
        public PersonJobBuilder Salary(int salary)
        {
            Person.AnnualIncome = salary;
            return this;
        }
    }

    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.Person = person;
        }
        public PersonAddressBuilder Address(string address)
        {
            Person.Address = address;
            return this;
        }
        public PersonAddressBuilder City(string city)
        {
            Person.City = city;
            return this;
        }
        public PersonAddressBuilder PostalCode(int code)
        {
            Person.Postal = code.ToString();
            return this;
        }
    }
}
