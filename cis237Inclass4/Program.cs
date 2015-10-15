using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new linked list.
            MyLinkedList myLinkedList = new MyLinkedList();

            // Populate linked list with a few nodes.
            myLinkedList.Add("First");
            myLinkedList.Add("Second");
            myLinkedList.Add("Third");
            myLinkedList.Add("Fourth");
            myLinkedList.Add("Cat");
            myLinkedList.Add("Sixth");

            Console.WriteLine();
            Console.WriteLine("Initial LinkedList, created from scratch by adding.");
            Console.WriteLine();

            // For loop to display node data to console.
            // Initialize, check, and incriment initialized.
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            Console.WriteLine();

            Console.WriteLine("Remove an item from linked list. Should be missing 'fifth' (aka cat) now.");
            Console.WriteLine();

            myLinkedList.Delete(5);

            // For loop to display node data to console.
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            Console.WriteLine();

            Console.WriteLine("Remove more items. Should be also missing 'second' and 'third' now.");
            Console.WriteLine();

            myLinkedList.Delete(2);
            myLinkedList.Delete(2);

            // For loop to display node data to console.
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            Console.WriteLine();

        }
    }
}
