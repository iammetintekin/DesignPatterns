using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FluentDesignPattern
{
    public class PersonCompanyBuilder<SELF> : PersonJobBuilder<PersonCompanyBuilder<SELF>> where SELF : PersonCompanyBuilder<SELF>
    {
        public SELF InCompany(string Company)
        {
            Person.Company = Company;
            return (SELF)this;
        }
    }
}
