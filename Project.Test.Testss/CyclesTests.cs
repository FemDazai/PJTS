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
        public void RaiseANumberToAPower_WhenTheNumberBNegative_ShouldThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Cycles.RaiseANumberToAPower(a, b));
        }

        [TestCase(200, new int[] {  200, 400,  600,  800, 1000 })] //positivTestC2
        public void GetNumbersDivisionByATest(int numberA, int[] expected)
        {
            int[] actual = Cycles.GetNumbersDivisionByA(numberA);
            Assert.AreEqual(actual, expected);
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
        public void TheSumOfNumbersInTheRangeIsDivisibleBy7_WhenAIsEqualB_ShouldThrowArgumentException(int a, int b)
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
        public void OutputTheNumberNOfTheFibonacciSeries_WhenNIsNegativeNumber_ShouldThrowArgumentException(int N)
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

        [TestCase(125, 5)]//positivTest8
        public void FindNumberTest(int GiveNumber, int expected)
        {
            int actual = Cycles.FindNumber(GiveNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(776, 2)] //positivTest9
        [TestCase(1578, 3)]

        public void FindTheAmountOfOddDigitsOfANumber(int a, int expected)
        {
            int actual = Cycles.FindTheAmountOfOddDigitsOfANumber(a);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(77698, 89677)] //positivTestC10
        [TestCase(2000, 2)]

        public void FindMirrorNumberOfA(int a, int expected)
        {
            int actual = Cycles.FindMirrorNumberOfA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(211, 222, new int[] { 212, 214, 216, 218, 220,221,222})] //positivTestC11
        public void FindNSumEvenNumbersMoreThanOddTest(int number1, int number2, int[] expected)
        {
            int[] actual = Cycles.FindNSumEvenNumbersMoreThanOdd(number1, number2);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(34724, 4029, "Да")]//positivTestC12
        [TestCase(2475, 3139, "Нет")]

        public void WriteValueTest(int number1, int number2, string expected)
        {
            string actual = Cycles.WriteValue(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}

