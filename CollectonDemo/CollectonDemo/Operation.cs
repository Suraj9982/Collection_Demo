using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectonDemo
{
    class Operation
    {
        public static void LinkedListAdd()
        {
            List<string> list = new List<string>();
            list.Add("suraj");
            list.Add("aman");
            list.Add("guddu");
            list.Add("sahil");
            list.Remove("sahil");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Stackadd()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        public static void QueueAdd()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(9);
            queue.Enqueue(8);
            queue.Enqueue(7);
            queue.Enqueue(6);
            queue.Dequeue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public static void Dosetdemo()
        {
            Console.WriteLine("\nIn dosetdemo");
            var set = new HashSet<string>();
            set.Add("ravi");
            set.Add("vijay");
            set.Add("ravi");
            set.Add("ajay");
            HashSet<string>.Enumerator enumrator = set.GetEnumerator();
            while (enumrator.MoveNext())
            {
                Console.WriteLine(enumrator.Current);
            }
        }
        public static void DodictionaryDemo()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(100, "suraj");
            dict.Add(101, "aman");
            dict.Add(102, "guddu");
            Console.WriteLine("access value using key(key=100):",dict[100]);
            Console.WriteLine("\nIterating dictionary");
            foreach(var item in dict)
            {
                Console.WriteLine("key ="+item.Key+"& value ="+item.Value) ;
            }
        }
    }
}
