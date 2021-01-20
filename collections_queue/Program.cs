using System;
using System.Collections.Generic;


namespace collections_queue
{
    class Program
    {
        static void display(Queue<string> queue)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\t\tWelcome to Mcdonalds\t\t");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("=>");
            foreach (var v in queue)
            {
                Console.Write(v+",");
            }


        }
        static void Main(string[] args)
        {
            Queue<string> burgers = new Queue<string>();
            burgers.Enqueue("Happy Meal");
            burgers.Enqueue("Spicy Mc Crispy Deluxe");
            burgers.Enqueue("Big Mac");
            burgers.Enqueue("Sundae");
            burgers.Enqueue("Mc Arabia");

            display(burgers);
            Console.ReadKey();

            Console.WriteLine("Number of orders in a Queue= " + burgers.Count);
            

            Console.WriteLine("////////Dequeue first three orders from Queue///////////////////");
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine(i +" "+ burgers.Dequeue());
            }

            display(burgers);
            

            Console.WriteLine("First Order in Queue: " + burgers.Peek());
            Console.WriteLine("/////////////After peek order is not removed from queue//////////////////");
            display(burgers);
            

            Console.WriteLine("Enter Any item name to check it is in queue or not..:");
            string item = Console.ReadLine();
            if (burgers.Contains(item))
            {
                Console.WriteLine("Yes your meal is going to ready :)");
            }
            else
                Console.WriteLine("Sorry we didnt recieve your order :(");
        }
    }
}

