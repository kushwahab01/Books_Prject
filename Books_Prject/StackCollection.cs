using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Prject
{
    class StackCollection
    {

        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);
            Console.WriteLine("count is "+stack.Count);
            Console.WriteLine("Before removing elements");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop();
            stack.Pop();
            Console.WriteLine("After removing element");
            
            Console.WriteLine("Last value is "+ stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( " Queue examples................." );

            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Enqueue(15);
            queue.Enqueue(16);
            Console.WriteLine("count is"+stack.Count);
            Console.WriteLine("Before removing element");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("After removing element");
            Console.WriteLine("Top value is " + queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" Using Hashtable.....................");

            Hashtable hashtable = new Hashtable();
            hashtable.Add(4, "Hello");
            hashtable.Add(2, "Everyone");
            hashtable.Add(1, "Hi");
            hashtable.Add(3, "all");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key+ " "+ item.Value);
            }

            Console.WriteLine("Using Sorted method....................");
            SortedList sorted = new SortedList();
            sorted.Add(1, "hello");
            sorted.Add(5, "Everyone");
            sorted.Add(6, " All");
            sorted.Add(7, "Hii");

            foreach (DictionaryEntry item in sorted)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
