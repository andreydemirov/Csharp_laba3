using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab3
{
    class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector()
        {
           
        }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public override string ToString()
        {
            return $"Vector( {x} , {y} , {z} )";
        }
    }
}
