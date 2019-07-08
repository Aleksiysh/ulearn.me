using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector vector2)
        {
            return Geometry.Add(this, vector2);
        }

        public bool Belongs(Segment segment)
        {
            return Geometry.IsVectorInSegment(this, segment);
        }
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            return new Vector() { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y };
        }

        public static double GetLength(Segment segment)
        {
            return Math.Sqrt((segment.End.X - segment.Begin.X) * (segment.End.X - segment.Begin.X) +
                (segment.End.Y - segment.Begin.Y) * (segment.End.Y - segment.Begin.Y));
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            if (segment.Begin.X == segment.End.X)
                return vector.X == segment.Begin.X &&
                        (segment.Begin.Y <= vector.Y && vector.Y <= segment.End.Y ||
                        segment.Begin.Y >= vector.Y && vector.Y >= segment.End.Y);

            if (segment.Begin.Y == segment.End.Y)
                return vector.Y == segment.Begin.Y &&
                         (segment.Begin.X <= vector.X && vector.X <= segment.End.X ||
                         segment.Begin.X >= vector.X && vector.X >= segment.End.X);

            double k = (vector.X - segment.End.X) / (segment.Begin.X - segment.End.X);
            return k == (vector.Y - segment.End.Y) / (segment.Begin.Y - segment.End.Y) &&
                        (segment.Begin.Y <= vector.Y && vector.Y <= segment.End.Y ||
                            segment.Begin.Y >= vector.Y && vector.Y >= segment.End.Y);
        }
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector vector)
        {
            return Geometry.IsVectorInSegment(vector,this);
        }      
    }
}
