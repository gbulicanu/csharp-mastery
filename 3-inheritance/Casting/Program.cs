using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var text = new Text();
            //// Upcastign
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            // StreamReader streamReader = new StreamReader(new MemoryStream());

            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("George");
            //list.Add(new Text());

            //var anotherList = new List<Shape>();
            //anotherList.Add(new Text());


            Shape shape = new Text();
            // Downcast
            Text text = (Text)shape;
            text.FontSize = 20;
        }
    }
}
