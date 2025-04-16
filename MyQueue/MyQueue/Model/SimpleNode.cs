namespace MyQueue.Model
{
    public class SimpleNode<T>
    {
        public T Data { get; set; }
        public SimpleNode<T> Next { get; set; }

        public SimpleNode()
        {
            Data = default(T);
            Next = null;
        }

        public SimpleNode(T data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
