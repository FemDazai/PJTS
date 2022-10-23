using System;
using NUnit.Framework;
using Project.Test_;
using System.Runtime.CompilerServices;

namespace Project.Test.Testss

{
    public class VariablesTests
    {
        [TestCase(1, 7, 9)] //positivTest2
        [TestCase(2, 3, 19)]

        public void SolveFormula(int a, int b, int expected)
        {
            int actual = Variables.SolveFormula(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)] //negativTest2
        public void SolveFormula_WhenAIsEqualB_ShouldThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveFormula(a, b));
        }

        [TestCase(2, 3, 5, 1)]  //positivTest4
        [TestCase(4, 3, 5, 0)]
        public void SolveTheEquation(int a, int b, int c, int expected)
        {
            int actual = Variables.SolveTheEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,2,1)] //negativTest4
        public void SolveTheEquatio_WhenAIsEqualZero_ShouldThrowArgumentException(int a, int b,int c)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveTheEquation(a, b,c));
        }

        [TestCase(1, 2, 3, 4, "y = 1x + 1")] //positivTest5
        public void GetEquationOfStraightLine(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Variables.GetEquationOfStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1, 2, 3)] //negativTest5
        public void GetEquationOfStraightLine_WhenX1IsEqualX2_ShouldThrowArgumentException(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<ArgumentException>(() => Variables.GetEquationOfStraightLine(x1,y1,x2,y2));
        }
    }
}