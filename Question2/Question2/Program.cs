using System.Diagnostics;

namespace Question2 {
    class Program {
        static void Main(string[] args) {
            var list = new SinglyLinkedList<int>();
            list.Add(1);
            list.Add(20);
            list.Add(100);
            list.Add(220);
            list.Add(17);
            list.Add(19239437);
            list.Add(1);
            list.Add(20);
            list.Add(100);
            list.Add(220);
            list.Add(17);
            list.Add(19239437);
            list.Add(111);
            list.Add(2222);
            list.Add(1020);
            list.Add(278);
            list.Add(777);
            list.Add(7896);

            var five = list.FifthFromLast;
            Debugger.Break();
        }
    }
}
