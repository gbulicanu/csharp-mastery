using System;

namespace MultipleInheritance
{
    public class UIControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {
        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}
