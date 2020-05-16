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
            E1_MultiplesOf3And5 exercise = new E1_MultiplesOf3And5();
            exercise.Solution();
            Assert.AreEqual(233168, exercise.SumOfNumbers, null, "not yet..");
        }

        [TestMethod]
        public void E2_Even_Fibonacci_Numbers()
        {
            E2_EvenFibonacciNumbers exercise = new E2_EvenFibonacciNumbers();
            exercise.Solution();
            Assert.AreEqual(4613732, exercise.SumOfEvenValuedTerms);
        }
        [TestMethod]
        public void E3_LargestPrimeFactor()
        {
            E3_LargestPrimeFactor exercise = new E3_LargestPrimeFactor();
            exercise.Solution();
            Assert.AreEqual(6857, exercise.LargestPrimeFactor);
        }
    }
}
