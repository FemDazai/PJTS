using System;
using NUnit.Framework;
using Project.Test_;
using System.Runtime.CompilerServices;

namespace Project.Test.Testss
{
   public  class CyclesTests
    {
        [TestCase(2, 3, 8)] //positivTestC1
        [TestCase(-5, 3,-125)]
        [TestCase(7, 0, 1)]
        [TestCase(0, 5, 0)]


        public void RaiseANumberToAPower(int a, int b, int expected)
        {
            int actual = Cycles.RaiseANumberToAPower(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(2,-2)] //negativTestC1
        public void RaiseANumberToAPower_WhenTheNumberBNegative_SholdThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Cycles.RaiseANumberToAPower(a, b));
        }


        [TestCase(2, 1)] //positivTestC3
        [TestCase(25,4)]
        [TestCase(1,0)]
 
        public void FindQuantityNumbersWhoseSquareIsLessThanA(int a, int expected)
        {
            int actual = Cycles.FindQuantityNumbersWhoseSquareIsLessThanA(a);
            Assert.AreEqual(expected, actual);

        }


        [TestCase(33, 11)] //positivTestC4
        [TestCase(25, 5)]
        [TestCase(1, 0)]

        public void FindTheNumberOfGreatestDivisorOfAValue(int a, int expected)
        {
            int actual = Cycles.FindTheNumberOfGreatestDivisorOfAValue(a);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(2,9,7)] //positivTestC5
        [TestCase(30, 10,63 )]
        [TestCase(0, 2, 0)]

        public void TheSumOfNumbersInTheRangeIsDivisibleBy7(int a, int b, int expected)
        {
            int actual = Cycles.TheSumOfNumbersInTheRangeIsDivisibleBy7(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(2, 2)] //negativTestC5
        public void TheSumOfNumbersInTheRangeIsDivisibleBy7_WhenAIsEqualB_SholdThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Cycles.TheSumOfNumbersInTheRangeIsDivisibleBy7(a, b));
        }


        [TestCase(4,3)] //positivTestC6
        [TestCase(7,13)] 

        public void OutputTheNumberNOfTheFibonacciSeries(int N, int expected)
        {
            int actual = Cycles.OutputTheNumberNOfTheFibonacciSeries( N);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(-5)] //negativTestC6
        public void OutputTheNumberNOfTheFibonacciSeries_WhenNIsNegativeNumber_SholdThrowArgumentException(int N)
        {
            Assert.Throws<ArgumentException>(() => Cycles.OutputTheNumberNOfTheFibonacciSeries(N));
        }

        [TestCase(5, 15,5)] //positivTest7
        [TestCase(1,1,1)]

        public void FindTheGreatestCommonDivisor(int a, int b , int expected)
        {
            int actual = Cycles.FindTheGreatestCommonDivisor(a,b);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(776, 2)] //positivTest9
        [TestCase(1578 , 3)]

        public void FindTheAmountOfOddDigitsOfANumber(int a, int expected)
        {
            int actual = Cycles.FindTheAmountOfOddDigitsOfANumber(a);
            Assert.AreEqual(expected, actual);

        }
    }
}
