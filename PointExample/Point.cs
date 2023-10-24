using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointExample
{
    public class Point
    {
        private double x,y;
        ///// <summary>
        ///// initializes a point from either cartesian or polar
        ///// </summary>
        ///// <param name="x">x if cartesian, rho if polar</param>
        ///// <param name="y"></param>
        ///// <param name="system"></param>
        ///// <exception cref="ArgumentOutOfRangeException"></exception>
        //public Point(double x, double y, CoordinateSystem system = CoordinateSystem.Cartesian)
        //{
        //    switch (system)
        //    {
        //        case CoordinateSystem.Cartesian:
        //            this.x = x;
        //            this.y = y;
        //            break;
        //        case CoordinateSystem.Polar:
        //            this.x = x* Math.Cos(y);
        //            this.y = x* Math.Sin(y);
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(nameof(system));
        //    }

        //}
        /// <summary>
        /// Factory method design pattern : Hangi parametrenin hangisine ait olduğu daha anlaşılır.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns> 
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static Point Origin => new Point(0,0);
        public override string ToString()
        {
            return $"x : {x} & y : {y}";
        }
        // aynı namespace içine koyarak constructırımızı koruyabiliriz.
        public static PointFactory2 Factory2 = new PointFactory2();
        public class PointFactory2
        {
            public Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
            public Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
    /// <summary>
    /// constructor private olduğunda bunu kullanabilriz.
    /// </summary>
    
}
