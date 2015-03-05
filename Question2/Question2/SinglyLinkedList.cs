namespace Question2 {
    public class SinglyLinkedList<T> {
        private Node<T> Root { get; set; }
        
        public Node<T> FifthFromLast {
            get {
                var curr = Root;

                if (curr == null) {
                    return null;
                }

                var fifth = curr;
                var count = 1;
                while (curr.Next != null) {
                    count++;
                    if (count > 5) {
                        fifth = fifth.Next;
                    }
                    curr = curr.Next;
                }

                return count >= 5 ? fifth : null;
            }
        }

        public void Add(T value) {
            var n = new Node<T> { Data = (T)value };
            if (Root == null) {
                Root = n;
            }
            else {
                var curr = Root;
                while (curr.Next != null) {
                    curr = curr.Next;
                }

                curr.Next = n;
            }
        }
    }
}
