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
            List<Player> playerlist = new List<Player>();
            for(int i = 0; i < 5; i++)
            {
                Random random = new Random();
                playerlist.Add(new Player(random.Next(0, 100)));
            }
            foreach(Player player in playerlist)
            {
                Console.Write(player.Speed + "\t");
            }
            Console.WriteLine();
            Queue<Player> players = new Queue<Player>();
            players = new Player().ActionQueue(playerlist);
            while(players.Count > 0)
            {
                Console.Write(players.Dequeue().Speed + "\t");
            }
            Console.WriteLine();
            /*
            Josephus(7, 3);
            */
        }

        static bool BracketCheck(DataStructure.Stack<string> stack)
        {
            int smallCount = 0;     // 소괄호 카운트
            int mediumCount = 0;    // 중괄호 카운트
            int largeCount = 0;     // 대괄호 카운트
            string temp = stack.Pop();
            if (temp == ")")
                smallCount++;
            else if (temp == "}")
                mediumCount++;
            else if (temp == "]")
                largeCount++;
            else return false;

            while (stack.Count != 0)
            {
                temp = stack.Pop();
                switch (temp)
                {
                    case ")":
                        smallCount++;
                        break;
                    case "}":
                        mediumCount++;
                        break;
                    case "]":
                        largeCount++;
                        break;
                    case "(":
                        smallCount--;
                        break;
                    case "{":
                        mediumCount--;
                        break;
                    case "[":
                        largeCount--;
                        break;
                }               
            }
            if(smallCount != 0 || mediumCount != 0 || largeCount != 0) { return false; }
            else return true;
        }

        class Player
        {
            private int speed;
            public int Speed { get { return speed; } }

            public Player() { this.speed = 0; }
            public Player(int speed) { this.speed = speed; }

            public Queue<Player> ActionQueue(List<Player> players)
            {
                Queue<Player> ActionQueue = new Queue<Player>();
                players.Sort((Player a, Player b) =>
                {
                    if (a.Speed > b.Speed) return 1;
                    else if (a.Speed < b.Speed) { return -1; }
                    return 0;
                });
                foreach(Player p in players)
                {
                    ActionQueue.Enqueue(p);
                }
                return ActionQueue;
            }
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