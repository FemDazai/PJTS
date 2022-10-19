using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test_
{
    public static class Variables
    {
        public static int SolveFormula(int a, int b)
        {
            if (a == b)
            {
                throw new ArgumentException("a==b");
            }
            return (5 * a + b * b) / (b - a);
        }
        public static int SolveTheEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new ArgumentException("a==0");
            }
            return  (c - b) / a; 
           
            
        }
        public static string GetEquationOfStraightLine(int x1, int y1, int x2, int y2)
        {
            int result1 = (x1 - x2) / (y1 - y2);
            int result2 = y1 - result1 * x1;
            if (x1==x2)
            {
                throw new ArgumentException("x1==x2");
            } 
            return ($"y = {result1}x + {result2}");
        }
    }
}   
