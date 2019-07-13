using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryPainting
{
    //Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor
    public static class SegmentExtensions
    {
        static readonly ConditionalWeakTable<Segment, ColorObj> colors = new ConditionalWeakTable<Segment, ColorObj>();

        public static void SetColor(this Segment segment, Color newcolor)
        {
            colors.GetOrCreateValue(segment).color = newcolor;
        }

        public static Color GetColor(this Segment segment)
        {
            return colors.GetOrCreateValue(segment).color;
        }

        class ColorObj
        {
            public Color color;
        }
    }
}
