namespace MyQueue.Model
{
    public class SimpleLinkedQueue<T>
    {
        private SimpleNode<T> head;
        private SimpleNode<T> tail;

        public int Count { get; set; }

        public SimpleLinkedQueue()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public SimpleLinkedQueue(T data) : this()
        {
            Enqueue(data);
        }

        public void Enqueue(T data)
        {
            if (tail == null)
            {
                head = tail = new SimpleNode<T>(data);
                Count++;
                return;
            }
            else
            {
                SimpleNode<T> newElement = new SimpleNode<T>(data);
                tail.Next = newElement;
                tail = newElement;
                Count++;
                return;
            }
        }

        public T Deque()
        {
            if (head == null)
            {
                throw new NullReferenceException("Queue is empty");
            }
            T result = head.Data;
            head = head.Next;
            Count--;
            return result;
        }

        public T Peek()
        {
            if (head == null)
            {
                throw new NullReferenceException("Queue is empty");
            }
            return head.Data;
        }
    }
}
