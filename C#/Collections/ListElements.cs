using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collections
{
    internal class ListElements
    {
        public void ListCollec()
        {
            List<int> number = new List<int>();
            number.Add(0);
            number.Add(1);
            number.Add(2);
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
            number.Append(10);
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("AFTER SORT:");
            number.Sort();
            number.Remove(0);
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("average: "+number.Average());
            Console.WriteLine("Sum: "+number.Sum());
        }

        public void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(198);
            stack.Push(842);
            stack.Pop();
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
        }
        public void Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            foreach (int num in queue)
            {
                Console.WriteLine(num);
            }
            queue.Dequeue();
            Console.WriteLine("-------------------------");
            foreach (int num in queue)
            {
                Console.WriteLine(num);
            }
        }
        public void Hash()
        {
            Dictionary<int,int> hash = new Dictionary<int,int>();
            hash.Add(1, 200);
            hash.Add(2, 854);
            foreach (int k in hash.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("-------------------------");
            foreach (int k in hash.Values)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("-------------------------");
            foreach (int k in hash.Keys)
            {
                Console.WriteLine(hash[k]);
            }
        }
        public void SortedList()
        {
            //SIMILAR TO HASH
            SortedList<int, int> hash = new SortedList<int, int>();
            hash.Add(1, 200);
            hash.Add(2, 854);
            foreach (int k in hash.Keys)
            {
                Console.WriteLine(k+": "+hash[k]);
            }
        }

        //NON-GENERICS
        public void ArrayListCollec()
        {
            ArrayList number = new ArrayList();
            number.Add(0);
            number.Add("hi");
            number.Add(28.96);
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
            //number.Append(10);
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("AFTER SORT:");
            
            number.Remove("hi");
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-------------------------");
            //Console.WriteLine("average: " + number.Average());
            //Console.WriteLine("Sum: " + number.Sum());
        }

        public void NonGenStack()
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push("hii");
            stack.Push(8.58);
            stack.Pop();
            foreach (var num in stack)
            {
                Console.WriteLine(num);
            }
        }
       public void NonGenQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue("hi");
            queue.Enqueue(300);
            queue.Enqueue(40.8745);
            foreach (var num in queue)
            {
                Console.WriteLine(num);
            }
            queue.Dequeue();
            Console.WriteLine("-------------------------");
            foreach (var num in queue)
            {
                Console.WriteLine(num);
            }
        }
        public void NonGenHash()
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "Raja");
            hash.Add("rajnesh", 854);
            foreach (var k in hash.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("-------------------------");
            foreach (var k in hash.Values)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("-------------------------");
            foreach (var k in hash.Keys)
            {
                Console.WriteLine(hash[k]);
            }
        }
        public void NonGenSortedList()
        {
            //SIMILAR TO HASH
            SortedList hash = new SortedList();
            hash.Add(0.1, 200);
            hash.Add(2, "raja");
            foreach (var k in hash.Keys)
            {
                Console.WriteLine(k + ": " + hash[k]);
            }
        }
    }
}
