using StackAndQueue1;

namespace StackAndQueue
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and queue program");
            Stack stack = new Stack();
            stack.Insert(70);
            stack.Insert(30);
            stack.Insert(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Display();
        }
    }
    
}