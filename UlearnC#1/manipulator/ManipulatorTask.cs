using System;
using NUnit.Framework;
using System.Drawing;

namespace Manipulation
{
    public static class ManipulatorTask
    {
        /// <summary>
        /// Возвращает массив углов (shoulder, elbow, wrist),
        /// необходимых для приведения эффектора манипулятора в точку x и y 
        /// с углом между последним суставом и горизонталью, равному angle (в радианах)
        /// См. чертеж manipulator.png!
        /// </summary>
        public static double[] MoveManipulatorTo(double x, double y, double angle)
        {
            double cosAngle = (Math.Abs(Math.Cos(angle)) < 1e-12) ? 0 : Math.Cos(angle);
            double sinAngle = (Math.Abs(Math.Sin(angle)) < 1e-12) ? 0 : Math.Sin(angle);
            double wristX = x - Manipulator.Palm * cosAngle;
            double wristY = y + Manipulator.Palm * sinAngle;

            double shoulderWrist = Math.Sqrt(wristX * wristX + wristY * wristY);
            double elbow = TriangleTask.GetABAngle(Manipulator.UpperArm,
                                        Manipulator.Forearm, shoulderWrist);
            if (elbow == double.NaN) return new[] { double.NaN, double.NaN, double.NaN };

            double shoulder = TriangleTask.GetABAngle(
                                                    shoulderWrist,
                                                    Manipulator.UpperArm,
                                                    Manipulator.Forearm) + Math.Atan2(wristY, wristX);
            double wrist = 2*Math.PI- angle - shoulder - elbow;
          
            return new[] { shoulder, elbow, wrist };
        }
    }

    [TestFixture]
    public class ManipulatorTask_Tests
    {
        [TestCase(180, 150, 0, new double[] { Math.PI / 2, Math.PI / 2, Math.PI })]
        [TestCase(120, 90, Math.PI / 2, new double[] { Math.PI / 2, Math.PI / 2, Math.PI / 2 })]
        [TestCase(180, 150, 0,new double[] { Math.PI/2, Math.PI / 2, Math.PI })]
        //[TestCase(1.0, 1.4142135623731, 1.0, 0.785398163397448d)]
        //[TestCase(-1.0d, 1.0d, 1.0d, double.NaN)]
        //[TestCase(1.0d, 1.0d, -1.0d, double.NaN)]

        [Test]
        public void TestMoveManipulatorTo(double x, double y, double angle, double[] arr)
        {
            Assert.AreEqual(ManipulatorTask.MoveManipulatorTo(x, y, angle), arr);
            //Assert.Fail("Write real tests here!");
        }
    }
}