namespace MyQueue.Model
{
    public class SimpleArrayQueue<T>
    {
        private T[] array;
        private T Head => array[Count > 0 ? Count : 0];
        private T Tail => array[0];

        public int Count { get; private set; }

        public SimpleArrayQueue(int size)
        {
            array = new T[size];
            Count = -1;
        }

        public SimpleArrayQueue(int size, T data) : this(size)
        {
            Enqueue(data);
        }

        public void Enqueue(T data)
        {
            Count++;
            if (Count < array.Length)
            {
                T[] newArray = new T[array.Length];
                newArray[0] = data;
                for (int i = 1; i < array.Length; i++)
                {
                    newArray[i] = array[i - 1];
                }
                array = newArray;
                return;
            }
            Count--;
            throw new IndexOutOfRangeException();
            //для упрощения кода можно использовать канкатинацию из Linq, но скорей всего это будет работать медленней
            // T[] result = (new T[] {data}).Concat(array);
            // array = result.ToArray();
            // Count++;
        }

        public T Dequeue()
        {
            if (Count >= 0)
            {
                T result = Head;
                array[Count] = default(T);
                Count--;
                return result;
            }
            throw new IndexOutOfRangeException("Queue is empty");
        }

        public T Peek()
        {
            return Head;
        }
    }
}
