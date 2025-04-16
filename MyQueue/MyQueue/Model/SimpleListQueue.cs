namespace MyQueue.Model
{
    public class SimpleListQueue<T>
    {
        private List<T> items = new List<T>();

        public int Count { get { return items.Count; } }

        private T Head => items.Last();

        private T Tail => items.First();

        public SimpleListQueue()
        {

        }

        public SimpleListQueue(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data is null", nameof(data));
            }
            items.Add(data);
        }

        public void Enqueue(T data)
        {
            items.Insert(0, data);
        }

        public T Deque()
        {
            T item = Head;
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
