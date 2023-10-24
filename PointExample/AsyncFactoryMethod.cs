using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.FactoryMethod
{
    public class AsyncFactoryMethod
    {
        
    }
    public class Foo
    {
        public Foo()
        {
            // error: await Task.Delay(1000);
        }
        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
}
