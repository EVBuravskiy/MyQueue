namespace MyQueue.Model
{
    public class DoublyLinkedDeque<T>
    {
        public DoublyNode<T> Head { get; set; }
        public DoublyNode<T> Tail { get; set; }

        public int Count { get; set; }

        public DoublyLinkedDeque()
        {
            Head = Tail = null;
            Count = 0;
        }

        public DoublyLinkedDeque(T data)
        {
            DoublyNode<T> doublyNode = new DoublyNode<T>(data);
            Head = Tail = doublyNode;
            Count = 1;
        }

        public void PushFront(T data)
        {
            DoublyNode<T> doublyNode = new DoublyNode<T>(data);
            if (Head == null)
            {
                Head = Tail = doublyNode;
                Count++;
                return;
            }
            else
            {
                Head.Previous = doublyNode;
                doublyNode.Next = Head;
                Head = doublyNode;
                Count++;
                return;
            }
        }

        public void PushBack(T data)
        {
            DoublyNode<T> doublyNode = new DoublyNode<T>(data);
            if (Tail == null)
            {
                Head = Tail = doublyNode;
                Count++;
                return;
            }
            else
            {
                Tail.Next = doublyNode;
                doublyNode.Previous = Tail;
                Tail = doublyNode;
                Count++;
                return;
            }
        }

        public T PopFront()
        {
            if (Count > 0)
            {
                T data = Head.Data;
                Head = Head.Next;
                Head.Previous = null;
                Count--;
                return data;
            }
            throw new NullReferenceException("Deque is empty");
        }

        public T PopBack()
        {
            if (Count > 0)
            {
                T data = Tail.Data;
                Tail = Tail.Previous;
                Tail.Next = null;
                Count--;
                return data;
            }
            throw new NullReferenceException("Deque is empty");
        }

        public T PeekFront()
        {
            return Head.Data;
        }

        public T PeekBack()
        {
            return Tail.Data;
        }

    }
}
