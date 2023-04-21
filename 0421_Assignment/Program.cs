namespace _0421_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStructure.Stack<int> stack = new DataStructure.Stack<int>();
            stack.Push(1);
            //Console.WriteLine(stack.Pop());

            DataStructure.Queue<int> queue = new DataStructure.Queue<int>();
            for(int i = 0; i < 11;  i++)
            {
                queue.Enqueue(i);
            }
            queue.Dequeue();
            queue.Enqueue(11);
            for(int i = 0, size = queue.Count;i < size; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}