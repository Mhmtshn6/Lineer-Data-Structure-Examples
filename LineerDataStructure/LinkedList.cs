using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineerDataStructure
{
    internal class LinkedList
    {
        public void AddNum()
        {
            LinkedList linkedList = new LinkedList();

            // Add Nodes to Linked list
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);

            // Print All Nodes
            Console.WriteLine("Nodes in the Linked List:");
            linkedList.PrintAllNodes();

            // Remove a node to Linked list
            linkedList.Remove(3);

            //After the remove a node from linked list
            linkedList.PrintAllNodes();
            Console.ReadLine();
        }
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        // Add nodes to linked list
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Print all nodes
        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        // Remove a node to linked list
        public void Remove(int value)
        {
            if (head == null)
                return;

            if (head.Value == value)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
    class Node
    {
        public int Value { get; set; }     // Value stored in the node
        public Node Next { get; set; }    // Reference to the next node in the list

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
