using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIntegrity
{
    public static void Check()
    {
        Vector vector = new Vector(3, 4);
        Console.WriteLine(vector.ToString());

        vector.X = 0;
        vector.Y = -1;
        Console.WriteLine(vector.ToString());

        vector = new Vector(9, 40);
        Console.WriteLine(vector.ToString());

        Console.WriteLine(new Vector(0, 0).ToString());
    }

    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Length { get { return Math.Sqrt(X * X + Y * Y); } }

        public Vector(double x,double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
        }
    }

    class VectorTask
    {

    }
}
