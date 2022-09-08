using System;
using System.Collections.Generic;

namespace PracticeCollect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create list of strings
            var names = new List<string>();
            names.Add("Seema");
            names.Add("Anusha");
            names.Add("Pavani");
            names.Add("Irfan");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

/*--------------------------------------------HASHSET----------------------------*/
            // Create a set of strings  
            var names1 = new HashSet<string>();
            names1.Add("Seema");
            names1.Add("Anusha");
            names1.Add("Raju");
            names1.Add("Ali");
            names1.Add("Ravi");//will not be added  

            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            /*-------------------------------------STACK--------------------------*/
            Stack<string> names2 = new Stack<string>();
            names2.Push("Seema");
            names2.Push("Punit");
            names2.Push("Janhsi");
            names2.Push("Ravi");
            names2.Push("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names2.Peek());
            Console.WriteLine("Pop: " + names2.Pop());
            Console.WriteLine("After Pop, Peek element: " + names2.Peek());

            /*---------------------------------QUEUE---------------------------------------*/
            Queue<string> names3 = new Queue<string>();
            names3.Enqueue("Sonoo");
            names3.Enqueue("Peter");
            names3.Enqueue("James");
            names3.Enqueue("Ratan");
            names3.Enqueue("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names3.Peek());
            Console.WriteLine("Dequeue: " + names3.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names3.Peek());

            /*------------------------------------------------LINKED LIST----------------------------------*/
            // Create a list of strings  
            var names4= new LinkedList<string>();
            names4.AddLast("Sonoo Jaiswal");
            names4.AddLast("Ankit");
            names4.AddLast("Peter");
            names4.AddLast("Irfan");
            names4.AddFirst("John");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
