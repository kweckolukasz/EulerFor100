using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace UnitTestProjectEuler
{
    [TestClass]
    public class EulerTest
    {
        [TestMethod]
        public void E1_Multiples_of_3_and_5()
        {
            E1_Multiples_of_3_and_5 exercise = new E1_Multiples_of_3_and_5();
            exercise.Solution();
            Assert.AreEqual(233168, exercise.SumOfNumbers, null, "not yet..");
        }

        [TestMethod]
        public void E2_Even_Fibonacci_Numbers()
        {
            E2_Even_Fibonacci_Numbers exercise = new E2_Even_Fibonacci_Numbers();
            exercise.Solution();
            Assert.AreEqual(4613732, exercise.SumOfEvenValuedTerms);

        }
    }
}
