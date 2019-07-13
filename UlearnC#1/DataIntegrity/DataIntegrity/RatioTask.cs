using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIntegrity
{
    class RatioTask
    {
        public static void Check(int num, int den)
        {
            var ratio = new Ratio(num, den);
            Console.WriteLine("{0}/{1} = {2}",
                ratio.Numerator, ratio.Denominator,
                ratio.Value.ToString(CultureInfo.InvariantCulture));
        }
    }

    public class Ratio
    {
        public Ratio(int num, int den)
        {
            Numerator = num;
            if (den <= 0)
                throw new ArgumentException();
            Denominator = den;
            Value = (double)Numerator / (double)Denominator;
        }

        public readonly int Numerator; //числитель
        public readonly int Denominator; //знаменатель
        public readonly double Value; //значение дроби Numerator / Denominator
    }
}
