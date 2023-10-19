using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.FunctionalDesignPattern
{
    public abstract class FunctionalBuilder<TSubject, TSelf> where TSelf : FunctionalBuilder<TSubject, TSelf> where TSubject : new()
    {
        //<parametre, geri dönüş>
        public List<Func<TSubject, TSubject>> Actions { get; set; } = new();
        // Action<T> person parametresi ala
        public TSelf AddAction(Action<TSubject> action)
        {
            // personu delegate e çevirdi.
            // actionlarda geri dönüş yok 
            // Person parametresi alıp person dönen bir fonksiyon delegesi oluşturduk.
            var ddd = delegate (TSubject n)
            {
                action(n);
                return n;
            };
            Actions.Add(ddd);
            return (TSelf)this;
        }
        public TSelf Do(Action<TSubject> person)
        {
            return AddAction(person);
        }
        //public TSelf CallByName(string Name)
        //{
        //    // string parametre alan action delegate oluşturcaz 
        //    return Do(p => p.Name = Name);
        //}
        public TSubject Build() => Actions.Aggregate(new TSubject(), (p, f) => f(p));
    }
}
