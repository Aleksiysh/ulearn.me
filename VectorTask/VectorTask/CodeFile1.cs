using System;
namespace GeometryTasks
{
    class Programm
    {
        public static void main()
        {
            Vector vector = new Vector() { X = -1, Y = -1 };
            Segment segment = new Segment() { Begin = new Vector() { X = 0, Y = 0 }, End = new Vector() { X = 2, Y = 2 } };

            Geometry.IsVectorInSegment(vector, segment);

            Console.ReadKey();
        }
    }
}