using System;
using NUnit.Framework;
using Project.Test_;
using System.Runtime.CompilerServices;

namespace Project.Test.Testss

{
    public class BranchStructureTests
    {
        [TestCase(7, 1, 8)] //positivTestBS1
        [TestCase(3, 3, 9)]
        [TestCase(2, 8, -6)]
        public void SolveArithmeticExamplesByCondition(int a, int b, int expected)
        {
            int actual = BranchStructures.SolveArithmeticExamplesByCondition(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 1, "Точка принадлежит первой четверти ")] //positivTestBS2
        [TestCase(-3, 2, "Точка принадлежит второй четверти ")]
        [TestCase(-2, -8, "Точка принадлежит третьей четверти ")]
        [TestCase(4, -6, "Точка принадлежит четвертой четверти ")]
        public void FindQuadrantGivenPoint(int x, int y, string expected)
        {
            string actual = BranchStructures.FindQuadrantGivenPoint(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)] //negativTestBS2
        public void FindQuadrantGivenPoint_WhenXAndYIsEqualZero_ShouldThrowArgumentException(int x, int y)
        {
            Assert.Throws<ArgumentException>(() => BranchStructures.FindQuadrantGivenPoint(x, y));
        }

        [TestCase(new int[] { 2, 8, 5 }, new int[] { 2, 5, 8 })]//positivTestBS3
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        public void OutputABCInAscendingOrder(int[] array, int[] expected)
        {
            int[] actual = BranchStructures.OutputABCInAscendingOrder(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 8, 5, 7 })]//negativTestBS3
        public void OutputABCInAscendingOrder_WhenTheArrayLeng_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() => BranchStructures.OutputABCInAscendingOrder(array));
        }

        [TestCase(1, -2, -24, "X1=6;X2=-4")]//positivTestBS4
        [TestCase(3, -18, 27, "X1=3;X2=3")]
        public void DeriveAQuadraticEquation(int a, int b, int c, string expected)
        {
            string actual = BranchStructures.DeriveAQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)] //negativTestBS4
        public void DeriveAQuadraticEquation_WhenDIsNegative_ShouldThrowArgumentException(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => BranchStructures.DeriveAQuadraticEquation(a, b, c));
        }

        [TestCase(23, "двадцать три")] //positivTestBS5
        [TestCase(12, "двенадцать")]
        [TestCase(50, "пятдесять ")]
        public void OutputVerbalNotationOfTheNumber(int a, string expected)
        {
            string actual = BranchStructures.OutputVerbalNotationOfTheNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(124)] //negativTestB5
        public void OutputVerbalNotationOfTheNumber_WhenAIsOver99_ShouldThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => BranchStructures.OutputVerbalNotationOfTheNumber(a));
        }
    }
}