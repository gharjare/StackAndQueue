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
        }
    }
    
}