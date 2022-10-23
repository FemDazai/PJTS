using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test_
{
    public static class BranchStructures
    {
        public static int SolveArithmeticExamplesByCondition(int a, int b)//BS1
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }

        public static string FindQuadrantGivenPoint(int x, int y)//BS2
        {
            string result;
            if (x == 0 && y == 0)
            {
                throw new ArgumentException("x = 0 && y = 0");
            }
            else if (x > 0 && y > 0)
                result = ("Точка принадлежит первой четверти ");

            else if (x < 0 && y > 0)
            {
                result = ("Точка принадлежит второй четверти ");
            }
            else if (x < 0 && y < 0)
            {
                result = ("Точка принадлежит третьей четверти ");
            }
            else
            {
                result = ("Точка принадлежит четвертой четверти ");
            }
            return result;
        }

        public static int[] OutputABCInAscendingOrder(int[] array)//BS3
        {
            int[] arr = new int[3];
            for (int i = 0; i < 2; i++)
            {
                int IndexOfMin = i;
                for (int j = i + 1; j < 3; j++)
                {
                    if (array[j] < array[IndexOfMin])
                    {
                        IndexOfMin = j;
                    }
                }
                int temp = array[IndexOfMin];
                array[IndexOfMin] = array[i];
                array[i] = temp;
            }
            if (array.Length > 3)
            {
                throw new ArgumentException("array.Length > 3");
            }
            return array;
        }

        public static string DeriveAQuadraticEquation(int a, int b,int c)//BS4
        {
            double X1 = 0;
            double X2 = 0;
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                throw new ArgumentException ("Квадратное уравнение не имеет корней");

            }
            else if (D == 0)
            {
                X1 = -b / (2 * a);
                X2 = X1;
            }
            else
            {
                X1 = (-b + Math.Sqrt(D)) / (2 * a);
                X2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            return ($"X1={X1};X2={X2}");
        }

        public static string OutputVerbalNotationOfTheNumber(int a)//BS5
        {
            string result = "";
            string tens = "";
            string units = "";
            int cons = a / 10;
            if (cons == 1)
            {
                switch (a % 10)
                {
                    case 0:
                        tens = ("десять");
                        units = "";
                        break;
                    case 1:
                        tens = ("одинадцать");
                        units = "";
                        break;
                    case 2:
                        tens = ("двенадцать");
                        units = "";
                        break;
                    case 3:
                        tens = ("тринадцать");
                        units = "";
                        break;
                    case 4:
                        tens = ("четырнадцать");
                        units = "";
                        break;
                    case 5:
                        tens = ("пятнадцать");
                        units = "";
                        break;
                    case 6:
                        tens = ("шеснадцать");
                        units = "";
                        break;
                    case 7:
                        tens = ("семнадцать");
                        units = "";
                        break;
                    case 8:
                        tens = ("восемнадцать");
                        units = "";
                        break;
                    case 9:
                        tens = ("девятнадцать");
                        units = "";
                        break;
                }
            }
            else
            {
                switch (cons)
                {
                    case 2:
                        tens = ("двадцать ");
                        break;
                    case 3:
                        tens = ("тридцать ");
                        break;
                    case 4:
                        tens = ("сорок ");
                        break;
                    case 5:
                        tens = ("пятдесять ");
                        break;
                    case 6:
                        tens = ("шестьдесят ");
                        break;
                    case 7:
                        tens = ("семьдесят ");
                        break;
                    case 8:
                        tens = ("восемьдесят ");
                        break;
                    case 9:
                        tens = ("девяносто ");
                        break;
                    default:
                        break;

                }
                switch (a % 10)
                {
                    case 1:
                        units = ("один");
                        break;
                    case 2:
                        units = ("два");
                        break;
                    case 3:
                        units = ("три");
                        break;
                    case 4:
                        units = ("четыре");
                        break;
                    case 5:
                        units = ("пять");
                        break;
                    case 6:
                        units = ("шесть");
                        break;
                    case 7:
                        units = ("семь");
                        break;
                    case 8:
                        units = ("восемь");
                        break;
                    case 9:
                        units = ("девять");
                        break;
                }
            }
            result = tens + units;
            if (a > 99)
            {
                throw new ArgumentException("a>99");
            }
            return result;
        }
       
    }        
}
