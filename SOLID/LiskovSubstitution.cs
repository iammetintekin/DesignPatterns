using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Parent class behavior can and should be altered by the child class because that's essentially how encapsulation works.
    /// </summary>
    internal class LiskovSubstitution
    {
        /// <summary>
        /// We want to calculate area   
        /// </summary>
        int CalculateArea(Rectangle rectangle)
        {
            // sadece aynı işlemi yapıyorsa kullanılabilir.
            return rectangle.Height*rectangle.Width;
        }
        class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }
            public Rectangle()
            {
            }
            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public override string ToString()
            {
                return $"The {nameof(Width)} = {this.Width} & {nameof(Height)} = {this.Height}";
            }
        }
        class Square : Rectangle
        {
            //aynı işlemi yapan fonksiyonları farklı sınıfların davranışına göre
            //güncellemeyi sağlıyor.

            //virtual propları eziyoruz ve gerekli değerleri atıyoruz.
            //kare için width ve height değerlerine sadece height atadık.
            public override int Height { set => base.Width = base.Height = value; }
            public override int Width { set => base.Width = base.Height = value; }
        }
        internal void Run()
        {
            var rectangle = new Rectangle(4,2); // base tip

            var square = new Square();
            square.Height = 6;

            Console.WriteLine($"rectangle : {CalculateArea(rectangle)}" );
            Console.WriteLine($"square : {CalculateArea(square)}" );
        }
    }
}
