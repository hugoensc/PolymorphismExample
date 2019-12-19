using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExample
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}
