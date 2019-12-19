using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExample
{
    class Circle : Shape
    {
        public override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }
}
