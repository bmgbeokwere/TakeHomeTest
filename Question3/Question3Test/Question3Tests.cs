using System.Collections.Generic;
using Question3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Question3Test {
    [TestClass]
    public class Question3Tests {
        [TestMethod]
        public void TestGetNumbersFromFile() {
            var list = PrimeFactorParser.GetNumbersFromFile(@"C:\Projects\Cardlytics\Question3\TextFile1.txt");
            var list2 = new List<int> {12, 343, 3423, 78, 90, 2098, 2, 0, 128, 2378, 7};
            CollectionAssert.AreEqual(list, list2);
        }
        [TestMethod]
        public void TestGetPrimeNumbers() {
            var list = PrimeFactorParser.GetPrimeNumbers(274);
            var list2 = new List<int> {2, 137};
            CollectionAssert.AreEqual(list, list2);
        }
        [TestMethod]
        public void TestGetPrimeNumbersOfPrimeNumber() {
            var list = PrimeFactorParser.GetPrimeNumbers(1013);
            CollectionAssert.AreEqual(list, new List<int>());
        }
    }
}
