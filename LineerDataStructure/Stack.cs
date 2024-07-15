using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineerDataStructure
{
    internal class Stack
    {
        public void createStack()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30); // Add Number to Stack


            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
            // Print Stack

            object topNum = stack.Pop();
            Console.WriteLine(topNum.ToString());
            // Print Top Number to Stack

            object poppedNum = stack.Pop();
            Console.WriteLine(poppedNum.ToString());
            // Deleted Top Number

            Console.WriteLine(stack.Count);

            int[] ArrayNum = stack.ToArray();
            // Carries Stack to Array

        }
    }
}
