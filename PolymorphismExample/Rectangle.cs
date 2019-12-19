using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExample
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle
            Console.WriteLine("Drawing a rectangle");
            base.Draw();
        }
    }
}
