using Project.Test_;
using NUnit.Framework;
namespace Project.Test.Tests
{
    public class VariableTests
    {
        [TestCase(1,7,9)]
        [TestCase(1,1,0)]
        [TestCase(1,2,4)]
        public void SolveFormulTest(int a, int b, int expected)
        {
            int actual = Variables.SolveFormula(a, b);
            Assert.AreEqual(expected, actual);

        }


    }
}