namespace MyQueue.Model
{
    public class SimpleListDeque<T>
    {
        private List<T> items;
        private T Head => items.Last();
        private T Tail => items.First();
        public int Count => items.Count();

        public SimpleListDeque()
        {
            items = new List<T>();
        }

        public SimpleListDeque(T data) : this()
        {
            items.Add(data);
        }

        public void PushBack(T item)
        {
            items.Insert(0, item);
        }

        public void PushFront(T item)
        {
            items.Add(item);
        }

        public T PopBack()
        {
            T item = Tail;
            items.Remove(item);
            return item;
        }

        public T PopFront()
        {
            T item = Head;
            items.Remove(item);
            return item;
        }

        public T PeekBack()
        {
            return Tail;
        }

        public T PeekFront()
        {
            return Head;
        }
    }
}
