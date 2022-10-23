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

        public static int[] GetNumbersDivisionByA(int number) //Cycles2
        {
            int j = 0;
            int k = 0;
            for ( int i = 1; i <= 1000; i++)
            {
                if (i  % number == 0)
                {
                    k = k + 1;
                }
            }
            int[] NumberArray = new int[k];
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    NumberArray[j] = i;
                    j = j + 1;
                }
            }
            return NumberArray;
        }

        public static int FindQuantityNumbersWhoseSquareIsLessThanA(int a)//Cyrcles3
        {
            int i = 1;
            int quantity = 0;
            for (i = 1; i * i < a; i++)
            {
                quantity = quantity + 1;
            }
            return quantity;
        }

        public static int FindTheNumberOfGreatestDivisorOfAValue(int a)//Cyrcles4
        {
            int divider = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    divider = i;
                }
            }
            return divider;
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
            int sum = 0;
            int firstvalue = 1;
            int secondvalue = 1;
            if (N < 0)
            {
                throw new ArgumentException("N<0");
            }
            else
                for (int i = 1; i <= N - 2; i++)
                {
                    sum = firstvalue + secondvalue;
                    firstvalue = secondvalue;
                    secondvalue = sum;
                }
            return sum;
        }

        public static int FindTheGreatestCommonDivisor(int a, int b)//Cycles7
        {
            int NOD;
            int temp ;
            while (a % b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            NOD = b;
            return NOD;
        }

        public static int FindNumber(int GiveNumber) //Cycles8
        {
            int left = 0;
            int right = GiveNumber;
            int N = (left + right) / 2;
            while (Math.Pow(N, 3) != GiveNumber)
            {
                if (Math.Pow(N, 3) > GiveNumber)
                {
                    right = N;
                }
                else
                {
                    left = N;
                }
                N = (left + right) / 2;
            }
            return N;
        }

        public static int FindTheAmountOfOddDigitsOfANumber(int a)//Cycles9
        {
            int quantity = 0;
            int C = a;
            while (true)
            {
                if (a == 0) break;
                C = a % 10;
                a /= 10;
                if (C % 2 != 0)
                {
                    quantity++;
                }
            }
            return quantity;
        }

        public static int FindMirrorNumberOfA(int number)//Cycles10
        {
            int result = 0;
            int digit;
            while (number % 10 > 0 || number / 10 > 0)
            {
                digit = number % 10;
                result = result * 10 + digit;
                number = number / 10;
            }
            return result;
        }

        public static int[] FindNSumEvenNumbersMoreThanOdd(int number1, int number2) //Cycles11
        {
            int i;
            int j;
            int amount = 0;
            int sum_even_numbers;
            int sum_odd_numbers;
            int remainder;

            for (i = number1; i <= number2; i++)
            {
                remainder = 0;
                sum_even_numbers = 0;
                sum_odd_numbers = 0;
                for (j = i; j > 0; j = j / 10)
                {
                    remainder = j % 10;
                    if ((remainder + 2) % 2 == 0)
                    {
                        sum_even_numbers = sum_even_numbers + remainder;
                    }
                    else
                    {
                        sum_odd_numbers = sum_odd_numbers + remainder;
                    }
                }
                if (sum_even_numbers > sum_odd_numbers)
                {
                    amount = amount + 1;
                }
            }

            i = 0;
            j = 0;
            int l = 0;
            int[] ArrayOfEvenNumbers = new int[amount];
            for (i = number1; i <= number2; i++)
            {
                remainder = 0;
                sum_even_numbers = 0;
                sum_odd_numbers = 0;
                for (j = i; j > 0; j = j / 10)
                {
                    remainder = j % 10;
                    if ((remainder + 2) % 2 == 0)
                    {
                        sum_even_numbers = sum_even_numbers + remainder;
                    }
                    else
                    {
                        sum_odd_numbers = sum_odd_numbers + remainder;
                    }
                }
                if (sum_even_numbers > sum_odd_numbers)
                {
                    ArrayOfEvenNumbers[l] = i;
                    l = l + 1;
                }
            }
            return ArrayOfEvenNumbers;
        }

        public static string WriteValue(int number1, int number2) //Cycles12
        {
            bool IsEqual = false;
            int i = number1;
            int j;
            int remainder_number1;
            int remainder_number2;
            string value;
            for (i = number1; i > 0; i = i / 10)
            {
                j = number2;
                remainder_number1 = i % 10;
                for (j = number2; j > 0; j = j / 10)
                {
                    remainder_number2 = j % 10;

                    if (remainder_number1 == remainder_number2)
                    {
                        IsEqual = true;
                        break;
                    }
                }
            }
            if (IsEqual)
            {
                value = "Да";
            }
            else
            {
                value = "Нет";
            }
            return value;
        } 
    }
}
