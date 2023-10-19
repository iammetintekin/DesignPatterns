using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// insanlar ile aralarındaki ilişkiyi gösteren bir yapı kuralım
    /// high level modules should not depend on low-level; 
    /// both should depend on abstractions
    /// 
    /// ,abstractions should not depend on details; 
    /// details should depend on abstractions
    /// 
    /// Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalı; ikisinin de soyutlanması,
    // Soyutlamanın detaylara değil; detayların soyutlamaya bağlı olması beklenmektedir.
    /// </summary>
    internal class DependencyInversion
    {
        public enum RelationShip
        {
            Parent,
            Child,
            Sibling
        }
        class Person
        {
            public string Name { get; set; }
        }
        // ilişkileri çözme formülü sadece  Relationships classında da yapılabilirdi
        // fakat interface e bağlandı
        interface IRelationshipBrowser
        {
            void AddRelationship(Person person, RelationShip relationShip, Person person2);
            IEnumerable<Person> Find(string name, RelationShip relation_ship);
            List<Tuple<Person, RelationShip, Person>> ListAll();
        }
        // işlemler burada yapılıyor
        class Relationships : IRelationshipBrowser // low level
        {
            List<Tuple<Person, RelationShip, Person>>  relationships = new List<Tuple<Person, RelationShip, Person>>();

            public Relationships()
            {
                // temp data
                var person = new Person { Name = "John" };
                var son = new Person { Name = "Micheal" };
                var sibling = new Person { Name = "Sara" };
                AddRelationship(son, RelationShip.Child, person);
                AddRelationship(sibling, RelationShip.Sibling, son);
            }
            public void AddRelationship(Person person, RelationShip relationShip, Person person2)
            { 
                relationships.Add(new Tuple<Person, RelationShip, Person>(person, relationShip, person2));
            }

            public IEnumerable<Person> Find(string name, RelationShip relation_ship)
            {
                return relationships
                    .Where(s=>
                        s.Item3.Name == name && 
                        s.Item2.Equals(relation_ship))
                    .Select(s=>s.Item1);
            }

            public List<Tuple<Person, RelationShip, Person>> ListAll()
            {
                return relationships;
            }
        }
        // düşük seviyeli class için de aynı şekilde Relationships sınıfı değil
        // IRelationshipBrowser işlemlerinin yapıldığı abstractan kullanılıyor.
        // ***** bu şekilde düşük ve yüksek seviyeli sınıflar birbirine direkt bağlı değil
        // soyutlama ile bağlı oluyor. *****
        class Research
        {
            public Research(IRelationshipBrowser browser)
            {
                // find childs
                foreach (var p in browser.Find("John", RelationShip.Child))
                {
                    Console.WriteLine("John' s child is :" +  p.Name);
                }
            }  
        }
        internal void Run()
        {
            var relationships = new Relationships();
            var a = new Research(relationships);
        }
        // c# tuple değişşkeni de kullanıldı.
    }
}
