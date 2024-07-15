using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineerDataStructure
{
    internal class Queque
    {
        public void createQueque()
        {
            Queue<string> queue = new Queue<string>();
            // Create a Queue

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");
            //Add item in queue

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            // Print a Queue

            if (queue.Count > 0)
            {
                string removedItem = queue.Dequeue();
                //Remove the first item in queue
            }

            Console.WriteLine("\nTotal number of items in the Queue: " + queue.Count);
            // Print the total number of items in the Queue after the removed transaction

            
        }
    }
}
