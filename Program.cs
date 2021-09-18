using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();//create the stack
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");

            foreach(string stackk in stack) //stack the string
            {
                Console.WriteLine(stackk); //display after stack
            }

            Console.WriteLine("Pop the first");
            stack.Pop(); //pop 1 from the top
            foreach (string pop in stack) 
            {
                Console.WriteLine(pop); //display after pop
            }

            Console.WriteLine("Peek");
            Console.WriteLine(stack.Peek()); //display after peek

        }
    }
}
