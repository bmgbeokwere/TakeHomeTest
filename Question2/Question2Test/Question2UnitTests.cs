using Question2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Question2Test {
    [TestClass]
    public class Question2UnitTests {
        [TestMethod]
        public void TestIntFifthFromLast() {
            var list = new SinglyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);
            list.Add(17);
            list.Add(18);

            Assert.AreEqual(list.FifthFromLast.Data, 14);

            list = new SinglyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Assert.IsNull(list.FifthFromLast);

            list = new SinglyLinkedList<int>();
            Assert.IsNull(list.FifthFromLast);
        }
        [TestMethod]
        public void TestIntNullEmptyListFifthFromLast() {
            var list = new SinglyLinkedList<int>();
            Assert.IsNull(list.FifthFromLast);
        }
        [TestMethod]
        public void TestIntNullWithListFifthFromLast() {
            var list = new SinglyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Assert.IsNull(list.FifthFromLast);
        }
        [TestMethod]
        public void TestStringFifthFromLast() {
            var list = new SinglyLinkedList<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            list.Add("8");
            list.Add("9");
            list.Add("10");
            list.Add("11");
            list.Add("12");
            list.Add("13");
            list.Add("14");
            list.Add("15");
            list.Add("16");
            list.Add("17");
            list.Add("18");

            Assert.AreEqual(list.FifthFromLast.Data, "14");
        }
        [TestMethod]
        public void TestStringNullEmptyListFifthFromLast() {
            var list = new SinglyLinkedList<string>();
            Assert.IsNull(list.FifthFromLast);
        }
        [TestMethod]
        public void TestStringNullWithListFifthFromLast() {
            var list = new SinglyLinkedList<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            Assert.IsNull(list.FifthFromLast);
        }
    }
}
