using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// your interfaces should be segregated so that nobody who implements your interface has to implement functions which they don't actually need.
    /// fonksiyon işine yarıyorsa o interface implemente edilmeli.
    /// </summary>
    internal class InterfaceSegregation
    {
        /// <summary>
        /// Bunu implemente eden 2 farklı yazıcı olabilir ama ikisinde de bu özellikler olmadığı için
        /// fonksiyonun içi boş duruyor. bu yüzden interface bölme prensibi uygulanacak.
        /// </summary>
        interface IMachine
        {
            void Copy();
            void Print();
            void Fax();
        }
        interface ICopy
        {
            void Copy();
        }
        interface IPrint
        {
            void Print();
        }
        interface IFax
        {
            void Fax();
        } 
        class NewPrinter : ICopy, IPrint, IFax
        {
            public void Copy()
            {
                Console.WriteLine("Copied");
            }

            public void Fax()
            {
                Console.WriteLine("Faxed"); 
            }

            public void Print()
            {
                Console.WriteLine("Printed");
            }
        }
        class OldFashionedPrinter : IPrint
        {
            public void Print()
            {
                Console.WriteLine("Printed");
            }
        }
    }
}
