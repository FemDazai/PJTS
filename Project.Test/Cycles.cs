using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test_  
{
    public static class Cycles
    {
        public static int RaiseANumberToAPower(int a, int b)//Cycles1
        {
            int result = 1;
            int i = 1;
            if (b < 0)
            {
                throw new ArgumentException("b<0");
            }
            else while (i <= b)
                {
                    i++;
                    result *= a;
                }
            return result;
        }



        public static int FindQuantityNumbersWhoseSquareIsLessThanA(int a)//Cyrcles3
        {
            int i = 1;
            int kol = 0;
            for (i = 1; i * i < a; i++)
            {
                kol = kol + 1;
            }
            return kol;
        }

        public static int FindTheNumberOfGreatestDivisorOfAValue(int a)//Cyrcles4
        {
            int nd = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    nd = i;
                }
            }
            return nd;
        }

        public static int TheSumOfNumbersInTheRangeIsDivisibleBy7(int a, int b)//Cyrcles5
        {
            int sum = 0;
            if (a == b)
            {
                throw new ArgumentException("a==b");
            }
            else if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            else if (b < a)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }

            return sum;
        }
        public static int OutputTheNumberNOfTheFibonacciSeries(int N)//Cycles6
        {
            int sumval = 0;
            int firstvalue = 1;
            int secondvalue = 1;
            if (N < 0)
            {
                throw new ArgumentException("N<0");
            }
            else
                for (int i = 1; i <= N - 2; i++)
                {
                    sumval = firstvalue + secondvalue;
                    firstvalue = secondvalue;
                    secondvalue = sumval;
                }
            return sumval;
        }

        public static int FindTheGreatestCommonDivisor(int a, int b)//Cycles7
        {
            int NOD;
            int ost;
            while (a % b != 0)
            {
                ost = a % b;
                a = b;
                b = ost;
            }
            NOD = b;
            return NOD;
        }
        public static int FindTheAmountOfOddDigitsOfANumber(int a)//Cycles9
        {
            int nc = 0;
            int C = a;
            while (true)
            {
                if (a == 0) break;
                C = a % 10;
                a /= 10;
                if (C % 2 != 0)
                {
                    nc++;
                }
            }
            return nc ;
        }
        public static int OutputTheNumberInReverseOrder(int number) //Cycles10
        {
            int l=1;
            int i = number;
            for ( i = number ; i >0; i=i/10)
            {
                l=i%10; 
                
            }
            return l;
        }
    }
}
