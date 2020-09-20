using System;

namespace Exercise
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            //stack.Pop();
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            try
            {
                //stack.Clear();
                stack.Pop();
            }
            catch (Exception) 
            {
                Console.WriteLine("Throws as expected ...");
            }
            try
            {
                stack.Push(null);
            }
            catch (Exception)
            {
                Console.WriteLine("Throws as expected ...");
            }
        }
    }
}
