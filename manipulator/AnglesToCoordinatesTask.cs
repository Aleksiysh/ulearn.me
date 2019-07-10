using System;
using System.Drawing;
using NUnit.Framework;

namespace Manipulation
{
    public static class AnglesToCoordinatesTask
    {
        /// <summary>
        /// По значению углов суставов возвращает массив координат суставов
        /// в порядке new []{elbow, wrist, palmEnd}
        /// </summary>
        public static PointF[] GetJointPositions(double shoulder, double elbow, double wrist)
        {
            double alpha = shoulder;
            var elbowPos = new PointF(0 + (float)Manipulator.UpperArm * (float)Math.Cos(alpha),
                                    0 + (float)Manipulator.UpperArm * (float)Math.Sin(alpha));
            alpha = alpha + elbow - Math.PI;
            var wristPos = new PointF(elbowPos.X + (float)Manipulator.Forearm * (float)Math.Cos(alpha),
                                       elbowPos.Y + (float)Manipulator.UpperArm * (float)Math.Sin(alpha));
            alpha = alpha + wrist - Math.PI;
            var palmEndPos = new PointF(wristPos.X + (float)(Manipulator.Palm * (float)Math.Cos(alpha)),
                wristPos.Y + (float)Manipulator.Palm * (float)Math.Sin(alpha));
            return new PointF[]
            {
                elbowPos,
                wristPos,
                palmEndPos
            };
        }
    }
    [TestFixture]
    public class AnglesToCoordinatesTask_Tests
    {
        // Доработайте эти тесты!
        // С помощью строчки TestCase можно добавлять новые тестовые данные.
        // Аргументы TestCase превратятся в аргументы метода.
        [TestCase(Math.PI / 2, Math.PI / 2, Math.PI, Manipulator.Forearm + Manipulator.Palm, Manipulator.UpperArm)]
        [TestCase(Math.PI / 2, 0, 0, 0, 90.0f)]
        public void TestGetJointPositions(double shoulder, double elbow, double wrist, double palmEndX, double palmEndY)
        {
            var joints = AnglesToCoordinatesTask.GetJointPositions(shoulder, elbow, wrist);
            Assert.AreEqual(palmEndX, joints[2].X, 1e-5, "palm endX");
            Assert.AreEqual(palmEndY, joints[2].Y, 1e-5, "palm endY");
            if (Math.Abs(FullDistanse(joints) - (palmEndX + palmEndY)) > 1e-5)
                Assert.Fail("TODO: проверить, что расстояния между суставами равны длинам сегментов манипулятора!");
        }

        static double FullDistanse(PointF[] joints)
        {
            return Distanse(new PointF(0, 0), joints[0]) +
                     Distanse(joints[0], joints[1]) +
                     Distanse(joints[1], joints[2]);
        }

        static double Distanse(PointF p1, PointF p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

    }

}