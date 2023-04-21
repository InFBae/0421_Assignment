namespace _0421_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DataStructure.Stack<int> stack = new DataStructure.Stack<int>();
            stack.Push(1);
            Console.WriteLine(stack.Pop());

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
            
            BracketCheckTest1();
            BracketCheckTest2();
            BracketCheckTest3();
            BracketCheckTest4();
            */
            Josephus(7, 3);

        }

        static bool BracketCheck(DataStructure.Stack<string> stack)
        {
            int leftCount = 0;
            int rightCount = 0;
            if (stack.Pop() != ")") return false;
            else rightCount++;
            while (stack.Count != 0)
            {
                string temp = stack.Pop();
                if(temp == ")")
                {
                    rightCount++;
                }else if (temp == "(")
                {
                    leftCount++;
                }
               
            }
            if(leftCount == rightCount) { return true; }
            else return false;
        }

        static void Josephus(int n, int k)
        {
            DataStructure.Queue<int> queue = new DataStructure.Queue<int>();
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }
            while(queue.Count != 0)
            {
                if(++count == k)
                {
                    Console.WriteLine(queue.Dequeue());
                    count = 0;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
        }

        static void BracketCheckTest1()
        {
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>();
            stack.Push("(");
            stack.Push(")");
            stack.Push("(");
            stack.Push(")");

            Console.WriteLine(BracketCheck(stack));
        }
        static void BracketCheckTest2()
        {
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>();
            stack.Push("(");
            stack.Push("(");
            stack.Push(")");
            stack.Push(")");

            Console.WriteLine(BracketCheck(stack));
        }
        static void BracketCheckTest3()
        {
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>();
            stack.Push("(");
            stack.Push(")");
            stack.Push(")");

            Console.WriteLine(BracketCheck(stack));
        }
        static void BracketCheckTest4()
        {
            DataStructure.Stack<string> stack = new DataStructure.Stack<string>();
            stack.Push(")");
            stack.Push("(");
            stack.Push(")");
            stack.Push("(");

            Console.WriteLine(BracketCheck(stack));
        }
    }
}