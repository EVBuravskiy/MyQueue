using MyQueue.Model;

namespace MyQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleListQueue<int> easyQueue = new SimpleListQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            Console.WriteLine(easyQueue.Count);
            Console.WriteLine(easyQueue.Deque());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Deque());
            Console.WriteLine(easyQueue.Deque());

            SimpleArrayQueue<int> simpleArrayQueue = new SimpleArrayQueue<int>(5);
            simpleArrayQueue.Enqueue(1);
            simpleArrayQueue.Enqueue(2);
            simpleArrayQueue.Enqueue(3);
            simpleArrayQueue.Enqueue(4);
            simpleArrayQueue.Enqueue(5);

            Console.WriteLine(simpleArrayQueue.Dequeue());
            Console.WriteLine(simpleArrayQueue.Dequeue());
            Console.WriteLine(simpleArrayQueue.Dequeue());
            Console.WriteLine(simpleArrayQueue.Dequeue());
            Console.WriteLine(simpleArrayQueue.Dequeue());
            //Console.WriteLine(simpleArrayQueue.Dequeue());

            SimpleLinkedQueue<int> simpleLinkedQueue = new SimpleLinkedQueue<int>();
            simpleLinkedQueue.Enqueue(1);
            simpleLinkedQueue.Enqueue(2);
            simpleLinkedQueue.Enqueue(3);

            Console.WriteLine(simpleLinkedQueue.Count);
            Console.WriteLine(simpleLinkedQueue.Deque());
            Console.WriteLine(simpleLinkedQueue.Deque());
            Console.WriteLine(simpleLinkedQueue.Deque());
            //Console.WriteLine(simpleLinkedQueue.Deque());
            SimpleListDeque<int> simpleListDeque = new SimpleListDeque<int>();
            simpleListDeque.PushBack(1);
            simpleListDeque.PushBack(2);
            simpleListDeque.PushFront(3);

            Console.WriteLine(simpleListDeque.PopFront());
            Console.WriteLine(simpleListDeque.PopBack());

            DoublyLinkedDeque<int> doublyLinkedDeque = new DoublyLinkedDeque<int>();
            doublyLinkedDeque.PushFront(1);
            doublyLinkedDeque.PushFront(2);
            doublyLinkedDeque.PushFront(3);
            doublyLinkedDeque.PushBack(3);
            doublyLinkedDeque.PushBack(2);
            doublyLinkedDeque.PushBack(1);

            Console.WriteLine(doublyLinkedDeque.PopFront());    //3
            Console.WriteLine(doublyLinkedDeque.PopBack());     //1
            Console.WriteLine(doublyLinkedDeque.PopFront());    //2
            Console.WriteLine(doublyLinkedDeque.PopBack());     //2
            Console.WriteLine(doublyLinkedDeque.PopFront());    //1

        }
    }
}