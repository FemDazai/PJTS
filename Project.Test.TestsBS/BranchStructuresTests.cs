
using System;
using NUnit.Framework;
using Project.Test_;
using System.Runtime.CompilerServices;
namespace Project.Test.TestsBS

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

        [TestCase(7, 1, "����� ����������� ������ �������� ")] //positivTestBS2
        [TestCase(-3, 2, "����� ����������� ������ �������� ")]
        [TestCase(-2, -8, "����� ����������� ������� �������� ")]
        [TestCase(4, -6, "����� ����������� ��������� �������� ")]
        public void FindQuadrantGivenPoint(int x, int y, string expected)
        {
            string actual = BranchStructures.FindQuadrantGivenPoint(x, y);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(0, 0)] //negativTestBS2
        public void FindQuadrantGivenPoint_WhenXAndYIsEqualZero_SholdThrowArgumentException(int x, int y)
        {
            Assert.Throws<ArgumentException>(() => BranchStructures.FindQuadrantGivenPoint(x, y));
        }
        [TestCase(23, "�������� ���")] //positivTestBS3
        [TestCase(12, "���������� ")]
        [TestCase(50, "��������� ")]
        public void OutputVerbalNotationOfTheNumber(int a, string expected)
        {
            string actual = BranchStructures.OutputVerbalNotationOfTheNumber(a);
            Assert.AreEqual(expected, actual);
        }
    }
}