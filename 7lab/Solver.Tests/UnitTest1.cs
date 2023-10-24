using Xunit.Sdk;
using Solver;
namespace Solver.Tests
{
    [TestClass]
    public class UnitTests
    {
       
        public void GeneralTest(double a, double b, double c, params double[] expectedResult)
        {
            var result = QuadraticSolver.Solve(a,b,c);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
        [TestMethod]
        public void UsualTest()
        {
            GeneralTest(1,5,4,-1,-4);
        }
        [TestMethod]
        public void UsualTest2()
        {
            GeneralTest(1, -3, 2, 2, 1);
        }
        [TestMethod]
        public void UsualTest3()
        {
            GeneralTest(-1, 7, -10, 2, 5);
        }
        [TestMethod]
        public void NegativeDisctiminant()
        {
            GeneralTest(1,1,1);
        }
        [TestMethod]
        public void NegativeDisctiminant2()
        {
            GeneralTest(2, 2, 2);
        }
        [TestMethod]
        public void NegativeDisctiminant3()
        {
            GeneralTest(3, 4, 2);
        }
        [TestMethod]
        public void ZeroDisciminant()
        {
            GeneralTest(1, 2, 1, -1);
        }

        [TestMethod]
        public void ZeroDisciminant2()
        {
            GeneralTest(1, -6, 9, 3);
        }

        [TestMethod]
        public void ZeroDisciminant3()
        {
            GeneralTest(1, -4, 4, 2);
        }
    }
}