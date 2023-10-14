using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Bir class geliştirilmeye açık olmalıdır.
    /// </summary>
    internal class OpenClosed
    {
        // interfacelere başvuruyoruz.
        interface ISpesification<T> 
        {
            // ürün özelliklerini karşılaştıracak
            bool IsEqual(T data);
        }
        class ColorSpec : ISpesification<Product>
        {
            private Color _color;
            public ColorSpec(Color color)
            {
                _color = color;
            }
            public bool IsEqual(Product data)
            {
                return _color == data.Color;
            }
        }
        class SizeSpec : ISpesification<Product>
        {
            private Size _size;
            public SizeSpec(Size size)
            {
                _size = size;
            }
            public bool IsEqual(Product data)
            {
                return _size == data.Size;
            }
        }
        class AndSpec : ISpesification<Product>
        {
            private Size _size;
            private Color _color;

            public AndSpec(Size size, Color color)
            {
                _size = size;
                _color = color;
            }
            public bool IsEqual(Product data)
            {
                return _size == data.Size && _color==data.Color;
            }
        }
        interface IFilter<T> // işlemler için kullanılacak
        {
            // gönderilen listeden ve istenilen filtreleme türüne göre ürünleri listeleyecek
            IEnumerable<T> Filter(IEnumerable<T> items, ISpesification<T> spec);
        }
       
        class BetterFilter : IFilter<Product>
        {
            public IEnumerable<Product> Filter(IEnumerable<Product> items,  ISpesification<Product> spec)
            {
                foreach (var item in items)
                {
                    if(spec.IsEqual(item))
                        yield return item;
                }
            } 
        }

        internal void Run2()
        {
            var products = new List<Product> 
            { 
                new Product("Apple", Color.Red, Size.S), 
                new Product("Tree", Color.Green, Size.XL),
                new Product("Shoes", Color.Blue, Size.L)
            };

            BetterFilter betterFilter = new BetterFilter();

            var color_filter = betterFilter.Filter(products,new ColorSpec(Color.Blue));
            foreach (var item in color_filter)
            {
                Console.WriteLine(item);
            }

            var size_filter = betterFilter.Filter(products, new SizeSpec(Size.S));
            foreach (var item in size_filter)
            {
                Console.WriteLine(item);
            }

            var and_filter = betterFilter.Filter(products, new AndSpec(Size.S, Color.Red));
            foreach (var item in and_filter)
            {
                Console.WriteLine(item);
            }
        }




        // Hatalı yöntem
        internal void Run()
        {
            // her tür için farklı filtrelemeler yapılmış.

            var products = new List<Product>
            {
                new Product("Apple", Color.Red, Size.S),
                new Product("Tree", Color.Green, Size.XL),
                new Product("Shoes", Color.Blue, Size.L)
            };
            // ürünlerde filtreleme işlemi yapmak istiyoruz diyelim.
            ProductFilter filter = new ProductFilter();
            var SizeFiltering = filter.FilterBySize(products, Size.S);
            foreach (var item in SizeFiltering)
            {
                Console.WriteLine(item);
            }
            var ColorFiltering = filter.FilterByColor(products, Color.Green);
            foreach (var item in ColorFiltering)
            {
                Console.WriteLine(item);
            }
            var BothFiltering =  filter.FilterByBoth(products, Size.L, Color.Blue);
            foreach (var item in BothFiltering)
            {
                Console.WriteLine(item);
            }
        }
        enum Color
        {
            Red,
            Green,
            Blue,
        }
        enum Size
        {
            S,
            M,
            L,
            XL
        }
        class Product
        {
            public string Name { get; set; }
            public Color Color { get; set; }
            public Size Size { get; set; }
            public Product(string name, Color color, Size size)
            {
                if (name == null) throw new ArgumentNullException(nameof(name));

                Name = name;
                Color = color;
                Size = size;
            }
            public override string ToString()
            {
                return $"The {Name} is {Color} and {Size}";
            }
        }
        // filtreleme classı
        class ProductFilter
        {
            // Not : List yield olarak dönemez. 
            public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
            {
                foreach (var item in products)
                {
                    if (item.Size == size)
                        yield return item;
                }
            }
            public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
            {
                foreach (var item in products)
                {
                    if (item.Color == color)
                        yield return item;
                }
            }
            public IEnumerable<Product> FilterByBoth(IEnumerable<Product> products, Size size, Color color)
            {
                foreach (var item in products)
                {
                    if (item.Size == size && item.Color == color)
                        yield return item;
                }
            }
        }
    } 
}
