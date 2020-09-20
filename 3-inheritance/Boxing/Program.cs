using System;
using System.Collections;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            
            // Boxing here
            list.Add(1);
            
            list.Add("George");
            
            // Boxing here
            list.Add(DateTime.Today);

            // Unboxing
            var number = (int)list[0];
            Console.WriteLine(number.ToString());
        }
    }
}
